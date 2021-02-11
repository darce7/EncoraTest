using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EncoraTestBLL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distric = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<int>(type: "int", nullable: true),
                    ZipPlus4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplianceOwnership",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Refrigerator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dishwasher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Washer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dryer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Microwave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stove = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplianceOwnership", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Financial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapRate = table.Column<float>(type: "real", nullable: true),
                    Occupancy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSection8 = table.Column<bool>(type: "bit", nullable: false),
                    LeaseStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaseEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ListPrice = table.Column<float>(type: "real", nullable: false),
                    SalePrice = table.Column<float>(type: "real", nullable: true),
                    MarketValue = table.Column<float>(type: "real", nullable: true),
                    MonthlyHoa = table.Column<float>(type: "real", nullable: true),
                    MonthlyManagementFees = table.Column<float>(type: "real", nullable: true),
                    MonthlyRent = table.Column<float>(type: "real", nullable: false),
                    NetYield = table.Column<float>(type: "real", nullable: true),
                    TurnOverFee = table.Column<float>(type: "real", nullable: true),
                    RehabCosts = table.Column<float>(type: "real", nullable: true),
                    RehabDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YearlyInsuranceCost = table.Column<float>(type: "real", nullable: true),
                    YearlyPropertyTaxes = table.Column<float>(type: "real", nullable: true),
                    IsCashOnly = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoogleMapOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasStreeView = table.Column<bool>(type: "bit", nullable: false),
                    PovHeading = table.Column<int>(type: "int", nullable: false),
                    PovPitch = table.Column<int>(type: "int", nullable: false),
                    PovLatitude = table.Column<long>(type: "bigint", nullable: false),
                    PovLongitude = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoogleMapOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaseSummary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Occupancy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeasingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarketedRent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaseStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaseEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MonthlyRent = table.Column<float>(type: "real", nullable: true),
                    SecurityDepositAmount = table.Column<float>(type: "real", nullable: true),
                    IsPetsDeposit = table.Column<bool>(type: "bit", nullable: true),
                    PetsDepositAmount = table.Column<float>(type: "real", nullable: true),
                    IsLeaseConcessions = table.Column<bool>(type: "bit", nullable: true),
                    IsRentersInsuranceRequired = table.Column<bool>(type: "bit", nullable: true),
                    IsSection8 = table.Column<bool>(type: "bit", nullable: true),
                    IsTenantBackgroudChecked = table.Column<bool>(type: "bit", nullable: true),
                    IsTenantIncomeAbove3x = table.Column<bool>(type: "bit", nullable: true),
                    IsTenantMayTerminateEarly = table.Column<bool>(type: "bit", nullable: true),
                    IsTenantPurchaseOption = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaseSummary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Physical",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BathRooms = table.Column<float>(type: "real", nullable: true),
                    BedRooms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParcelNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPool = table.Column<bool>(type: "bit", nullable: false),
                    LotSize = table.Column<float>(type: "real", nullable: true),
                    SquareFeet = table.Column<float>(type: "real", nullable: true),
                    Stories = table.Column<int>(type: "int", nullable: true),
                    Units = table.Column<int>(type: "int", nullable: true),
                    YearBuilt = table.Column<int>(type: "int", nullable: true),
                    ZipYearBuilt = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Physical", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionScore = table.Column<int>(type: "int", nullable: true),
                    CrimeScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeighborhoodScore = table.Column<int>(type: "int", nullable: true),
                    OverallScore = table.Column<int>(type: "int", nullable: true),
                    QualityScore = table.Column<int>(type: "int", nullable: true),
                    SchoolScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloodRiskScore = table.Column<int>(type: "int", nullable: true),
                    WalkabilityScore = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UtilitiesOwnership",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Electric = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Water = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Garbage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Landscaping = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PestControl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilitiesOwnership", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Valuation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvmBpoValue = table.Column<float>(type: "real", nullable: true),
                    AvmBpoAdjValue = table.Column<float>(type: "real", nullable: true),
                    AvmBpoDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RsAvmValue = table.Column<float>(type: "real", nullable: true),
                    RsAvmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RsBpoMergeValue = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valuation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Audio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Audio_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeInByte = table.Column<long>(type: "bigint", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlMedium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlSmall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceId = table.Column<int>(type: "int", nullable: true),
                    ResourceId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Photo_Resource_ResourceId1",
                        column: x => x.ResourceId1,
                        principalTable: "Resource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThreeDRendering",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreeDRendering", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThreeDRendering_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lease",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaseSummaryId = table.Column<int>(type: "int", nullable: true),
                    UtilitiesOwnershipId = table.Column<int>(type: "int", nullable: true),
                    ApplianceOwnershipId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lease_ApplianceOwnership_ApplianceOwnershipId",
                        column: x => x.ApplianceOwnershipId,
                        principalTable: "ApplianceOwnership",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lease_LeaseSummary_LeaseSummaryId",
                        column: x => x.LeaseSummaryId,
                        principalTable: "LeaseSummary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lease_UtilitiesOwnership_UtilitiesOwnershipId",
                        column: x => x.UtilitiesOwnershipId,
                        principalTable: "UtilitiesOwnership",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    BuyerAccountId = table.Column<int>(type: "int", nullable: true),
                    ExternalId = table.Column<int>(type: "int", nullable: true),
                    ProgramId = table.Column<int>(type: "int", nullable: true),
                    IsDwellCertified = table.Column<bool>(type: "bit", nullable: true),
                    IsAllowOffer = table.Column<bool>(type: "bit", nullable: true),
                    IsAllowPreview = table.Column<bool>(type: "bit", nullable: true),
                    IsFeature = table.Column<bool>(type: "bit", nullable: true),
                    IsRentGuaranteed = table.Column<bool>(type: "bit", nullable: true),
                    AllowRentGuaranteedOptout = table.Column<bool>(type: "bit", nullable: true),
                    IsSecuritized = table.Column<bool>(type: "bit", nullable: true),
                    IsHot = table.Column<bool>(type: "bit", nullable: true),
                    IsNew = table.Column<bool>(type: "bit", nullable: true),
                    IsBargain = table.Column<bool>(type: "bit", nullable: true),
                    IsDiligenceVaultUnlocked = table.Column<bool>(type: "bit", nullable: true),
                    IsPropertyManagerOfferRetain = table.Column<bool>(type: "bit", nullable: true),
                    IsHoa = table.Column<bool>(type: "bit", nullable: true),
                    HasAudio = table.Column<bool>(type: "bit", nullable: true),
                    HasDiligenceVaultDocuments = table.Column<bool>(type: "bit", nullable: true),
                    MarketId = table.Column<int>(type: "int", nullable: true),
                    DaysOnMarket = table.Column<int>(type: "int", nullable: true),
                    Latitude = table.Column<long>(type: "bigint", nullable: true),
                    Longitude = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Highlights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiligenceVaultSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowedFundingTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowableSaleTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceVisibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificationLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EscrowClosingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    FinancialId = table.Column<int>(type: "int", nullable: true),
                    PhysicalId = table.Column<int>(type: "int", nullable: true),
                    ScoreId = table.Column<int>(type: "int", nullable: true),
                    ValuationId = table.Column<int>(type: "int", nullable: true),
                    ResourceId = table.Column<int>(type: "int", nullable: true),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellerBroker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaseId = table.Column<int>(type: "int", nullable: true),
                    GoogleMapOptionId = table.Column<int>(type: "int", nullable: true),
                    InspectionType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_Financial_FinancialId",
                        column: x => x.FinancialId,
                        principalTable: "Financial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_GoogleMapOption_GoogleMapOptionId",
                        column: x => x.GoogleMapOptionId,
                        principalTable: "GoogleMapOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_Lease_LeaseId",
                        column: x => x.LeaseId,
                        principalTable: "Lease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_Physical_PhysicalId",
                        column: x => x.PhysicalId,
                        principalTable: "Physical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_Score_ScoreId",
                        column: x => x.ScoreId,
                        principalTable: "Score",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_Valuation_ValuationId",
                        column: x => x.ValuationId,
                        principalTable: "Valuation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diligence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diligence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diligence_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Audio_ResourceId",
                table: "Audio",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Diligence_PropertyId",
                table: "Diligence",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Lease_ApplianceOwnershipId",
                table: "Lease",
                column: "ApplianceOwnershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Lease_LeaseSummaryId",
                table: "Lease",
                column: "LeaseSummaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Lease_UtilitiesOwnershipId",
                table: "Lease",
                column: "UtilitiesOwnershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_ResourceId",
                table: "Photo",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_ResourceId1",
                table: "Photo",
                column: "ResourceId1");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AddressId",
                table: "Properties",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_FinancialId",
                table: "Properties",
                column: "FinancialId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_GoogleMapOptionId",
                table: "Properties",
                column: "GoogleMapOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_LeaseId",
                table: "Properties",
                column: "LeaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PhysicalId",
                table: "Properties",
                column: "PhysicalId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ResourceId",
                table: "Properties",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ScoreId",
                table: "Properties",
                column: "ScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ValuationId",
                table: "Properties",
                column: "ValuationId");

            migrationBuilder.CreateIndex(
                name: "IX_ThreeDRendering_ResourceId",
                table: "ThreeDRendering",
                column: "ResourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audio");

            migrationBuilder.DropTable(
                name: "Diligence");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "ThreeDRendering");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Financial");

            migrationBuilder.DropTable(
                name: "GoogleMapOption");

            migrationBuilder.DropTable(
                name: "Lease");

            migrationBuilder.DropTable(
                name: "Physical");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "Valuation");

            migrationBuilder.DropTable(
                name: "ApplianceOwnership");

            migrationBuilder.DropTable(
                name: "LeaseSummary");

            migrationBuilder.DropTable(
                name: "UtilitiesOwnership");
        }
    }
}
