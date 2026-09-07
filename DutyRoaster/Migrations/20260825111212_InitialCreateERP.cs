using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DutyRoaster.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateERP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShiftSetting");

            migrationBuilder.DropColumn(
                name: "BRPNo",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CertificateNumber",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CurrentAge",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DrivingLicenceFile",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmergencyContact",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeFile",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "GuardianAddres",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "GuardianName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "GuardianPhone",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "GuardianRelation",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "IDCardFile",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "IsDrivingLicence",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "IsVehicle",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "NINO",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "OtherDocumentsFile",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PassportFile",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SIALicenceFile",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SIATypeId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SiaExpiry",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SiaLicenceNo",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "VisaFile",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "AccountSubmissionExpiryDate",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "ActivationCode",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "AddressHistory",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "AuthenticationCode",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "CardPercentage",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "City",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "CompanyNumber",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "ConfirmationStatementExpiryDate",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "DateofBirth",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "Domain",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "HMRCUserId",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "HomeAddress",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "HostName",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "IDOrPassportOrLicence",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "InvoiceNoPrefix",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "IsAccountSubmission",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "IsConfirmationStatement",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "IsVat",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "MobileMadeOrModel",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "MobileNetwork",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "NINo",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "NameofOwner",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "NetDueDays",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "Office",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "OfficeSubscription",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "QuoteNoPrefix",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "ShopNo",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "SicCode",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "SocialMediaAccount",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "Terms",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "TermsAndCondition",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "TermsAndConditionItemSale",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "UTRNo",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "UploadImage",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "VATExpiryDate",
                table: "CompanyInfos");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "UserProfile",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "visaCategoryId",
                table: "Employee",
                newName: "GenderId");

            migrationBuilder.RenameColumn(
                name: "WhitelistIP",
                table: "CompanyInfos",
                newName: "STRN");

            migrationBuilder.RenameColumn(
                name: "VatNumber",
                table: "CompanyInfos",
                newName: "NTN");

            migrationBuilder.AlterColumn<Guid>(
                name: "ApplicationUserId",
                table: "UserProfile",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BranchIdGUID",
                table: "UserProfile",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "UserProfile",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyIdGUID",
                table: "UserProfile",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "UserProfile",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoginName",
                table: "UserProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BranchIdGUID",
                table: "ProjectInfo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyIdGUID",
                table: "ProjectInfo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectGUID",
                table: "ProjectInfo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BranchIdGUID",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyIdGUID",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeIdGUID",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "CompanyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyIdGUID",
                table: "CompanyInfos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "CompanyInfos",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BranchIdGUID",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "CompanyIdGUID",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "LoginName",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "BranchIdGUID",
                table: "ProjectInfo");

            migrationBuilder.DropColumn(
                name: "CompanyIdGUID",
                table: "ProjectInfo");

            migrationBuilder.DropColumn(
                name: "ProjectGUID",
                table: "ProjectInfo");

            migrationBuilder.DropColumn(
                name: "BranchIdGUID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CompanyIdGUID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeIdGUID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "CompanyIdGUID",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "CompanyInfos");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "UserProfile",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "GenderId",
                table: "Employee",
                newName: "visaCategoryId");

            migrationBuilder.RenameColumn(
                name: "STRN",
                table: "CompanyInfos",
                newName: "WhitelistIP");

            migrationBuilder.RenameColumn(
                name: "NTN",
                table: "CompanyInfos",
                newName: "VatNumber");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "UserProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BRPNo",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CertificateNumber",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentAge",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DrivingLicenceFile",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContact",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeFile",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "GuardianAddres",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuardianName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuardianPhone",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuardianRelation",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IDCardFile",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDrivingLicence",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVehicle",
                table: "Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NINO",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherDocumentsFile",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportFile",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SIALicenceFile",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SIATypeId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "SiaExpiry",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SiaLicenceNo",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VisaFile",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AccountSubmissionExpiryDate",
                table: "CompanyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ActivationCode",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressHistory",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthenticationCode",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardPercentage",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyNumber",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ConfirmationStatementExpiryDate",
                table: "CompanyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CompanyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DateofBirth",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Domain",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HMRCUserId",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HostName",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IDOrPassportOrLicence",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceNoPrefix",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAccountSubmission",
                table: "CompanyInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmationStatement",
                table: "CompanyInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVat",
                table: "CompanyInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileMadeOrModel",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNetwork",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CompanyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NINo",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameofOwner",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NetDueDays",
                table: "CompanyInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Office",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeSubscription",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuoteNoPrefix",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopNo",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SicCode",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialMediaAccount",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Terms",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TermsAndCondition",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TermsAndConditionItemSale",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UTRNo",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UploadImage",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VATExpiryDate",
                table: "CompanyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ShiftSetting",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftEndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ShiftId = table.Column<long>(type: "bigint", nullable: false),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftStartTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftSetting", x => x.Id);
                });
        }
    }
}
