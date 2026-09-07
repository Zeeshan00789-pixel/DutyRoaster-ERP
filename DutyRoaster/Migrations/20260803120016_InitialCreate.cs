using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DutyRoaster.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyInfos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNoPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuoteNoPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Office = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermsAndCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermsAndConditionItemSale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VATExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CardPercentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVat = table.Column<bool>(type: "bit", nullable: false),
                    WhitelistIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    NetDueDays = table.Column<int>(type: "int", nullable: false),
                    Terms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthenticationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HMRCUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDOrPassportOrLicence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NINo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameofOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UTRNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmationStatementExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsConfirmationStatement = table.Column<bool>(type: "bit", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileMadeOrModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeSubscription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SicCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountSubmissionExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAccountSubmission = table.Column<bool>(type: "bit", nullable: false),
                    MobileNetwork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyInfos");
        }
    }
}
