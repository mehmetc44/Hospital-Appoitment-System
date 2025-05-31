using Dapper;
using MedikApp.DTO.PersonDtos;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using MedikApp.WebApi.Model.DbContext;

namespace MedikApp.WebApi.Repositories.PersonRepositories
{
    public class PersonRepo : IPersonRepo
    {
        public readonly Context _context;

        public PersonRepo(Context context)
        {
            _context = context;
        }

        public async Task<bool> ChangePassword(ChangePasswordDto changePasswordDto)
        {
            var passwordCheck = "SELECT Sifre FROM kisiler WHERE TcNumara = @id";
            var checkParameters = new DynamicParameters();
            checkParameters.Add("@id",changePasswordDto.TcNumara);

            var changePasswordQuery = "UPDATE kisiler SET sifre = @sifre WHERE TcNumara = @id ";
            var changeParameters = new DynamicParameters();
            changeParameters.Add("@sifre",changePasswordDto.NewPassword);
            changeParameters.Add("@id",changePasswordDto.TcNumara);

            using(var connection = _context.CreateConnection())
            {
                var oldPassword = await connection.ExecuteScalarAsync<string>(passwordCheck,checkParameters);
                Console.Write(oldPassword);

                if(oldPassword == changePasswordDto.OldPassword)
                {
                    var affectedRows = await connection.ExecuteAsync(changePasswordQuery, changeParameters);
                    if (affectedRows > 0)
                    {
                        return ( true);
                    }
                    else
                    {
                        return (false);
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<PersonInfoDto> GetPersonInfo(string TcNumara)
        {
            var query = "SELECT kisiler.Id AS KisiId,  kisiler.Isim,kisiler.DogumTarihi, " +
                " saglik.KanGurubu, saglik.Boy,  saglik.Kilo,   kisiler.Cinsiyet, kisiler.TelNo FROM kisiler " +
                "LEFT JOIN saglik ON kisiler.Id = saglik.KisiId WHERE kisiler.TcNumara = @tc";
            var parameters = new DynamicParameters();
            parameters.Add("@tc", TcNumara);

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryFirstOrDefaultAsync<PersonInfoDto>(query, parameters);

                return result;
            }
        }

        public async Task<bool> PersonLogin(PersonLoginDto personLoginDto)
        {
            var loginQuery = "SELECT COUNT(1) FROM kisiler WHERE TcNumara = @tc AND Sifre = @sifre";
            var parameters = new DynamicParameters();
            parameters.Add("@tc", personLoginDto.TcNumara);
            parameters.Add("@sifre", personLoginDto.Sifre);

            Console.Write(personLoginDto.TcNumara);
            using (var connection = _context.CreateConnection())
            {
                var count = await connection.ExecuteScalarAsync<int>(loginQuery, parameters);
                Console.Write(personLoginDto.TcNumara);
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<(string message, bool status)> PersonRegister(PersonRegisterDto personRegisterDto)
        {
            var tcCheck = "SELECT COUNT(1) FROM kisiler WHERE TcNumara = @tc";
            var tcParameters = new DynamicParameters();
            tcParameters.Add("@tc",personRegisterDto.TcNumara);

            var telCheck = "SELECT COUNT(1) FROM kisiler WHERE TelNo = @tel";
            var telParameters = new DynamicParameters();
            telParameters.Add("@tel",personRegisterDto.TelefonNo);

            var registerQuery = "INSERT INTO kisiler (TcNumara,Isim,DogumTarihi,Cinsiyet,TelNo,Sifre) " +
                            "VALUES(@tc,@isim,@dg,@cinsiyet,@tel,@sifre)";
            var parameters = new DynamicParameters();
            parameters.Add("@tc",personRegisterDto.TcNumara);
            parameters.Add("@isim",personRegisterDto.Isim);
            parameters.Add("@dg", personRegisterDto.DogumTarihi);
            parameters.Add("@cinsiyet", personRegisterDto.Cinsiyet);
            parameters.Add("@tel", personRegisterDto.TelefonNo);
            parameters.Add("@sifre", personRegisterDto.Sifre);

            using(var connection = _context.CreateConnection())
            {
                var tcExists = await connection.ExecuteScalarAsync<int>(tcCheck,tcParameters);
                Console.WriteLine(tcExists);

                if(tcExists > 0)
                {
                    return ("Bu Tc Numarası Kayıtlıdır",false);
                }
                else
                {
                    var telExists = await connection.ExecuteScalarAsync<int>(telCheck,telParameters);
                    Console.WriteLine(telExists);

                    if(telExists > 0)
                    {
                        return ("Bu Telefon Numarası Kayıtlıdır", false);
                    }
                    else
                    {
                        var affectedRows = await connection.ExecuteAsync(registerQuery, parameters);
                        if(affectedRows > 0)
                        {
                            return ("Başarıyla Eklendi", true);
                        }
                        else
                        {
                            return ("Maalesef Kayıt Olamadınız", false);
                        }
                    }
                }
            }
        }

        public async Task<(string message, bool status)> UpdateInfoPerson(UpdateInfoPersonDto updateInfoPersonDto)
        {
            var getIdQuery = "SELECT Id FROM kisiler WHERE TcNumara = @tc";
            var getIdParameters = new DynamicParameters();
            getIdParameters.Add("@tc", updateInfoPersonDto.TcNumara);

            using (var connection = _context.CreateConnection())
            {
                var personId = await connection.ExecuteScalarAsync<int?>(getIdQuery, getIdParameters);

                if (personId == null)
                {
                    return ("Person with the given TC number does not exist.", false);
                }

                var checkIdQuery = "SELECT COUNT(1) FROM saglik WHERE KisiId = @id";
                var checkIdParameters = new DynamicParameters();
                checkIdParameters.Add("@id", personId);

                var saglikExists = await connection.ExecuteScalarAsync<int>(checkIdQuery, checkIdParameters);

                if (saglikExists > 0)
                {
                    var updateQuery = @"
                    UPDATE saglik 
                    SET Boy = @boy, 
                    Kilo = @kilo, 
                    KanGurubu = @kangrubu 
                    WHERE KisiId = @kisiId; 
                    
                    UPDATE kisiler  
                    SET TelNo = @TelNo 
                    WHERE Id = @kisiIdd;";
                    var updateParameters = new DynamicParameters();
                    updateParameters.Add("@kisiId", personId);
                    updateParameters.Add("@boy", updateInfoPersonDto.Boy);
                    updateParameters.Add("@kilo", updateInfoPersonDto.Kilo);
                    updateParameters.Add("@kangrubu", updateInfoPersonDto.KanGurubu);
                    updateParameters.Add("@TelNo",updateInfoPersonDto.TelNo);
                    updateParameters.Add("@kisiIdd", personId);
                    await connection.ExecuteAsync(updateQuery, updateParameters);

                    return ("Person information updated successfully.", true);
                }
                else
                {
                    var insertQuery = @"
                INSERT INTO saglik (KisiId, Boy, Kilo, KanGurubu) 
                VALUES (@kisiId, @boy, @kilo, @kangrubu); 
                
                UPDATE kisiler 
                SET TelNo = @TelNo
                WHERE Id = @kisiIdd;";
                    var insertParameters = new DynamicParameters();
                    insertParameters.Add("@kisiId", personId);
                    insertParameters.Add("@boy", updateInfoPersonDto.Boy);
                    insertParameters.Add("@kilo", updateInfoPersonDto.Kilo);
                    insertParameters.Add("@kangrubu", updateInfoPersonDto.KanGurubu);
                    insertParameters.Add("@TelNo", updateInfoPersonDto.TelNo);
                    insertParameters.Add("@kidiIdd",personId);
                    await connection.ExecuteAsync(insertQuery, insertParameters);

                    return ("Person information inserted successfully.", true);
                }
            }
        }



    }
}
