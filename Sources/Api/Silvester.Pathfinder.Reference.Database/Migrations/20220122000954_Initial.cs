using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NpgsqlTypes;

namespace Silvester.Pathfinder.Reference.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AncestrySizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Space = table.Column<int>(type: "integer", nullable: false),
                    HeightReach = table.Column<int>(type: "integer", nullable: false),
                    BreadthReach = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AncestrySizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimalCompanion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalCompanion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArmorCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttackTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttackTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BenefitTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bulks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LightWeight = table.Column<int>(type: "integer", nullable: false),
                    BulkWeight = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bulks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConditionCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DamageTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeityCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeityCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DivineFonts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivineFonts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EffectShape",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectShape", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Frequency",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    TimeSpan = table.Column<TimeSpan>(type: "interval", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frequency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HarrowModes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarrowModes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HazardComplexities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardComplexities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HazardImmunities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardImmunities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InnovationModificationTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InnovationModificationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PageNumber = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MagicEssences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicEssences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MagicSchools",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Abbreviation = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RuneMagicSchoolId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description", "Abbreviation" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicSchools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MagicTraditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicTraditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjectGrade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectGrade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaneCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaneCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayModes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayModes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Potencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Potencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialGrade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialGrade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialItemCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialItemCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proficiencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Bonus = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rarities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rarities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavingThrowStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingThrowStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpellComponents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellComponents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpellTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Abbreviation = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description", "Abbreviation" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnarmedWeapons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnarmedWeapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_LanguageTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "LanguageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BaseHealth = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DuringCombatEncounters = table.Column<string>(type: "text", nullable: false),
                    DuringSocialEncounters = table.Column<string>(type: "text", nullable: false),
                    WhileExploring = table.Column<string>(type: "text", nullable: false),
                    InDowntime = table.Column<string>(type: "text", nullable: false),
                    PerceptionProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    FortitudeProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    WillProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReflexProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    SimpleWeaponProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    MartialWeaponProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    AdvancedWeaponProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    UnarmedWeaponProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    UnarmoredProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    LightArmorProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    MediumArmorProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    HeavyArmorProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClassDcProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpellDcProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpellAttackProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    PredefinedMagicTraditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description", "WhileExploring" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_MagicTraditions_PredefinedMagicTraditionId",
                        column: x => x.PredefinedMagicTraditionId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_AdvancedWeaponProficiencyId",
                        column: x => x.AdvancedWeaponProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_ClassDcProficiencyId",
                        column: x => x.ClassDcProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_FortitudeProficiencyId",
                        column: x => x.FortitudeProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_HeavyArmorProficiencyId",
                        column: x => x.HeavyArmorProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_LightArmorProficiencyId",
                        column: x => x.LightArmorProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_MartialWeaponProficiencyId",
                        column: x => x.MartialWeaponProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_MediumArmorProficiencyId",
                        column: x => x.MediumArmorProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_PerceptionProficiencyId",
                        column: x => x.PerceptionProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_ReflexProficiencyId",
                        column: x => x.ReflexProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_SimpleWeaponProficiencyId",
                        column: x => x.SimpleWeaponProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_SpellAttackProficiencyId",
                        column: x => x.SpellAttackProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_SpellDcProficiencyId",
                        column: x => x.SpellDcProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_UnarmedWeaponProficiencyId",
                        column: x => x.UnarmedWeaponProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_UnarmoredProficiencyId",
                        column: x => x.UnarmoredProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Proficiencies_WillProficiencyId",
                        column: x => x.WillProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavingThrowStats_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingThrowStats_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavingThrowStats_Details_SavingThrowStats_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "SavingThrowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaggeredEffect",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Addendum = table.Column<string>(type: "text", nullable: true),
                    Level = table.Column<int>(type: "integer", nullable: true),
                    Onset = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DifficultyCheck = table.Column<int>(type: "integer", nullable: true),
                    MaximumDuration = table.Column<string>(type: "text", nullable: false),
                    SavingThrowStatId = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaggeredEffect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaggeredEffect_SavingThrowStats_SavingThrowStatId",
                        column: x => x.SavingThrowStatId,
                        principalTable: "SavingThrowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SourcePage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Page = table.Column<int>(type: "integer", nullable: true),
                    SourceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourcePage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SourcePage_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Choice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    StatId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Choice_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HarrowCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Effects = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    AffectedStatId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Effects", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarrowCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HarrowCategories_Stats_AffectedStatId",
                        column: x => x.AffectedStatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoreCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Examples = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    StatModifierId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoreCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoreCategories_Stats_StatModifierId",
                        column: x => x.StatModifierId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    StatModifierId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lores_Stats_StatModifierId",
                        column: x => x.StatModifierId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    HasArmorCheckPenalty = table.Column<bool>(type: "boolean", nullable: false),
                    HasRecallKnowledgeAction = table.Column<bool>(type: "boolean", nullable: false),
                    StatModifierId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Stats_StatModifierId",
                        column: x => x.StatModifierId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Column",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Column", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Column_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Row",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Row", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Row_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassCharacteristic",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    ClassId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCharacteristic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassCharacteristic_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassMannerism",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    ClassId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassMannerism", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassMannerism_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassStat",
                columns: table => new
                {
                    KeyAbilitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    KeyAbilityClassesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassStat", x => new { x.KeyAbilitiesId, x.KeyAbilityClassesId });
                    table.ForeignKey(
                        name: "FK_ClassStat_Classes_KeyAbilityClassesId",
                        column: x => x.KeyAbilityClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassStat_Stats_KeyAbilitiesId",
                        column: x => x.KeyAbilitiesId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaggeredEffectStage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Stage = table.Column<int>(type: "integer", nullable: false),
                    Duration = table.Column<string>(type: "text", nullable: false),
                    StaggeredEffectId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaggeredEffectStage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaggeredEffectStage_StaggeredEffect_StaggeredEffectId",
                        column: x => x.StaggeredEffectId,
                        principalTable: "StaggeredEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArmorGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ArmorSpecializationEffect = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "ArmorSpecializationEffect" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArmorGroups_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: true),
                    ConditionCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    OverridesConditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conditions_ConditionCategories_ConditionCategoryId",
                        column: x => x.ConditionCategoryId,
                        principalTable: "ConditionCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conditions_Conditions_OverridesConditionId",
                        column: x => x.OverridesConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conditions_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Curses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Effect = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: true),
                    DifficultyCheck = table.Column<int>(type: "integer", nullable: true),
                    SavingThrowStatId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Effect" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curses_SavingThrowStats_SavingThrowStatId",
                        column: x => x.SavingThrowStatId,
                        principalTable: "SavingThrowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curses_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DifficultyCheck = table.Column<int>(type: "integer", nullable: true),
                    Spoilers = table.Column<bool>(type: "boolean", nullable: false),
                    Onset = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: true),
                    SavingThrowStatId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description", "Onset" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diseases_SavingThrowStats_SavingThrowStatId",
                        column: x => x.SavingThrowStatId,
                        principalTable: "SavingThrowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diseases_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DivineAllies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivineAllies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DivineAllies_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DivineIntercession",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    MinorBoon = table.Column<string>(type: "text", nullable: false),
                    ModerateBoon = table.Column<string>(type: "text", nullable: false),
                    MajorBoon = table.Column<string>(type: "text", nullable: false),
                    MinorCurse = table.Column<string>(type: "text", nullable: false),
                    ModerateCurse = table.Column<string>(type: "text", nullable: false),
                    MajorCurse = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivineIntercession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DivineIntercession_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DraconicExemplars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Dragon = table.Column<string>(type: "text", nullable: false),
                    EffectShapeId = table.Column<Guid>(type: "uuid", nullable: false),
                    DamageTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    SavingThrowStatId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Dragon" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DraconicExemplars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DraconicExemplars_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DraconicExemplars_EffectShape_EffectShapeId",
                        column: x => x.EffectShapeId,
                        principalTable: "EffectShape",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DraconicExemplars_SavingThrowStats_SavingThrowStatId",
                        column: x => x.SavingThrowStatId,
                        principalTable: "SavingThrowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DraconicExemplars_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamiliarAbilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamiliarAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamiliarAbilities_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HazardTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HazardTypes_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstinctAbilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstinctAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstinctAbilities_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstinctAbilities_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemCurses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Usage = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Usage" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCurses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCurses_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterAbilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MasterAbilities_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MysteryCurse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MysteryId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MysteryCurse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MysteryCurse_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MysteryCurse_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Philosophies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Edicts = table.Column<string>(type: "text", nullable: true),
                    Anathema = table.Column<string>(type: "text", nullable: true),
                    AreasOfConcern = table.Column<string>(type: "text", nullable: true),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Anathema", "AreasOfConcern", "Edicts" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Philosophies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Philosophies_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialArmors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialArmors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialArmors_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialShields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialShields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialShields_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialWeapons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialWeapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialWeapons_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rules_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SenseAccuracy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SenseAccuracy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SenseAccuracy_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Senses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Senses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Senses_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tenets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tenets_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Traits_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UtilityGear",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Usage = table.Column<string>(type: "text", nullable: true),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Usage" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilityGear", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UtilityGear_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CriticalEffect = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "CriticalEffect" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponGroups_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureRecallKnowledge",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DifficultyCheck = table.Column<int>(type: "integer", nullable: false),
                    CreatureId = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureRecallKnowledge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureRecallKnowledge_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EffectIncrementTrigger",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: true),
                    ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectIncrementTrigger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EffectIncrementTrigger_Proficiencies_ProficiencyId",
                        column: x => x.ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EffectIncrementTrigger_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillBenefit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: false),
                    BenefitTypeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillBenefit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillBenefit_BenefitTypes_BenefitTypeId",
                        column: x => x.BenefitTypeId,
                        principalTable: "BenefitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillBenefit_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cell",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RowId = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cell_Row_RowId",
                        column: x => x.RowId,
                        principalTable: "Row",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Details_Activities_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conditions_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conditions_Details_Conditions_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaggeredEffectStageEffect",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Permanent = table.Column<bool>(type: "boolean", nullable: false),
                    StaggeredEffectStageId = table.Column<Guid>(type: "uuid", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    ConditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    Severity = table.Column<int>(type: "integer", nullable: true),
                    Damage = table.Column<string>(type: "text", nullable: true),
                    Every = table.Column<string>(type: "text", nullable: true),
                    IsDamagePersistent = table.Column<bool>(type: "boolean", nullable: true),
                    DamageTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    Effect = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaggeredEffectStageEffect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaggeredEffectStageEffect_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaggeredEffectStageEffect_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaggeredEffectStageEffect_StaggeredEffectStage_StaggeredEf~",
                        column: x => x.StaggeredEffectStageId,
                        principalTable: "StaggeredEffectStage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Curses_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curses_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curses_Details_Curses_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Curses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseStage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Stage = table.Column<int>(type: "integer", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "interval", nullable: true),
                    DiseaseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseStage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiseaseStage_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hazards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ArmorClass = table.Column<int>(type: "integer", nullable: true),
                    Reset = table.Column<string>(type: "text", nullable: true),
                    Speed = table.Column<int>(type: "integer", nullable: true),
                    Fortitude = table.Column<int>(type: "integer", nullable: true),
                    Reflex = table.Column<int>(type: "integer", nullable: true),
                    RoutineActions = table.Column<int>(type: "integer", nullable: true),
                    CanBeDetectedMagically = table.Column<bool>(type: "boolean", nullable: false),
                    ComplexityId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    TypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hazards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hazards_HazardComplexities_ComplexityId",
                        column: x => x.ComplexityId,
                        principalTable: "HazardComplexities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hazards_HazardTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "HazardTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hazards_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCurses_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCurses_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCurses_Details_ItemCurses_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "ItemCurses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MysteryCurse_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MysteryCurse_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MysteryCurse_Details_MysteryCurse_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "MysteryCurse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MysteryCursePotency",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MysteryCurseId = table.Column<Guid>(type: "uuid", nullable: false),
                    PotencyId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MysteryCursePotency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MysteryCursePotency_MysteryCurse_MysteryCurseId",
                        column: x => x.MysteryCurseId,
                        principalTable: "MysteryCurse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MysteryCursePotency_Potencies_PotencyId",
                        column: x => x.PotencyId,
                        principalTable: "Potencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alignments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" }),
                    PhilosophyId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alignments_Philosophies_PhilosophyId",
                        column: x => x.PhilosophyId,
                        principalTable: "Philosophies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Philosophies_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Philosophies_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Philosophies_Details_Philosophies_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Philosophies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialArmors_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialArmors_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialArmors_Details_PreciousMaterialArmors_Owner~",
                        column: x => x.OwnerId,
                        principalTable: "PreciousMaterialArmors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialArmorVariant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CraftRequirements = table.Column<string>(type: "text", nullable: false),
                    ItemLevel = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    AdditionalPricePerBulk = table.Column<int>(type: "integer", nullable: false),
                    ArmorId = table.Column<Guid>(type: "uuid", nullable: false),
                    GradeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialArmorVariant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialArmorVariant_ObjectGrade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "ObjectGrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialArmorVariant_PreciousMaterialArmors_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "PreciousMaterialArmors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialShields_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialShields_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialShields_Details_PreciousMaterialShields_Own~",
                        column: x => x.OwnerId,
                        principalTable: "PreciousMaterialShields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialShieldVariant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CraftRequirements = table.Column<string>(type: "text", nullable: false),
                    ItemLevel = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Hardness = table.Column<int>(type: "integer", nullable: false),
                    HitPoints = table.Column<int>(type: "integer", nullable: false),
                    BrokenThreshold = table.Column<int>(type: "integer", nullable: false),
                    ShieldId = table.Column<Guid>(type: "uuid", nullable: false),
                    BulkId = table.Column<Guid>(type: "uuid", nullable: false),
                    GradeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialShieldVariant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialShieldVariant_Bulks_BulkId",
                        column: x => x.BulkId,
                        principalTable: "Bulks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialShieldVariant_ObjectGrade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "ObjectGrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialShieldVariant_PreciousMaterialShields_Shiel~",
                        column: x => x.ShieldId,
                        principalTable: "PreciousMaterialShields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    WeaponId = table.Column<Guid>(type: "uuid", nullable: true),
                    ArmorId = table.Column<Guid>(type: "uuid", nullable: true),
                    ShieldId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterials_PreciousMaterialArmors_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "PreciousMaterialArmors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreciousMaterials_PreciousMaterialShields_ShieldId",
                        column: x => x.ShieldId,
                        principalTable: "PreciousMaterialShields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreciousMaterials_PreciousMaterialWeapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "PreciousMaterialWeapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreciousMaterials_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialWeapons_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialWeapons_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialWeapons_Details_PreciousMaterialWeapons_Own~",
                        column: x => x.OwnerId,
                        principalTable: "PreciousMaterialWeapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialWeaponVariant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CraftRequirements = table.Column<string>(type: "text", nullable: false),
                    ItemLevel = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    AdditionalPricePerBulk = table.Column<int>(type: "integer", nullable: false),
                    WeaponId = table.Column<Guid>(type: "uuid", nullable: false),
                    GradeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialWeaponVariant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialWeaponVariant_ObjectGrade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "ObjectGrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialWeaponVariant_PreciousMaterialWeapons_Weapo~",
                        column: x => x.WeaponId,
                        principalTable: "PreciousMaterialWeapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rules_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rules_Details_Rules_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Senses_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Senses_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Senses_Details_Senses_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Senses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tenets_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenets_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tenets_Details_Tenets_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Tenets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityTrait",
                columns: table => new
                {
                    ActivitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTrait", x => new { x.ActivitiesId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_ActivityTrait_Activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurseTrait",
                columns: table => new
                {
                    CursesId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurseTrait", x => new { x.CursesId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_CurseTrait_Curses_CursesId",
                        column: x => x.CursesId,
                        principalTable: "Curses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurseTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseTrait",
                columns: table => new
                {
                    DiseasesId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseTrait", x => new { x.DiseasesId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_DiseaseTrait_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCurseTrait",
                columns: table => new
                {
                    ItemCursesId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCurseTrait", x => new { x.ItemCursesId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_ItemCurseTrait_ItemCurses_ItemCursesId",
                        column: x => x.ItemCursesId,
                        principalTable: "ItemCurses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCurseTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialArmorTrait",
                columns: table => new
                {
                    PreciousMaterialArmorsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialArmorTrait", x => new { x.PreciousMaterialArmorsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_PreciousMaterialArmorTrait_PreciousMaterialArmors_PreciousM~",
                        column: x => x.PreciousMaterialArmorsId,
                        principalTable: "PreciousMaterialArmors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialArmorTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialShieldTrait",
                columns: table => new
                {
                    PreciousMaterialShieldsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialShieldTrait", x => new { x.PreciousMaterialShieldsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_PreciousMaterialShieldTrait_PreciousMaterialShields_Preciou~",
                        column: x => x.PreciousMaterialShieldsId,
                        principalTable: "PreciousMaterialShields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialShieldTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialWeaponTrait",
                columns: table => new
                {
                    PreciousMaterialWeaponsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialWeaponTrait", x => new { x.PreciousMaterialWeaponsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_PreciousMaterialWeaponTrait_PreciousMaterialWeapons_Preciou~",
                        column: x => x.PreciousMaterialWeaponsId,
                        principalTable: "PreciousMaterialWeapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialWeaponTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Addendum = table.Column<string>(type: "text", nullable: true),
                    Range = table.Column<string>(type: "text", nullable: true),
                    Area = table.Column<string>(type: "text", nullable: true),
                    Cost = table.Column<string>(type: "text", nullable: true),
                    Targets = table.Column<string>(type: "text", nullable: true),
                    CastTime = table.Column<string>(type: "text", nullable: true),
                    Trigger = table.Column<string>(type: "text", nullable: true),
                    Duration = table.Column<string>(type: "text", nullable: true),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    IsSavingThrowBasic = table.Column<bool>(type: "boolean", nullable: true),
                    IsDismissable = table.Column<bool>(type: "boolean", nullable: false),
                    ActionTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpellTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    SavingThrowStatId = table.Column<Guid>(type: "uuid", nullable: true),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: true),
                    MagicSchoolId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClassId = table.Column<Guid>(type: "uuid", nullable: true),
                    InitialRevelationOfId = table.Column<Guid>(type: "uuid", nullable: true),
                    AdvancedRevelationOfId = table.Column<Guid>(type: "uuid", nullable: true),
                    GreaterRevelationOfId = table.Column<Guid>(type: "uuid", nullable: true),
                    GrantedById = table.Column<Guid>(type: "uuid", nullable: true),
                    DomainId = table.Column<Guid>(type: "uuid", nullable: true),
                    StaggeredEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Addendum", "Area", "CastTime", "Cost", "Duration", "Requirements", "Targets", "Trigger" }),
                    TraitId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spells_ActionTypes_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalTable: "ActionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_Domains_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_MagicSchools_MagicSchoolId",
                        column: x => x.MagicSchoolId,
                        principalTable: "MagicSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spells_SavingThrowStats_SavingThrowStatId",
                        column: x => x.SavingThrowStatId,
                        principalTable: "SavingThrowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spells_SpellTypes_SpellTypeId",
                        column: x => x.SpellTypeId,
                        principalTable: "SpellTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spells_StaggeredEffect_StaggeredEffectId",
                        column: x => x.StaggeredEffectId,
                        principalTable: "StaggeredEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaggeredEffectTraitBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Specifier = table.Column<string>(type: "text", nullable: true),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaggeredEffectTraitBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaggeredEffectTraitBinding_StaggeredEffect_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "StaggeredEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaggeredEffectTraitBinding_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Traits_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Traits_Details_Traits_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UtilityGear_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilityGear_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UtilityGear_Details_UtilityGear_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "UtilityGear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UtilityGearTraitBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Specifier = table.Column<string>(type: "text", nullable: true),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilityGearTraitBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UtilityGearTraitBinding_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UtilityGearTraitBinding_UtilityGear_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "UtilityGear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UtilityGearVariant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ItemLevel = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    BulkId = table.Column<Guid>(type: "uuid", nullable: false),
                    RarityId = table.Column<Guid>(type: "uuid", nullable: false),
                    UtilityGearId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilityGearVariant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UtilityGearVariant_Bulks_BulkId",
                        column: x => x.BulkId,
                        principalTable: "Bulks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UtilityGearVariant_Rarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UtilityGearVariant_UtilityGear_UtilityGearId",
                        column: x => x.UtilityGearId,
                        principalTable: "UtilityGear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CombinationWeaponComponent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Damage = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    DamageTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    WeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    Range = table.Column<int>(type: "integer", nullable: true),
                    Reload = table.Column<int>(type: "integer", nullable: true),
                    Capacity = table.Column<int>(type: "integer", nullable: true),
                    CombinationWeaponRangedComponent_DamageTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    CombinationWeaponRangedComponent_WeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombinationWeaponComponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CombinationWeaponComponent_DamageTypes_CombinationWeaponRan~",
                        column: x => x.CombinationWeaponRangedComponent_DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CombinationWeaponComponent_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CombinationWeaponComponent_WeaponGroups_CombinationWeaponRa~",
                        column: x => x.CombinationWeaponRangedComponent_WeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CombinationWeaponComponent_WeaponGroups_WeaponGroupId",
                        column: x => x.WeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseStageEffect",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Permanent = table.Column<bool>(type: "boolean", nullable: false),
                    DiseaseStageId = table.Column<Guid>(type: "uuid", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    ConditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    Severity = table.Column<int>(type: "integer", nullable: true),
                    Damage = table.Column<string>(type: "text", nullable: true),
                    Every = table.Column<string>(type: "text", nullable: true),
                    IsDamagePersistent = table.Column<bool>(type: "boolean", nullable: true),
                    DamageTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    Effect = table.Column<string>(type: "text", nullable: true),
                    DiseaseComesBackAfter = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseStageEffect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiseaseStageEffect_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseStageEffect_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseStageEffect_DiseaseStage_DiseaseStageId",
                        column: x => x.DiseaseStageId,
                        principalTable: "DiseaseStage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HazardComponent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HitPoints = table.Column<int>(type: "integer", nullable: false),
                    Hardness = table.Column<int>(type: "integer", nullable: true),
                    BrokenThreshold = table.Column<int>(type: "integer", nullable: true),
                    Addendum = table.Column<string>(type: "text", nullable: true),
                    HazardId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardComponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HazardComponent_Hazards_HazardId",
                        column: x => x.HazardId,
                        principalTable: "Hazards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HazardDetectionRequirement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DifficultyCheck = table.Column<int>(type: "integer", nullable: false),
                    Addendum = table.Column<string>(type: "text", nullable: true),
                    RequiredProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    HazardId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardDetectionRequirement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HazardDetectionRequirement_Hazards_HazardId",
                        column: x => x.HazardId,
                        principalTable: "Hazards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HazardDetectionRequirement_Proficiencies_RequiredProficienc~",
                        column: x => x.RequiredProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HazardDisableRequirement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DifficultyCheck = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: false),
                    RequiredProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    HazardId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardDisableRequirement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HazardDisableRequirement_Hazards_HazardId",
                        column: x => x.HazardId,
                        principalTable: "Hazards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HazardDisableRequirement_Proficiencies_RequiredProficiencyId",
                        column: x => x.RequiredProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HazardDisableRequirement_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HazardDispellRequirement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    CounteractDifficultyCheck = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    HazardId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardDispellRequirement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HazardDispellRequirement_Hazards_HazardId",
                        column: x => x.HazardId,
                        principalTable: "Hazards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HazardImmunity",
                columns: table => new
                {
                    HazardsId = table.Column<Guid>(type: "uuid", nullable: false),
                    ImmunitiesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardImmunity", x => new { x.HazardsId, x.ImmunitiesId });
                    table.ForeignKey(
                        name: "FK_HazardImmunity_HazardImmunities_ImmunitiesId",
                        column: x => x.ImmunitiesId,
                        principalTable: "HazardImmunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HazardImmunity_Hazards_HazardsId",
                        column: x => x.HazardsId,
                        principalTable: "Hazards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hazards_RoutineDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hazards_RoutineDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hazards_RoutineDetails_Hazards_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Hazards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HazardTrait",
                columns: table => new
                {
                    HazardsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardTrait", x => new { x.HazardsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_HazardTrait_Hazards_HazardsId",
                        column: x => x.HazardsId,
                        principalTable: "Hazards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HazardTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InlineAttack",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HitModifier = table.Column<int>(type: "integer", nullable: false),
                    Damage = table.Column<string>(type: "text", nullable: false),
                    AttackTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    DamageTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    ActionTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    StaggeredEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    HazardId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InlineAttack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InlineAttack_ActionTypes_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalTable: "ActionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InlineAttack_AttackTypes_AttackTypeId",
                        column: x => x.AttackTypeId,
                        principalTable: "AttackTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InlineAttack_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InlineAttack_Hazards_HazardId",
                        column: x => x.HazardId,
                        principalTable: "Hazards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InlineAttack_StaggeredEffect_StaggeredEffectId",
                        column: x => x.StaggeredEffectId,
                        principalTable: "StaggeredEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MysteryCursePotency_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MysteryCursePotency_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MysteryCursePotency_Details_MysteryCursePotency_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "MysteryCursePotency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HarrowCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    AlignmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    HarrowCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarrowCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HarrowCards_Alignments_AlignmentId",
                        column: x => x.AlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HarrowCards_HarrowCategories_HarrowCategoryId",
                        column: x => x.HarrowCategoryId,
                        principalTable: "HarrowCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    AccessRequirements = table.Column<string>(type: "text", nullable: true),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Benefit = table.Column<string>(type: "text", nullable: true),
                    Drawback = table.Column<string>(type: "text", nullable: true),
                    TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    AlchemicalElixir_Benefit = table.Column<string>(type: "text", nullable: true),
                    AlchemicalElixir_Drawback = table.Column<string>(type: "text", nullable: true),
                    AlchemicalElixir_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    AlchemicalPoison_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    AlchemicalTool_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    WeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    ArmorCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    ArmorGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    Armor_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    AlignmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    Artifact_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    BeastGun_WeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    BeastGun_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    CombinationWeapon_WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    CombinationWeapon_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    MeleeWeapon_WeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    MeleeWeapon_WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    MeleeWeapon_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    RangedWeapon_WeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    RangedWeapon_WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    RangedWeapon_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    ArmorPropertyRune_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    FundamentalArmorRune_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    FundamentalWeaponRune_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    WeaponPropertyRune_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    Stave_TraitId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Alignments_AlignmentId",
                        column: x => x.AlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_ArmorCategories_ArmorCategoryId",
                        column: x => x.ArmorCategoryId,
                        principalTable: "ArmorCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_ArmorGroups_ArmorGroupId",
                        column: x => x.ArmorGroupId,
                        principalTable: "ArmorGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_AlchemicalElixir_TraitId",
                        column: x => x.AlchemicalElixir_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_AlchemicalPoison_TraitId",
                        column: x => x.AlchemicalPoison_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_AlchemicalTool_TraitId",
                        column: x => x.AlchemicalTool_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_Armor_TraitId",
                        column: x => x.Armor_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_ArmorPropertyRune_TraitId",
                        column: x => x.ArmorPropertyRune_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_Artifact_TraitId",
                        column: x => x.Artifact_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_BeastGun_TraitId",
                        column: x => x.BeastGun_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_CombinationWeapon_TraitId",
                        column: x => x.CombinationWeapon_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_FundamentalArmorRune_TraitId",
                        column: x => x.FundamentalArmorRune_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_FundamentalWeaponRune_TraitId",
                        column: x => x.FundamentalWeaponRune_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_MeleeWeapon_TraitId",
                        column: x => x.MeleeWeapon_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_RangedWeapon_TraitId",
                        column: x => x.RangedWeapon_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_Stave_TraitId",
                        column: x => x.Stave_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Traits_WeaponPropertyRune_TraitId",
                        column: x => x.WeaponPropertyRune_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_WeaponCategories_CombinationWeapon_WeaponCategoryId",
                        column: x => x.CombinationWeapon_WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_WeaponCategories_MeleeWeapon_WeaponCategoryId",
                        column: x => x.MeleeWeapon_WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_WeaponCategories_RangedWeapon_WeaponCategoryId",
                        column: x => x.RangedWeapon_WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_WeaponCategories_WeaponCategoryId",
                        column: x => x.WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_WeaponGroups_BeastGun_WeaponGroupId",
                        column: x => x.BeastGun_WeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_WeaponGroups_MeleeWeapon_WeaponGroupId",
                        column: x => x.MeleeWeapon_WeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_WeaponGroups_RangedWeapon_WeaponGroupId",
                        column: x => x.RangedWeapon_WeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_WeaponGroups_WeaponGroupId",
                        column: x => x.WeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    AlignmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Planes_Alignments_AlignmentId",
                        column: x => x.AlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Planes_PlaneCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "PlaneCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialObjectInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Hardness = table.Column<int>(type: "integer", nullable: false),
                    HitPoints = table.Column<int>(type: "integer", nullable: false),
                    BrokenThreshold = table.Column<int>(type: "integer", nullable: false),
                    GradeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialObjectInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialObjectInformation_ObjectGrade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "ObjectGrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialObjectInformation_PreciousMaterialItemCateg~",
                        column: x => x.CategoryId,
                        principalTable: "PreciousMaterialItemCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialObjectInformation_PreciousMaterials_Materia~",
                        column: x => x.MaterialId,
                        principalTable: "PreciousMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterials_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterials_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciousMaterials_Details_PreciousMaterials_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "PreciousMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciousMaterialTrait",
                columns: table => new
                {
                    PreciousMaterialsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciousMaterialTrait", x => new { x.PreciousMaterialsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_PreciousMaterialTrait_PreciousMaterials_PreciousMaterialsId",
                        column: x => x.PreciousMaterialsId,
                        principalTable: "PreciousMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreciousMaterialTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MagicTraditionSpell",
                columns: table => new
                {
                    SpellsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraditionsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicTraditionSpell", x => new { x.SpellsId, x.TraditionsId });
                    table.ForeignKey(
                        name: "FK_MagicTraditionSpell_MagicTraditions_TraditionsId",
                        column: x => x.TraditionsId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MagicTraditionSpell_Spells_SpellsId",
                        column: x => x.SpellsId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RollableEffect",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CriticalSuccess = table.Column<string>(type: "text", nullable: true),
                    Success = table.Column<string>(type: "text", nullable: true),
                    Failure = table.Column<string>(type: "text", nullable: true),
                    CriticalFailure = table.Column<string>(type: "text", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "CriticalFailure", "CriticalSuccess", "Failure", "Success" }),
                    SpellId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RollableEffect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RollableEffect_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpellHeightening",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Level = table.Column<string>(type: "text", nullable: false),
                    SpellId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellHeightening", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellHeightening_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spells_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spells_Details_Spells_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpellSpellComponent",
                columns: table => new
                {
                    ComponentsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SpellsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSpellComponent", x => new { x.ComponentsId, x.SpellsId });
                    table.ForeignKey(
                        name: "FK_SpellSpellComponent_SpellComponents_ComponentsId",
                        column: x => x.ComponentsId,
                        principalTable: "SpellComponents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpellSpellComponent_Spells_SpellsId",
                        column: x => x.SpellsId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpellTraitBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Specifier = table.Column<string>(type: "text", nullable: true),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellTraitBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellTraitBinding_Spells_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpellTraitBinding_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UtilityGearVariant_Addendum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilityGearVariant_Addendum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UtilityGearVariant_Addendum_UtilityGearVariant_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "UtilityGearVariant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CombinationWeaponComponentTraitBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Specifier = table.Column<string>(type: "text", nullable: true),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombinationWeaponComponentTraitBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CombinationWeaponComponentTraitBinding_CombinationWeaponCom~",
                        column: x => x.OwnerId,
                        principalTable: "CombinationWeaponComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CombinationWeaponComponentTraitBinding_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InlineAttack_Effect",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InlineAttack_Effect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InlineAttack_Effect_InlineAttack_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "InlineAttack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InlineAttackTraitBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Specifier = table.Column<string>(type: "text", nullable: true),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InlineAttackTraitBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InlineAttackTraitBinding_InlineAttack_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "InlineAttack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InlineAttackTraitBinding_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaseItemTraitBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Specifier = table.Column<string>(type: "text", nullable: true),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseItemTraitBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseItemTraitBinding_Items_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemTraitBinding_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Details_Items_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Planes_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Planes_Details_Planes_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaneTrait",
                columns: table => new
                {
                    PlanesId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaneTrait", x => new { x.PlanesId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_PlaneTrait_Planes_PlanesId",
                        column: x => x.PlanesId,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaneTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    Trigger = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ActionTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    RollableEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abilities_ActionTypes_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalTable: "ActionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Abilities_RollableEffect_RollableEffectId",
                        column: x => x.RollableEffectId,
                        principalTable: "RollableEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Abilities_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Trigger = table.Column<string>(type: "text", nullable: true),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    ActionTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    RollableEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Requirements", "Trigger" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actions_ActionTypes_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalTable: "ActionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actions_RollableEffect_RollableEffectId",
                        column: x => x.RollableEffectId,
                        principalTable: "RollableEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaseItemVariant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CraftingRequirements = table.Column<string>(type: "text", nullable: true),
                    BulkId = table.Column<Guid>(type: "uuid", nullable: false),
                    RarityId = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    RollableEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: true),
                    Hands = table.Column<string>(type: "text", nullable: true),
                    Level = table.Column<int>(type: "integer", nullable: true),
                    Usage = table.Column<string>(type: "text", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Usage" }),
                    AlchemicalBombVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    AlchemicalBombVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    PotencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    AlchemicalBombVariant_Usage = table.Column<string>(type: "text", nullable: true),
                    AlchemicalBombVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "AlchemicalBombVariant_Usage" }),
                    AlchemicalElixirVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    AlchemicalElixirVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    AlchemicalElixirVariant_Usage = table.Column<string>(type: "text", nullable: true),
                    AlchemicalElixirVariant_PotencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    AlchemicalElixirVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "AlchemicalElixirVariant_Usage" }),
                    AlchemicalPoisonVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    AlchemicalPoisonVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    AlchemicalPoisonVariant_Usage = table.Column<string>(type: "text", nullable: true),
                    PoisonEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    AlchemicalPoisonVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "AlchemicalPoisonVariant_Usage" }),
                    AlchemicalToolVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    AlchemicalToolVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    AlchemicalToolVariant_Usage = table.Column<string>(type: "text", nullable: true),
                    AlchemicalToolVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "AlchemicalToolVariant_Usage" }),
                    AlchemicalToolVariant_PotencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    AmmunitionVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    BatchAmount = table.Column<int>(type: "integer", nullable: true),
                    AmmunitionVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" }),
                    ArmorVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    ArmorVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    ArmorClassBonus = table.Column<int>(type: "integer", nullable: true),
                    DexterityCap = table.Column<int>(type: "integer", nullable: true),
                    CheckPenalty = table.Column<int>(type: "integer", nullable: true),
                    SpeedPenalty = table.Column<int>(type: "integer", nullable: true),
                    RequiredStrength = table.Column<int>(type: "integer", nullable: true),
                    ArmorVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" }),
                    ArtifactVariant_Usage = table.Column<string>(type: "text", nullable: true),
                    ArtifactVariant_Hands = table.Column<int>(type: "integer", nullable: true),
                    Destruction = table.Column<string>(type: "text", nullable: true),
                    ArtifactVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    AlignmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    ArtifactVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Destruction", "ArtifactVariant_Usage" }),
                    BeastGunVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    BeastGunVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    BeastGunVariant_Hands = table.Column<string>(type: "text", nullable: true),
                    Range = table.Column<int>(type: "integer", nullable: true),
                    Reload = table.Column<int>(type: "integer", nullable: true),
                    Damage = table.Column<string>(type: "text", nullable: true),
                    Capacity = table.Column<int>(type: "integer", nullable: true),
                    DamageTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    BeastGunVariant_PotencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    BeastGunVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" }),
                    CombinationWeaponVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    CombinationWeaponVariant_Hands = table.Column<string>(type: "text", nullable: true),
                    RangedComponentId = table.Column<Guid>(type: "uuid", nullable: true),
                    MeleeComponentId = table.Column<Guid>(type: "uuid", nullable: true),
                    CombinationWeaponVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" }),
                    HeldItemVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    HeldItemVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    HeldItemVariant_Usage = table.Column<string>(type: "text", nullable: true),
                    HeldItemVariant_Hands = table.Column<string>(type: "text", nullable: true),
                    HeldItemVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "HeldItemVariant_Usage" }),
                    MeleeWeaponVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    MeleeWeaponVariant_Damage = table.Column<string>(type: "text", nullable: true),
                    MeleeWeaponVariant_Hands = table.Column<string>(type: "text", nullable: true),
                    MeleeWeaponVariant_DamageTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    MeleeWeaponVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" }),
                    PreciousMaterialItemVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    PreciousMaterialItemVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    PreciousMaterialItemVariant_Usage = table.Column<string>(type: "text", nullable: true),
                    PreciousMaterialItemVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "PreciousMaterialItemVariant_Usage" }),
                    RangedWeaponVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    RangedWeaponVariant_Hands = table.Column<string>(type: "text", nullable: true),
                    RangedWeaponVariant_Range = table.Column<int>(type: "integer", nullable: true),
                    RangedWeaponVariant_Reload = table.Column<int>(type: "integer", nullable: true),
                    RangedWeaponVariant_Damage = table.Column<string>(type: "text", nullable: true),
                    RangedWeaponVariant_Capacity = table.Column<int>(type: "integer", nullable: true),
                    RangedWeaponVariant_DamageTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    RangedWeaponVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" }),
                    RuneVariant_Usage = table.Column<string>(type: "text", nullable: true),
                    RuneVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    RuneVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    RuneVariant_PotencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    ArmorPropertyRuneVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "RuneVariant_Usage" }),
                    FundamentalArmorRuneVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "RuneVariant_Usage" }),
                    FundamentalWeaponRuneVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "RuneVariant_Usage" }),
                    WeaponPropertyRuneVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "RuneVariant_Usage" }),
                    ShieldVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    ShieldVariant_ArmorClassBonus = table.Column<int>(type: "integer", nullable: true),
                    ShieldVariant_SpeedPenalty = table.Column<int>(type: "integer", nullable: true),
                    Hardness = table.Column<int>(type: "integer", nullable: true),
                    HitPoints = table.Column<int>(type: "integer", nullable: true),
                    BrokenThreshold = table.Column<int>(type: "integer", nullable: true),
                    ShieldVariant_Hands = table.Column<string>(type: "text", nullable: true),
                    ShieldVariant_Usage = table.Column<string>(type: "text", nullable: true),
                    ShieldVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    ShieldVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "ShieldVariant_Usage" }),
                    StaveVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    StaveVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    StaveVariant_Hands = table.Column<string>(type: "text", nullable: true),
                    StaveVariant_Usage = table.Column<string>(type: "text", nullable: true),
                    StaveVariant_PotencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    StaveVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "StaveVariant_Usage" }),
                    WornItemVariant_Price = table.Column<int>(type: "integer", nullable: true),
                    WornItemVariant_Level = table.Column<int>(type: "integer", nullable: true),
                    WornItemVariant_Usage = table.Column<string>(type: "text", nullable: true),
                    WornItemVariant_SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: true)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "WornItemVariant_Usage" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseItemVariant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_Alignments_AlignmentId",
                        column: x => x.AlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_Bulks_BulkId",
                        column: x => x.BulkId,
                        principalTable: "Bulks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_CombinationWeaponComponent_MeleeComponentId",
                        column: x => x.MeleeComponentId,
                        principalTable: "CombinationWeaponComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_CombinationWeaponComponent_RangedComponentId",
                        column: x => x.RangedComponentId,
                        principalTable: "CombinationWeaponComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_DamageTypes_MeleeWeaponVariant_DamageTypeId",
                        column: x => x.MeleeWeaponVariant_DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_DamageTypes_RangedWeaponVariant_DamageTypeId",
                        column: x => x.RangedWeaponVariant_DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_Potencies_AlchemicalElixirVariant_PotencyId",
                        column: x => x.AlchemicalElixirVariant_PotencyId,
                        principalTable: "Potencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_Potencies_AlchemicalToolVariant_PotencyId",
                        column: x => x.AlchemicalToolVariant_PotencyId,
                        principalTable: "Potencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_Potencies_BeastGunVariant_PotencyId",
                        column: x => x.BeastGunVariant_PotencyId,
                        principalTable: "Potencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_Potencies_PotencyId",
                        column: x => x.PotencyId,
                        principalTable: "Potencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_Potencies_RuneVariant_PotencyId",
                        column: x => x.RuneVariant_PotencyId,
                        principalTable: "Potencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_Potencies_StaveVariant_PotencyId",
                        column: x => x.StaveVariant_PotencyId,
                        principalTable: "Potencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_Rarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_RollableEffect_RollableEffectId",
                        column: x => x.RollableEffectId,
                        principalTable: "RollableEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_StaggeredEffect_PoisonEffectId",
                        column: x => x.PoisonEffectId,
                        principalTable: "StaggeredEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillActions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    ActionTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    RequiredProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    RequireProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    RollableEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    TableId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillActions_ActionTypes_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalTable: "ActionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillActions_Proficiencies_RequireProficiencyId",
                        column: x => x.RequireProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkillActions_RollableEffect_RollableEffectId",
                        column: x => x.RollableEffectId,
                        principalTable: "RollableEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkillActions_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillActions_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpellHeightening_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellHeightening_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellHeightening_Details_SpellHeightening_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "SpellHeightening",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Abilities_Effects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities_Effects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abilities_Effects_Abilities_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbilityTrait",
                columns: table => new
                {
                    AbilitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityTrait", x => new { x.AbilitiesId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_AbilityTrait_Abilities_AbilitiesId",
                        column: x => x.AbilitiesId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbilityTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actions_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actions_Details_Actions_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionTrait",
                columns: table => new
                {
                    ActionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionTrait", x => new { x.ActionsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_ActionTrait_Actions_ActionsId",
                        column: x => x.ActionsId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaseItemVariant_Addendum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseItemVariant_Addendum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseItemVariant_Addendum_BaseItemVariant_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "BaseItemVariant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InlineAction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    Frequency = table.Column<string>(type: "text", nullable: true),
                    Trigger = table.Column<string>(type: "text", nullable: true),
                    Kind = table.Column<string>(type: "text", nullable: true),
                    Cost = table.Column<string>(type: "text", nullable: true),
                    ActionTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    RollableEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    StaggeredEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    BaseItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    BaseItemVariantId = table.Column<Guid>(type: "uuid", nullable: true),
                    HazardId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpellId = table.Column<Guid>(type: "uuid", nullable: true),
                    UtilityGearId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InlineAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InlineAction_ActionTypes_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalTable: "ActionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InlineAction_BaseItemVariant_BaseItemVariantId",
                        column: x => x.BaseItemVariantId,
                        principalTable: "BaseItemVariant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InlineAction_Hazards_HazardId",
                        column: x => x.HazardId,
                        principalTable: "Hazards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InlineAction_Items_BaseItemId",
                        column: x => x.BaseItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InlineAction_RollableEffect_RollableEffectId",
                        column: x => x.RollableEffectId,
                        principalTable: "RollableEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InlineAction_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InlineAction_StaggeredEffect_StaggeredEffectId",
                        column: x => x.StaggeredEffectId,
                        principalTable: "StaggeredEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InlineAction_UtilityGear_UtilityGearId",
                        column: x => x.UtilityGearId,
                        principalTable: "UtilityGear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaveSpell",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    SpellId = table.Column<Guid>(type: "uuid", nullable: false),
                    StaveVariantId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaveSpell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaveSpell_BaseItemVariant_StaveVariantId",
                        column: x => x.StaveVariantId,
                        principalTable: "BaseItemVariant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StaveSpell_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayModeSkillAction",
                columns: table => new
                {
                    RequiredPlayModesId = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillActionsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayModeSkillAction", x => new { x.RequiredPlayModesId, x.SkillActionsId });
                    table.ForeignKey(
                        name: "FK_PlayModeSkillAction_PlayModes_RequiredPlayModesId",
                        column: x => x.RequiredPlayModesId,
                        principalTable: "PlayModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayModeSkillAction_SkillActions_SkillActionsId",
                        column: x => x.SkillActionsId,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillActionExample",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ProficiencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillActionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillActionExample", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillActionExample_Proficiencies_ProficiencyId",
                        column: x => x.ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillActionExample_SkillActions_SkillActionId",
                        column: x => x.SkillActionId,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillActions_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillActions_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillActions_Details_SkillActions_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillActionTrait",
                columns: table => new
                {
                    SkillActionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillActionTrait", x => new { x.SkillActionsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_SkillActionTrait_SkillActions_SkillActionsId",
                        column: x => x.SkillActionsId,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillActionTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillSkillAction",
                columns: table => new
                {
                    SkillActionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSkillAction", x => new { x.SkillActionsId, x.SkillsId });
                    table.ForeignKey(
                        name: "FK_SkillSkillAction_SkillActions_SkillActionsId",
                        column: x => x.SkillActionsId,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillSkillAction_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InlineAction_Effect",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InlineAction_Effect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InlineAction_Effect_InlineAction_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "InlineAction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InlineActionTraitBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Specifier = table.Column<string>(type: "text", nullable: true),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InlineActionTraitBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InlineActionTraitBinding_InlineAction_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "InlineAction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InlineActionTraitBinding_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaseEffect",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    PrerequisiteId = table.Column<Guid>(type: "uuid", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    DisableFeatPrerequisitesEffect_FeatId = table.Column<Guid>(type: "uuid", nullable: true),
                    RangeTier = table.Column<int>(type: "integer", nullable: true),
                    EnableSkillActionEffect_SkillId = table.Column<Guid>(type: "uuid", nullable: true),
                    EnableSkillActionEffect_SkillActionId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsChosenByGameMaster = table.Column<bool>(type: "boolean", nullable: true),
                    GainAnyAbilityBoostEffect_Restrictions = table.Column<string>(type: "text", nullable: true),
                    GainAnyAlchemicalBombFormulaEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    GainAnyAlchemicalPoisonFormulaEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    GainAnyClassFeatEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    GainAnyClassFeatEffect_ClassId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainAnyDailyClassFeatEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    ClassId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpellLevel = table.Column<int>(type: "integer", nullable: true),
                    GainAnyFamiliarSpellEffect_Amount = table.Column<int>(type: "integer", nullable: true),
                    GainAnyFormulaEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    InnovationModificationTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainAnyLoreProficiencyEffect_Restrictions = table.Column<string>(type: "text", nullable: true),
                    GainAnyLoreProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainAnyMutagenFormulaEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    GainAnySavingThrowProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainAnySenseEffect_Range = table.Column<string>(type: "text", nullable: true),
                    GainAnySenseEffect_SenseAccuracyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainAnySkillProficiencyEffect_Restrictions = table.Column<string>(type: "text", nullable: true),
                    GainAnySkillProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainAnySkillSkillFeatEffect_SkillId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainAnySpellEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    RequiredStatId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainAnyTraitSpellEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    RequiredTraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainAnyWeaponGroupProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainAnyWeaponGroupProficiencyEffect_WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainChosenMysteryDomainSpellEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    GainChosenSkillProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainChosenWeaponGroupProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainChosenWeaponGroupProficiencyEffect_WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainDeityFavoredWeaponProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainDivineFontSpellSlotEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    FormulaAmount = table.Column<int>(type: "integer", nullable: true),
                    AddFormulasPerLevel = table.Column<int>(type: "integer", nullable: true),
                    GainSingularExpertiseEffect_WeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    HighestProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificAbilityBoostEffect_StatId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificAbilityEffect_Range = table.Column<string>(type: "text", nullable: true),
                    AbilityId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificAbilityFlawEffect_StatId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificActionCircumstanceBonusEffect_Addendum = table.Column<string>(type: "text", nullable: true),
                    GainSpecificActionCircumstanceBonusEffect_Bonus = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificActionCircumstanceBonusEffect_ActionId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificAlchemicalBombProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificArmorCategoryProficiencyEffect_ArmorCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificArmorCategoryProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    ArmorCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    ArmorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CauseId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificClassDcProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificConditionAnySavingThrowCircumstanceBonusEffect_Add = table.Column<string>(name: "GainSpecificConditionAnySavingThrowCircumstanceBonusEffect_Add~", type: "text", nullable: true),
                    GainSpecificConditionAnySavingThrowCircumstanceBonusEffect_Bon = table.Column<int>(name: "GainSpecificConditionAnySavingThrowCircumstanceBonusEffect_Bon~", type: "integer", nullable: true),
                    GainSpecificConditionAnySavingThrowCircumstanceBonusEffect_Con = table.Column<Guid>(name: "GainSpecificConditionAnySavingThrowCircumstanceBonusEffect_Con~", type: "uuid", nullable: true),
                    GainSpecificDamageResistanceEffect_DamageTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifierInput = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificDamageResistanceEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificDamageResistanceEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificDamageResistanceEffect_Minimum = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificDamageResistanceEffect_Addendum = table.Column<string>(type: "text", nullable: true),
                    GainSpecificDamageWeaknessEffect_DamageTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificDamageWeaknessEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificDamageWeaknessEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    Minimum = table.Column<int>(type: "integer", nullable: true),
                    AlchemicalElixirId = table.Column<Guid>(type: "uuid", nullable: true),
                    PotencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificFeatEffect_Restrictions = table.Column<string>(type: "text", nullable: true),
                    GainSpecificFeatEffect_FeatId = table.Column<Guid>(type: "uuid", nullable: true),
                    HeritageId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificHitpointsEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificHitpointsEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificInnateSpellEffect_SpellId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificInnateSpellEffect_MagicTraditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    InstinctAbilityId = table.Column<Guid>(type: "uuid", nullable: true),
                    InstinctId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificKeyAbilityOptionEffect_StatId = table.Column<Guid>(type: "uuid", nullable: true),
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificLevelSpellEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificLoreCategoryProficiencyEffect_Restrictions = table.Column<string>(type: "text", nullable: true),
                    GainSpecificLoreCategoryProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    LoreCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificLoreProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    LoreId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificMagicSchoolAnySavingThrowCircumstanceBonusEffect_A = table.Column<string>(name: "GainSpecificMagicSchoolAnySavingThrowCircumstanceBonusEffect_A~", type: "text", nullable: true),
                    GainSpecificMagicSchoolAnySavingThrowCircumstanceBonusEffect_B = table.Column<int>(name: "GainSpecificMagicSchoolAnySavingThrowCircumstanceBonusEffect_B~", type: "integer", nullable: true),
                    GainSpecificMagicSchoolAnySavingThrowCircumstanceBonusEffect_M = table.Column<Guid>(name: "GainSpecificMagicSchoolAnySavingThrowCircumstanceBonusEffect_M~", type: "uuid", nullable: true),
                    GainSpecificMagicSchoolEffect_MagicSchoolId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificMagicSchoolSpellEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    MagicSchoolId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificMagicTraditionAnyInnateSpellEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificMagicTraditionAnyInnateSpellEffect_MagicTraditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificMagicTraditionAnySpellEffect_Level = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificMagicTraditionAnySpellEffect_MagicTraditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificMeleeWeaponEffect_MeleeWeaponId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificMeleeWeaponProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    MeleeWeaponId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificRangedWeaponProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    RangedWeaponId = table.Column<Guid>(type: "uuid", nullable: true),
                    Comparator = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificRarityAnyLanguageEffect_RarityId = table.Column<Guid>(type: "uuid", nullable: true),
                    RarityId = table.Column<Guid>(type: "uuid", nullable: true),
                    RuneMagicId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSavingThrowProficiencyEffect_SavingThrowStatId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSavingThrowProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    Range = table.Column<string>(type: "text", nullable: true),
                    SenseId = table.Column<Guid>(type: "uuid", nullable: true),
                    SenseAccuracyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSkillActionCircumstanceBonusEffect_Addendum = table.Column<string>(type: "text", nullable: true),
                    GainSpecificSkillActionCircumstanceBonusEffect_Bonus = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificSkillActionCircumstanceBonusEffect_SkillActionId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEff = table.Column<string>(name: "GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEff~", type: "text", nullable: true),
                    GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEf1 = table.Column<int>(name: "GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEf~1", type: "integer", nullable: true),
                    GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEf2 = table.Column<Guid>(name: "GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEf~2", type: "uuid", nullable: true),
                    GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEf3 = table.Column<Guid>(name: "GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEf~3", type: "uuid", nullable: true),
                    GainSpecificSkillCircumstanceBonusEffect_Addendum = table.Column<string>(type: "text", nullable: true),
                    GainSpecificSkillCircumstanceBonusEffect_Bonus = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificSkillCircumstanceBonusEffect_SkillId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSkillDcCircumstanceBonusEffect_Bonus = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificSkillDcCircumstanceBonusEffect_SkillId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSkillInitiativeCircumstanceBonusEffect_Bonus = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificSkillInitiativeCircumstanceBonusEffect_SkillId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSkillProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSkillProficiencyEffect_SkillId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSkillSpecificActionCircumstanceBonusEffect_Addendum = table.Column<string>(type: "text", nullable: true),
                    GainSpecificSkillSpecificActionCircumstanceBonusEffect_Bonus = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificSkillSpecificActionCircumstanceBonusEffect_SkillId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSkillSpecificActionCircumstanceBonusEffect_ActionId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSkillSpecificActionDcCircumstanceBonusEffect_Adden = table.Column<string>(name: "GainSpecificSkillSpecificActionDcCircumstanceBonusEffect_Adden~", type: "text", nullable: true),
                    GainSpecificSkillSpecificActionDcCircumstanceBonusEffect_Bonus = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificSkillSpecificActionDcCircumstanceBonusEffect_Skill = table.Column<Guid>(name: "GainSpecificSkillSpecificActionDcCircumstanceBonusEffect_Skill~", type: "uuid", nullable: true),
                    GainSpecificSkillSpecificActionDcCircumstanceBonusEffect_Actio = table.Column<Guid>(name: "GainSpecificSkillSpecificActionDcCircumstanceBonusEffect_Actio~", type: "uuid", nullable: true),
                    GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_Ad = table.Column<string>(name: "GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_Ad~", type: "text", nullable: true),
                    GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_Bo = table.Column<int>(name: "GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_Bo~", type: "integer", nullable: true),
                    GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_S1 = table.Column<Guid>(name: "GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_S~1", type: "uuid", nullable: true),
                    GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_Sk = table.Column<Guid>(name: "GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_Sk~", type: "uuid", nullable: true),
                    GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect_ = table.Column<string>(name: "GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect_~", type: "text", nullable: true),
                    GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect1 = table.Column<int>(name: "GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect~1", type: "integer", nullable: true),
                    GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect3 = table.Column<Guid>(name: "GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect~3", type: "uuid", nullable: true),
                    GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect2 = table.Column<Guid>(name: "GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect~2", type: "uuid", nullable: true),
                    GainSpecificSpeedEffect_Addendum = table.Column<string>(type: "text", nullable: true),
                    Speed = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificSpeedEffect_MovementMethod = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificSpellAttackProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    MagicTraditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificSpellDcProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    Restrictions = table.Column<string>(type: "text", nullable: true),
                    SpellId = table.Column<Guid>(type: "uuid", nullable: true),
                    Amount = table.Column<int>(type: "integer", nullable: true),
                    Level = table.Column<int>(type: "integer", nullable: true),
                    IsSpendingPreventable = table.Column<bool>(type: "boolean", nullable: true),
                    GainSpecificSpellcastingAbilityEffect_StatId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificStatSkillFeatEffect_StatId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificStatSkillProficiencyEffect_StatId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificStatSkillProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificTraitAnySavingThrowCircumstanceBonusEffect_Addendum = table.Column<string>(type: "text", nullable: true),
                    GainSpecificTraitAnySavingThrowCircumstanceBonusEffect_Bonus = table.Column<int>(type: "integer", nullable: true),
                    GainSpecificTraitAnySavingThrowCircumstanceBonusEffect_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificTraitEffect_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificTraitFeatEffect_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificTraitSpellEffect_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    UnarmedWeaponId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificUnarmedAttackEffect_WeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    DamageTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    Damage = table.Column<string>(type: "text", nullable: true),
                    GainSpecificWeaponCategoryProficiencyEffect_ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificWeaponCategoryProficiencyEffect_WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificWeaponCategorySpecializationEffect_WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificWeaponGroupCircumstanceBonusEffect_WeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    Bonus = table.Column<int>(type: "integer", nullable: true),
                    RollType = table.Column<int>(type: "integer", nullable: true),
                    ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificWeaponGroupProficiencyEffect_WeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    GainSpecificWeaponGroupProficiencyEffect_WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    WeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    CantripAmount = table.Column<int>(type: "integer", nullable: true),
                    SpellAmount = table.Column<int>(type: "integer", nullable: true),
                    AddSpellsPerLevel = table.Column<int>(type: "integer", nullable: true),
                    StatId = table.Column<Guid>(type: "uuid", nullable: true),
                    ImproveAnySavingThrowEffect_InitialResult = table.Column<int>(type: "integer", nullable: true),
                    ImproveAnySavingThrowEffect_Becomes = table.Column<int>(type: "integer", nullable: true),
                    ActionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ImproveSpecificActionCheckEffect_InitialResult = table.Column<int>(type: "integer", nullable: true),
                    ImproveSpecificActionCheckEffect_Becomes = table.Column<int>(type: "integer", nullable: true),
                    ImproveSpecificConditionAnySavingThrowEffect_Addendum = table.Column<string>(type: "text", nullable: true),
                    ImproveSpecificConditionAnySavingThrowEffect_ConditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ImproveSpecificConditionAnySavingThrowEffect_InitialResult = table.Column<int>(type: "integer", nullable: true),
                    ImproveSpecificConditionAnySavingThrowEffect_Becomes = table.Column<int>(type: "integer", nullable: true),
                    SavingThrowStatId = table.Column<Guid>(type: "uuid", nullable: true),
                    ImproveSpecificSavingThrowEffect_InitialResult = table.Column<int>(type: "integer", nullable: true),
                    ImproveSpecificSavingThrowEffect_Becomes = table.Column<int>(type: "integer", nullable: true),
                    ImproveSpecificSkillActionCheckEffect_SkillActionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ImproveSpecificSkillActionCheckEffect_InitialResult = table.Column<int>(type: "integer", nullable: true),
                    ImproveSpecificSkillActionCheckEffect_Becomes = table.Column<int>(type: "integer", nullable: true),
                    ImproveSpecificSkillSpecificSkillActionCheckEffect_Addendum = table.Column<string>(type: "text", nullable: true),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: true),
                    SkillActionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ImproveSpecificSkillSpecificSkillActionCheckEffect_InitialResu = table.Column<int>(name: "ImproveSpecificSkillSpecificSkillActionCheckEffect_InitialResu~", type: "integer", nullable: true),
                    ImproveSpecificSkillSpecificSkillActionCheckEffect_Becomes = table.Column<int>(type: "integer", nullable: true),
                    Addendum = table.Column<string>(type: "text", nullable: true),
                    ImproveSpecificTraitAnySavingThrowEffect_TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    InitialResult = table.Column<int>(type: "integer", nullable: true),
                    Becomes = table.Column<int>(type: "integer", nullable: true),
                    TraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    Text = table.Column<string>(type: "text", nullable: true),
                    ModifyAncestryHitpointsEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    ModifyAncestryHitpointsEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    SizeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifyFallDistanceEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    ModifyFallDistanceEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    ModifyFeatEffectsEffect_FeatId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModificationEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    FeatId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifyFeatLevelPrerequisiteEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    ModifyFeatLevelPrerequisiteEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    ModifyMultipleAttackPenaltyEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    ModifyMultipleAttackPenaltyEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    MultipleAttackPenalty = table.Column<int>(type: "integer", nullable: true),
                    IsWithAgileWeapon = table.Column<bool>(type: "boolean", nullable: true),
                    ConditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifySpecificConditionEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    ModifySpecificConditionEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    ModifySpecificSpeedEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    ModifySpecificSpeedEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    MovementMethod = table.Column<int>(type: "integer", nullable: true),
                    ModifySpecificWeaponCategoryDamageDieAmountEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    ModifySpecificWeaponCategoryDamageDieAmountEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    ModifySpecificWeaponCategoryDamageDieAmountEffect_WeaponCatego = table.Column<Guid>(name: "ModifySpecificWeaponCategoryDamageDieAmountEffect_WeaponCatego~", type: "uuid", nullable: true),
                    ModifySpecificWeaponCategoryDamageDieSizeEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    ModifySpecificWeaponCategoryDamageDieSizeEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifyTemperatureEffect_Modifier = table.Column<int>(type: "integer", nullable: true),
                    ModifyTemperatureEffect_ModifierType = table.Column<int>(type: "integer", nullable: true),
                    Temperature = table.Column<int>(type: "integer", nullable: true),
                    Modifier = table.Column<int>(type: "integer", nullable: true),
                    ModifierType = table.Column<int>(type: "integer", nullable: true),
                    ProhibitedFeatId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProhibitedMagicSchoolId = table.Column<Guid>(type: "uuid", nullable: true),
                    AncestryTraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    BooleanEffect_Addendum = table.Column<string>(type: "text", nullable: true),
                    Operator = table.Column<int>(type: "integer", nullable: true),
                    ChoiceId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEffect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Actions_GainSpecificActionCircumstanceBonusEffec~",
                        column: x => x.GainSpecificActionCircumstanceBonusEffect_ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Actions_GainSpecificSkillSpecificActionCircumsta~",
                        column: x => x.GainSpecificSkillSpecificActionCircumstanceBonusEffect_ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Actions_GainSpecificSkillSpecificActionDcCircums~",
                        column: x => x.GainSpecificSkillSpecificActionDcCircumstanceBonusEffect_Actio,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_AncestrySizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "AncestrySizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_ArmorCategories_ArmorCategoryId",
                        column: x => x.ArmorCategoryId,
                        principalTable: "ArmorCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_ArmorCategories_GainSpecificArmorCategoryProfici~",
                        column: x => x.GainSpecificArmorCategoryProficiencyEffect_ArmorCategoryId,
                        principalTable: "ArmorCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_BaseEffect_ModificationEffectId",
                        column: x => x.ModificationEffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Choice_ChoiceId",
                        column: x => x.ChoiceId,
                        principalTable: "Choice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Classes_GainAnyClassFeatEffect_ClassId",
                        column: x => x.GainAnyClassFeatEffect_ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Conditions_GainSpecificConditionAnySavingThrowCi~",
                        column: x => x.GainSpecificConditionAnySavingThrowCircumstanceBonusEffect_Con,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Conditions_ImproveSpecificConditionAnySavingThro~",
                        column: x => x.ImproveSpecificConditionAnySavingThrowEffect_ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_DamageTypes_GainSpecificDamageResistanceEffect_D~",
                        column: x => x.GainSpecificDamageResistanceEffect_DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_DamageTypes_GainSpecificDamageWeaknessEffect_Dam~",
                        column: x => x.GainSpecificDamageWeaknessEffect_DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_InnovationModificationTypes_InnovationModificati~",
                        column: x => x.InnovationModificationTypeId,
                        principalTable: "InnovationModificationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_InstinctAbilities_InstinctAbilityId",
                        column: x => x.InstinctAbilityId,
                        principalTable: "InstinctAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Items_AlchemicalElixirId",
                        column: x => x.AlchemicalElixirId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Items_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Items_GainSpecificMeleeWeaponEffect_MeleeWeaponId",
                        column: x => x.GainSpecificMeleeWeaponEffect_MeleeWeaponId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Items_MeleeWeaponId",
                        column: x => x.MeleeWeaponId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Items_RangedWeaponId",
                        column: x => x.RangedWeaponId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_LoreCategories_LoreCategoryId",
                        column: x => x.LoreCategoryId,
                        principalTable: "LoreCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Lores_LoreId",
                        column: x => x.LoreId,
                        principalTable: "Lores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_MagicSchools_GainSpecificMagicSchoolAnySavingThr~",
                        column: x => x.GainSpecificMagicSchoolAnySavingThrowCircumstanceBonusEffect_M,
                        principalTable: "MagicSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_MagicSchools_GainSpecificMagicSchoolEffect_Magic~",
                        column: x => x.GainSpecificMagicSchoolEffect_MagicSchoolId,
                        principalTable: "MagicSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_MagicSchools_MagicSchoolId",
                        column: x => x.MagicSchoolId,
                        principalTable: "MagicSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_MagicSchools_ProhibitedMagicSchoolId",
                        column: x => x.ProhibitedMagicSchoolId,
                        principalTable: "MagicSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_MagicTraditions_GainSpecificInnateSpellEffect_Ma~",
                        column: x => x.GainSpecificInnateSpellEffect_MagicTraditionId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_MagicTraditions_GainSpecificMagicTraditionAnyInn~",
                        column: x => x.GainSpecificMagicTraditionAnyInnateSpellEffect_MagicTraditionId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_MagicTraditions_GainSpecificMagicTraditionAnySpe~",
                        column: x => x.GainSpecificMagicTraditionAnySpellEffect_MagicTraditionId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_MagicTraditions_MagicTraditionId",
                        column: x => x.MagicTraditionId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Potencies_PotencyId",
                        column: x => x.PotencyId,
                        principalTable: "Potencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainAnyLoreProficiencyEffect_Profi~",
                        column: x => x.GainAnyLoreProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainAnySavingThrowProficiencyEffec~",
                        column: x => x.GainAnySavingThrowProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainAnySkillProficiencyEffect_Prof~",
                        column: x => x.GainAnySkillProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainAnyWeaponGroupProficiencyEffec~",
                        column: x => x.GainAnyWeaponGroupProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainChosenSkillProficiencyEffect_P~",
                        column: x => x.GainChosenSkillProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainChosenWeaponGroupProficiencyEf~",
                        column: x => x.GainChosenWeaponGroupProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainDeityFavoredWeaponProficiencyE~",
                        column: x => x.GainDeityFavoredWeaponProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificAlchemicalBombProficie~",
                        column: x => x.GainSpecificAlchemicalBombProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificArmorCategoryProficien~",
                        column: x => x.GainSpecificArmorCategoryProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificClassDcProficiencyEffe~",
                        column: x => x.GainSpecificClassDcProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificLoreCategoryProficienc~",
                        column: x => x.GainSpecificLoreCategoryProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificLoreProficiencyEffect_~",
                        column: x => x.GainSpecificLoreProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificMeleeWeaponProficiency~",
                        column: x => x.GainSpecificMeleeWeaponProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificRangedWeaponProficienc~",
                        column: x => x.GainSpecificRangedWeaponProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificSavingThrowProficiency~",
                        column: x => x.GainSpecificSavingThrowProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificSkillProficiencyEffect~",
                        column: x => x.GainSpecificSkillProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificSpellAttackProficiency~",
                        column: x => x.GainSpecificSpellAttackProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificSpellDcProficiencyEffe~",
                        column: x => x.GainSpecificSpellDcProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificStatSkillProficiencyEf~",
                        column: x => x.GainSpecificStatSkillProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_GainSpecificWeaponCategoryProficie~",
                        column: x => x.GainSpecificWeaponCategoryProficiencyEffect_ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_HighestProficiencyId",
                        column: x => x.HighestProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Proficiencies_ProficiencyId",
                        column: x => x.ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Rarities_GainSpecificRarityAnyLanguageEffect_Rar~",
                        column: x => x.GainSpecificRarityAnyLanguageEffect_RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Rarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SavingThrowStats_GainSpecificSavingThrowProficie~",
                        column: x => x.GainSpecificSavingThrowProficiencyEffect_SavingThrowStatId,
                        principalTable: "SavingThrowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SavingThrowStats_GainSpecificSkillActionSpecific~",
                        column: x => x.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEf2,
                        principalTable: "SavingThrowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SavingThrowStats_SavingThrowStatId",
                        column: x => x.SavingThrowStatId,
                        principalTable: "SavingThrowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SenseAccuracy_GainAnySenseEffect_SenseAccuracyId",
                        column: x => x.GainAnySenseEffect_SenseAccuracyId,
                        principalTable: "SenseAccuracy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SenseAccuracy_SenseAccuracyId",
                        column: x => x.SenseAccuracyId,
                        principalTable: "SenseAccuracy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Senses_SenseId",
                        column: x => x.SenseId,
                        principalTable: "Senses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SkillActions_EnableSkillActionEffect_SkillAction~",
                        column: x => x.EnableSkillActionEffect_SkillActionId,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SkillActions_GainSpecificSkillActionCircumstance~",
                        column: x => x.GainSpecificSkillActionCircumstanceBonusEffect_SkillActionId,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SkillActions_GainSpecificSkillActionSpecificSavi~",
                        column: x => x.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEf3,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SkillActions_GainSpecificSkillSpecificSkillActi~1",
                        column: x => x.GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_Sk,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SkillActions_GainSpecificSkillSpecificSkillActio~",
                        column: x => x.GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect2,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SkillActions_ImproveSpecificSkillActionCheckEffe~",
                        column: x => x.ImproveSpecificSkillActionCheckEffect_SkillActionId,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_SkillActions_SkillActionId",
                        column: x => x.SkillActionId,
                        principalTable: "SkillActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Skills_EnableSkillActionEffect_SkillId",
                        column: x => x.EnableSkillActionEffect_SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Skills_GainAnySkillSkillFeatEffect_SkillId",
                        column: x => x.GainAnySkillSkillFeatEffect_SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Skills_GainSpecificSkillCircumstanceBonusEffect_~",
                        column: x => x.GainSpecificSkillCircumstanceBonusEffect_SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Skills_GainSpecificSkillDcCircumstanceBonusEffec~",
                        column: x => x.GainSpecificSkillDcCircumstanceBonusEffect_SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Skills_GainSpecificSkillInitiativeCircumstanceBo~",
                        column: x => x.GainSpecificSkillInitiativeCircumstanceBonusEffect_SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Skills_GainSpecificSkillProficiencyEffect_SkillId",
                        column: x => x.GainSpecificSkillProficiencyEffect_SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Skills_GainSpecificSkillSpecificActionCircumstan~",
                        column: x => x.GainSpecificSkillSpecificActionCircumstanceBonusEffect_SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Skills_GainSpecificSkillSpecificActionDcCircumst~",
                        column: x => x.GainSpecificSkillSpecificActionDcCircumstanceBonusEffect_Skill,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Skills_GainSpecificSkillSpecificSkillActionCircu~",
                        column: x => x.GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_S1,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Skills_GainSpecificSkillSpecificSkillActionDcCir~",
                        column: x => x.GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect3,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Spells_GainSpecificInnateSpellEffect_SpellId",
                        column: x => x.GainSpecificInnateSpellEffect_SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Stats_GainSpecificAbilityBoostEffect_StatId",
                        column: x => x.GainSpecificAbilityBoostEffect_StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Stats_GainSpecificAbilityFlawEffect_StatId",
                        column: x => x.GainSpecificAbilityFlawEffect_StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Stats_GainSpecificKeyAbilityOptionEffect_StatId",
                        column: x => x.GainSpecificKeyAbilityOptionEffect_StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Stats_GainSpecificSpellcastingAbilityEffect_Stat~",
                        column: x => x.GainSpecificSpellcastingAbilityEffect_StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Stats_GainSpecificStatSkillFeatEffect_StatId",
                        column: x => x.GainSpecificStatSkillFeatEffect_StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Stats_GainSpecificStatSkillProficiencyEffect_Sta~",
                        column: x => x.GainSpecificStatSkillProficiencyEffect_StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Stats_RequiredStatId",
                        column: x => x.RequiredStatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Traits_AncestryTraitId",
                        column: x => x.AncestryTraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Traits_GainSpecificTraitAnySavingThrowCircumstan~",
                        column: x => x.GainSpecificTraitAnySavingThrowCircumstanceBonusEffect_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Traits_GainSpecificTraitEffect_TraitId",
                        column: x => x.GainSpecificTraitEffect_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Traits_GainSpecificTraitFeatEffect_TraitId",
                        column: x => x.GainSpecificTraitFeatEffect_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Traits_GainSpecificTraitSpellEffect_TraitId",
                        column: x => x.GainSpecificTraitSpellEffect_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Traits_ImproveSpecificTraitAnySavingThrowEffect_~",
                        column: x => x.ImproveSpecificTraitAnySavingThrowEffect_TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Traits_RequiredTraitId",
                        column: x => x.RequiredTraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_UnarmedWeapons_UnarmedWeaponId",
                        column: x => x.UnarmedWeaponId,
                        principalTable: "UnarmedWeapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponCategories_GainAnyWeaponGroupProficiencyEf~",
                        column: x => x.GainAnyWeaponGroupProficiencyEffect_WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponCategories_GainChosenWeaponGroupProficienc~",
                        column: x => x.GainChosenWeaponGroupProficiencyEffect_WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponCategories_GainSpecificWeaponCategoryProfi~",
                        column: x => x.GainSpecificWeaponCategoryProficiencyEffect_WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponCategories_GainSpecificWeaponCategorySpeci~",
                        column: x => x.GainSpecificWeaponCategorySpecializationEffect_WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponCategories_GainSpecificWeaponGroupProficie~",
                        column: x => x.GainSpecificWeaponGroupProficiencyEffect_WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponCategories_ModifySpecificWeaponCategoryDam~",
                        column: x => x.ModifySpecificWeaponCategoryDamageDieAmountEffect_WeaponCatego,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponCategories_WeaponCategoryId",
                        column: x => x.WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponGroups_GainSingularExpertiseEffect_WeaponG~",
                        column: x => x.GainSingularExpertiseEffect_WeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponGroups_GainSpecificUnarmedAttackEffect_Wea~",
                        column: x => x.GainSpecificUnarmedAttackEffect_WeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponGroups_GainSpecificWeaponGroupCircumstance~",
                        column: x => x.GainSpecificWeaponGroupCircumstanceBonusEffect_WeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponGroups_GainSpecificWeaponGroupProficiencyE~",
                        column: x => x.GainSpecificWeaponGroupProficiencyEffect_WeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEffect_WeaponGroups_WeaponGroupId",
                        column: x => x.WeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BaseSpeed = table.Column<int>(type: "integer", nullable: false),
                    BaseHealth = table.Column<int>(type: "integer", nullable: false),
                    RarityId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SampleNames = table.Column<string>(type: "text", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ancestries_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ancestries_Rarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ancestries_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArcaneThesis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: true),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArcaneThesis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArcaneThesis_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArcaneThesis_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bloodlines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SpellListTraditionId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    InitialBloodlineSpellId = table.Column<Guid>(type: "uuid", nullable: false),
                    AdvancedBloodlineSpellId = table.Column<Guid>(type: "uuid", nullable: false),
                    GreaterBloodlineSpellId = table.Column<Guid>(type: "uuid", nullable: false),
                    BloodMagic = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    RarityId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "BloodMagic" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloodlines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bloodlines_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bloodlines_MagicTraditions_SpellListTraditionId",
                        column: x => x.SpellListTraditionId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bloodlines_Rarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bloodlines_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bloodlines_Spells_AdvancedBloodlineSpellId",
                        column: x => x.AdvancedBloodlineSpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bloodlines_Spells_GreaterBloodlineSpellId",
                        column: x => x.GreaterBloodlineSpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bloodlines_Spells_InitialBloodlineSpellId",
                        column: x => x.InitialBloodlineSpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooleanEffectBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BooleanEffectId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooleanEffectBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BooleanEffectBinding_BaseEffect_BooleanEffectId",
                        column: x => x.BooleanEffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooleanEffectBinding_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Causes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DivineSmite_Plain = table.Column<string>(type: "text", nullable: false),
                    DivineSmite_Markdown = table.Column<string>(type: "text", nullable: false),
                    DivineSmite_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Exalt = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClassId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    AlignmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Causes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Causes_Alignments_AlignmentId",
                        column: x => x.AlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Causes_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Causes_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Causes_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChoiceEffectBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ChoiceEffectId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChoiceEffectBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChoiceEffectBinding_BaseEffect_ChoiceEffectId",
                        column: x => x.ChoiceEffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChoiceEffectBinding_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassFeatures_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassFeatures_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Edicts = table.Column<string>(type: "text", nullable: false),
                    Anathema = table.Column<string>(type: "text", nullable: false),
                    AreasOfConcern = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    AlignmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    DevoteeEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    DivineIntercessionId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Anathema", "Edicts", "AreasOfConcern" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deities_Alignments_AlignmentId",
                        column: x => x.AlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deities_BaseEffect_DevoteeEffectId",
                        column: x => x.DevoteeEffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deities_DeityCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "DeityCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deities_DivineIntercession_DivineIntercessionId",
                        column: x => x.DivineIntercessionId,
                        principalTable: "DivineIntercession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deities_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctrines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctrines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctrines_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctrines_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DruidicOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DruidicOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DruidicOrders_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DruidicOrders_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EffectIncrement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TriggerId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Amount = table.Column<int>(type: "integer", nullable: true),
                    Level = table.Column<int>(type: "integer", nullable: true),
                    ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectIncrement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EffectIncrement_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EffectIncrement_EffectIncrementTrigger_TriggerId",
                        column: x => x.TriggerId,
                        principalTable: "EffectIncrementTrigger",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EffectIncrement_Proficiencies_ProficiencyId",
                        column: x => x.ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EffectIncrement_WeaponCategories_WeaponCategoryId",
                        column: x => x.WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eidolons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SuggestedAttacks = table.Column<string>(type: "text", nullable: false),
                    Speed = table.Column<int>(type: "integer", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    MagicTraditionId = table.Column<Guid>(type: "uuid", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eidolons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eidolons_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eidolons_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eidolons_MagicTraditions_MagicTraditionId",
                        column: x => x.MagicTraditionId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eidolons_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Heritages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RarityId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heritages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heritages_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Heritages_Rarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Heritages_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HuntersEdges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuntersEdges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuntersEdges_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HuntersEdges_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HybridStudies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    ConfluxSpellId = table.Column<Guid>(type: "uuid", nullable: false),
                    SeventhSpellId = table.Column<Guid>(type: "uuid", nullable: false),
                    EleventhSpellId = table.Column<Guid>(type: "uuid", nullable: false),
                    ThirteenthSpellId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HybridStudies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HybridStudies_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HybridStudies_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HybridStudies_Spells_ConfluxSpellId",
                        column: x => x.ConfluxSpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HybridStudies_Spells_EleventhSpellId",
                        column: x => x.EleventhSpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HybridStudies_Spells_SeventhSpellId",
                        column: x => x.SeventhSpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HybridStudies_Spells_ThirteenthSpellId",
                        column: x => x.ThirteenthSpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Innovations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    TableId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Innovations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Innovations_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Innovations_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Innovations_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instincts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SpecializationAbility = table.Column<string>(type: "text", nullable: false),
                    Anathema = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    RagingEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    InstinctAbilityEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    TableId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" }),
                    ClassId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instincts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instincts_BaseEffect_InstinctAbilityEffectId",
                        column: x => x.InstinctAbilityEffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instincts_BaseEffect_RagingEffectId",
                        column: x => x.RagingEffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instincts_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instincts_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instincts_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Methodologies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Methodologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Methodologies_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Methodologies_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Muses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Muses_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Muses_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mysteries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TrainedSkillAddendum = table.Column<string>(type: "text", nullable: true),
                    MysteryCurseId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    TrainedSkillId = table.Column<Guid>(type: "uuid", nullable: false),
                    GrantedCantripId = table.Column<Guid>(type: "uuid", nullable: false),
                    InitialRevelationId = table.Column<Guid>(type: "uuid", nullable: false),
                    AdvancedRevelationId = table.Column<Guid>(type: "uuid", nullable: false),
                    GreaterRevelationId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "TrainedSkillAddendum" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mysteries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mysteries_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mysteries_MysteryCurse_MysteryCurseId",
                        column: x => x.MysteryCurseId,
                        principalTable: "MysteryCurse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mysteries_Skills_TrainedSkillId",
                        column: x => x.TrainedSkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mysteries_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mysteries_Spells_AdvancedRevelationId",
                        column: x => x.AdvancedRevelationId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mysteries_Spells_GrantedCantripId",
                        column: x => x.GrantedCantripId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mysteries_Spells_GreaterRevelationId",
                        column: x => x.GreaterRevelationId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mysteries_Spells_InitialRevelationId",
                        column: x => x.InitialRevelationId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatronThemes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: false),
                    RarityId = table.Column<Guid>(type: "uuid", nullable: false),
                    MagicTraditionId = table.Column<Guid>(type: "uuid", nullable: false),
                    PatronSkillId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatronThemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatronThemes_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatronThemes_MagicTraditions_MagicTraditionId",
                        column: x => x.MagicTraditionId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatronThemes_Rarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatronThemes_Skills_PatronSkillId",
                        column: x => x.PatronSkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatronThemes_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rackets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rackets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rackets_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rackets_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResearchFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearchFields_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResearchFields_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RuneMagics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    InitialRuneSpellId = table.Column<Guid>(type: "uuid", nullable: false),
                    AdvancedRuneSpellId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: false),
                    MagicSchoolId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuneMagics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RuneMagics_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RuneMagics_MagicSchools_MagicSchoolId",
                        column: x => x.MagicSchoolId,
                        principalTable: "MagicSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RuneMagics_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RuneMagics_Spells_AdvancedRuneSpellId",
                        column: x => x.AdvancedRuneSpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RuneMagics_Spells_InitialRuneSpellId",
                        column: x => x.InitialRuneSpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SwashbucklersStyle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ExemplaryFinisher = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwashbucklersStyle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SwashbucklersStyle_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SwashbucklersStyle_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries_AdditionalMechanics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries_AdditionalMechanics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ancestries_AdditionalMechanics_Ancestries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries_Adventurers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries_Adventurers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ancestries_Adventurers_Ancestries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries_AlignmentAndReligion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries_AlignmentAndReligion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ancestries_AlignmentAndReligion_Ancestries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries_Description",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries_Description", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ancestries_Description_Ancestries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries_Names",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries_Names", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ancestries_Names_Ancestries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries_OtherInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries_OtherInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ancestries_OtherInformation_Ancestries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries_OthersProbably",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries_OthersProbably", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ancestries_OthersProbably_Ancestries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries_PhysicalDescription",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries_PhysicalDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ancestries_PhysicalDescription_Ancestries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries_Society",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries_Society", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ancestries_Society_Ancestries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ancestries_YouMight",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries_YouMight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ancestries_YouMight_Ancestries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AncestryAncestrySize",
                columns: table => new
                {
                    AncestriesId = table.Column<Guid>(type: "uuid", nullable: false),
                    SizesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AncestryAncestrySize", x => new { x.AncestriesId, x.SizesId });
                    table.ForeignKey(
                        name: "FK_AncestryAncestrySize_Ancestries_AncestriesId",
                        column: x => x.AncestriesId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AncestryAncestrySize_AncestrySizes_SizesId",
                        column: x => x.SizesId,
                        principalTable: "AncestrySizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AncestryTrait",
                columns: table => new
                {
                    AncestriesId = table.Column<Guid>(type: "uuid", nullable: false),
                    AncestryTraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AncestryTrait", x => new { x.AncestriesId, x.AncestryTraitsId });
                    table.ForeignKey(
                        name: "FK_AncestryTrait_Ancestries_AncestriesId",
                        column: x => x.AncestriesId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AncestryTrait_Traits_AncestryTraitsId",
                        column: x => x.AncestryTraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Creature",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    PerceptionAddendum = table.Column<string>(type: "text", nullable: true),
                    FortitudeAddendum = table.Column<string>(type: "text", nullable: true),
                    ReflexAddendum = table.Column<string>(type: "text", nullable: true),
                    WillAddendum = table.Column<string>(type: "text", nullable: true),
                    PerceptionModifier = table.Column<int>(type: "integer", nullable: false),
                    FortitudeModifier = table.Column<int>(type: "integer", nullable: false),
                    ReflexModifier = table.Column<int>(type: "integer", nullable: false),
                    WillModifier = table.Column<int>(type: "integer", nullable: false),
                    ArmorClass = table.Column<int>(type: "integer", nullable: false),
                    HitPoints = table.Column<int>(type: "integer", nullable: false),
                    Resistances = table.Column<string>(type: "text", nullable: true),
                    WalkingSpeed = table.Column<string>(type: "text", nullable: true),
                    FlyingSpeed = table.Column<string>(type: "text", nullable: true),
                    BurrowingSpeed = table.Column<string>(type: "text", nullable: true),
                    StrengthModifier = table.Column<int>(type: "integer", nullable: false),
                    DexterityModifier = table.Column<int>(type: "integer", nullable: false),
                    ConstitutionModifier = table.Column<int>(type: "integer", nullable: false),
                    IntelligenceModifier = table.Column<int>(type: "integer", nullable: false),
                    WisdomModifier = table.Column<int>(type: "integer", nullable: false),
                    CharismaModifier = table.Column<int>(type: "integer", nullable: false),
                    LanguageAddendum = table.Column<string>(type: "text", nullable: true),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    AlignmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    RarityId = table.Column<Guid>(type: "uuid", nullable: false),
                    SizeId = table.Column<Guid>(type: "uuid", nullable: false),
                    AncestryId = table.Column<Guid>(type: "uuid", nullable: true),
                    RecallKnowledgeId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Creature_Alignments_AlignmentId",
                        column: x => x.AlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Creature_Ancestries_AncestryId",
                        column: x => x.AncestryId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Creature_AncestrySizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "AncestrySizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Creature_CreatureRecallKnowledge_RecallKnowledgeId",
                        column: x => x.RecallKnowledgeId,
                        principalTable: "CreatureRecallKnowledge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Creature_Rarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Creature_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArcaneThesis_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArcaneThesis_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArcaneThesis_Details_ArcaneThesis_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "ArcaneThesis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bloodlines_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloodlines_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bloodlines_Details_Bloodlines_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Bloodlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bloodlines_TypeChoiceDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloodlines_TypeChoiceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bloodlines_TypeChoiceDetails_Bloodlines_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Bloodlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BloodlineSkill",
                columns: table => new
                {
                    BloodlineSkillsId = table.Column<Guid>(type: "uuid", nullable: false),
                    BloodlinesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodlineSkill", x => new { x.BloodlineSkillsId, x.BloodlinesId });
                    table.ForeignKey(
                        name: "FK_BloodlineSkill_Bloodlines_BloodlinesId",
                        column: x => x.BloodlinesId,
                        principalTable: "Bloodlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BloodlineSkill_Skills_BloodlineSkillsId",
                        column: x => x.BloodlineSkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Causes_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Causes_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Causes_Details_Causes_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Causes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassFeatureBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClassId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClassFeatureId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassFeatureBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassFeatureBinding_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassFeatureBinding_ClassFeatures_ClassFeatureId",
                        column: x => x.ClassFeatureId,
                        principalTable: "ClassFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassFeatures_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassFeatures_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassFeatures_Details_ClassFeatures_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "ClassFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlignmentDeity",
                columns: table => new
                {
                    DeityFollowerAlignmentsId = table.Column<Guid>(type: "uuid", nullable: false),
                    FollowerAlignmentsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlignmentDeity", x => new { x.DeityFollowerAlignmentsId, x.FollowerAlignmentsId });
                    table.ForeignKey(
                        name: "FK_AlignmentDeity_Alignments_FollowerAlignmentsId",
                        column: x => x.FollowerAlignmentsId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlignmentDeity_Deities_DeityFollowerAlignmentsId",
                        column: x => x.DeityFollowerAlignmentsId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deities_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deities_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deities_Details_Deities_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeityDivineFont",
                columns: table => new
                {
                    DeitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    DivineFontsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeityDivineFont", x => new { x.DeitiesId, x.DivineFontsId });
                    table.ForeignKey(
                        name: "FK_DeityDivineFont_Deities_DeitiesId",
                        column: x => x.DeitiesId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeityDivineFont_DivineFonts_DivineFontsId",
                        column: x => x.DivineFontsId,
                        principalTable: "DivineFonts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeityDomain",
                columns: table => new
                {
                    DeitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    DomainsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeityDomain", x => new { x.DeitiesId, x.DomainsId });
                    table.ForeignKey(
                        name: "FK_DeityDomain_Deities_DeitiesId",
                        column: x => x.DeitiesId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeityDomain_Domains_DomainsId",
                        column: x => x.DomainsId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeityMeleeWeapon",
                columns: table => new
                {
                    FavoredById = table.Column<Guid>(type: "uuid", nullable: false),
                    FavoredMeleeWeaponsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeityMeleeWeapon", x => new { x.FavoredById, x.FavoredMeleeWeaponsId });
                    table.ForeignKey(
                        name: "FK_DeityMeleeWeapon_Deities_FavoredById",
                        column: x => x.FavoredById,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeityMeleeWeapon_Items_FavoredMeleeWeaponsId",
                        column: x => x.FavoredMeleeWeaponsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeityRangedWeapon",
                columns: table => new
                {
                    FavoredById = table.Column<Guid>(type: "uuid", nullable: false),
                    FavoredRangedWeaponId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeityRangedWeapon", x => new { x.FavoredById, x.FavoredRangedWeaponId });
                    table.ForeignKey(
                        name: "FK_DeityRangedWeapon_Deities_FavoredById",
                        column: x => x.FavoredById,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeityRangedWeapon_Items_FavoredRangedWeaponId",
                        column: x => x.FavoredRangedWeaponId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeitySkill",
                columns: table => new
                {
                    DeitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    DivineSkillsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeitySkill", x => new { x.DeitiesId, x.DivineSkillsId });
                    table.ForeignKey(
                        name: "FK_DeitySkill_Deities_DeitiesId",
                        column: x => x.DeitiesId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeitySkill_Skills_DivineSkillsId",
                        column: x => x.DivineSkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeityStat",
                columns: table => new
                {
                    DeitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    DivineStatsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeityStat", x => new { x.DeitiesId, x.DivineStatsId });
                    table.ForeignKey(
                        name: "FK_DeityStat_Deities_DeitiesId",
                        column: x => x.DeitiesId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeityStat_Stats_DivineStatsId",
                        column: x => x.DivineStatsId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeityUnarmedWeapon",
                columns: table => new
                {
                    DeitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    FavoredUnarmedWeaponId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeityUnarmedWeapon", x => new { x.DeitiesId, x.FavoredUnarmedWeaponId });
                    table.ForeignKey(
                        name: "FK_DeityUnarmedWeapon_Deities_DeitiesId",
                        column: x => x.DeitiesId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeityUnarmedWeapon_UnarmedWeapons_FavoredUnarmedWeaponId",
                        column: x => x.FavoredUnarmedWeaponId,
                        principalTable: "UnarmedWeapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlignmentEidolon",
                columns: table => new
                {
                    EidolonsId = table.Column<Guid>(type: "uuid", nullable: false),
                    RequiredAlignmentsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlignmentEidolon", x => new { x.EidolonsId, x.RequiredAlignmentsId });
                    table.ForeignKey(
                        name: "FK_AlignmentEidolon_Alignments_RequiredAlignmentsId",
                        column: x => x.RequiredAlignmentsId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlignmentEidolon_Eidolons_EidolonsId",
                        column: x => x.EidolonsId,
                        principalTable: "Eidolons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AncestrySizeEidolon",
                columns: table => new
                {
                    EidolonsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SizesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AncestrySizeEidolon", x => new { x.EidolonsId, x.SizesId });
                    table.ForeignKey(
                        name: "FK_AncestrySizeEidolon_AncestrySizes_SizesId",
                        column: x => x.SizesId,
                        principalTable: "AncestrySizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AncestrySizeEidolon_Eidolons_EidolonsId",
                        column: x => x.EidolonsId,
                        principalTable: "Eidolons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EidolonAbility",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    EidolonId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EidolonAbility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EidolonAbility_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EidolonAbility_Eidolons_EidolonId",
                        column: x => x.EidolonId,
                        principalTable: "Eidolons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EidolonSense",
                columns: table => new
                {
                    EidolonsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SensesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EidolonSense", x => new { x.EidolonsId, x.SensesId });
                    table.ForeignKey(
                        name: "FK_EidolonSense_Eidolons_EidolonsId",
                        column: x => x.EidolonsId,
                        principalTable: "Eidolons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EidolonSense_Senses_SensesId",
                        column: x => x.SensesId,
                        principalTable: "Senses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EidolonSkill",
                columns: table => new
                {
                    EidolonsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EidolonSkill", x => new { x.EidolonsId, x.SkillsId });
                    table.ForeignKey(
                        name: "FK_EidolonSkill_Eidolons_EidolonsId",
                        column: x => x.EidolonsId,
                        principalTable: "Eidolons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EidolonSkill_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EidolonTrait",
                columns: table => new
                {
                    EidolonsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EidolonTrait", x => new { x.EidolonsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_EidolonTrait_Eidolons_EidolonsId",
                        column: x => x.EidolonsId,
                        principalTable: "Eidolons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EidolonTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EidolonVariant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    EidolonId = table.Column<Guid>(type: "uuid", nullable: false),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    Dexterity = table.Column<int>(type: "integer", nullable: false),
                    Constitution = table.Column<int>(type: "integer", nullable: false),
                    Intelligence = table.Column<int>(type: "integer", nullable: false),
                    Wisdom = table.Column<int>(type: "integer", nullable: false),
                    Charisma = table.Column<int>(type: "integer", nullable: false),
                    ArmorClass = table.Column<int>(type: "integer", nullable: false),
                    DexterityCap = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EidolonVariant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EidolonVariant_Eidolons_EidolonId",
                        column: x => x.EidolonId,
                        principalTable: "Eidolons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AncestryHeritage",
                columns: table => new
                {
                    AncestriesId = table.Column<Guid>(type: "uuid", nullable: false),
                    HeritagesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AncestryHeritage", x => new { x.AncestriesId, x.HeritagesId });
                    table.ForeignKey(
                        name: "FK_AncestryHeritage_Ancestries_AncestriesId",
                        column: x => x.AncestriesId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AncestryHeritage_Heritages_HeritagesId",
                        column: x => x.HeritagesId,
                        principalTable: "Heritages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Heritages_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heritages_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heritages_Details_Heritages_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Heritages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HybridStudies_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HybridStudies_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HybridStudies_Details_HybridStudies_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "HybridStudies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Innovations_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Innovations_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Innovations_Details_Innovations_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Innovations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Methodologies_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Methodologies_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Methodologies_Details_Methodologies_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Methodologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DomainMystery",
                columns: table => new
                {
                    MysteriesId = table.Column<Guid>(type: "uuid", nullable: false),
                    RelatedDomainsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomainMystery", x => new { x.MysteriesId, x.RelatedDomainsId });
                    table.ForeignKey(
                        name: "FK_DomainMystery_Domains_RelatedDomainsId",
                        column: x => x.RelatedDomainsId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DomainMystery_Mysteries_MysteriesId",
                        column: x => x.MysteriesId,
                        principalTable: "Mysteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mysteries_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mysteries_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mysteries_Details_Mysteries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Mysteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mysteries_MysteryBenefits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mysteries_MysteryBenefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mysteries_MysteryBenefits_Mysteries_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Mysteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatronThemeSpell",
                columns: table => new
                {
                    GrantedSpellOptionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    PatronThemesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatronThemeSpell", x => new { x.GrantedSpellOptionsId, x.PatronThemesId });
                    table.ForeignKey(
                        name: "FK_PatronThemeSpell_PatronThemes_PatronThemesId",
                        column: x => x.PatronThemesId,
                        principalTable: "PatronThemes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatronThemeSpell_Spells_GrantedSpellOptionsId",
                        column: x => x.GrantedSpellOptionsId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rackets_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rackets_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rackets_Details_Rackets_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Rackets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResearchFields_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchFields_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearchFields_Details_ResearchFields_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "ResearchFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RuneMagicSchoolBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MagicSchoolId = table.Column<Guid>(type: "uuid", nullable: false),
                    RuneMagicId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuneMagicSchoolBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RuneMagicSchoolBinding_MagicSchools_MagicSchoolId",
                        column: x => x.MagicSchoolId,
                        principalTable: "MagicSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RuneMagicSchoolBinding_RuneMagics_RuneMagicId",
                        column: x => x.RuneMagicId,
                        principalTable: "RuneMagics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Creature_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creature_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Creature_Details_Creature_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Creature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureFlavor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatureId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureFlavor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureFlavor_Creature_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureImmunity",
                columns: table => new
                {
                    CreaturesId = table.Column<Guid>(type: "uuid", nullable: false),
                    ImmunitiesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureImmunity", x => new { x.CreaturesId, x.ImmunitiesId });
                    table.ForeignKey(
                        name: "FK_CreatureImmunity_Creature_CreaturesId",
                        column: x => x.CreaturesId,
                        principalTable: "Creature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureImmunity_HazardImmunities_ImmunitiesId",
                        column: x => x.ImmunitiesId,
                        principalTable: "HazardImmunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureLanguage",
                columns: table => new
                {
                    CreaturesId = table.Column<Guid>(type: "uuid", nullable: false),
                    LanguagesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureLanguage", x => new { x.CreaturesId, x.LanguagesId });
                    table.ForeignKey(
                        name: "FK_CreatureLanguage_Creature_CreaturesId",
                        column: x => x.CreaturesId,
                        principalTable: "Creature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureLanguage_Languages_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureSense",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Addendum = table.Column<string>(type: "text", nullable: true),
                    Variant = table.Column<string>(type: "text", nullable: true),
                    CreatureId = table.Column<Guid>(type: "uuid", nullable: false),
                    SenseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureSense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureSense_Creature_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureSense_Senses_SenseId",
                        column: x => x.SenseId,
                        principalTable: "Senses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureSkill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Modifier = table.Column<int>(type: "integer", nullable: false),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatureId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureSkill_Creature_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureSkill_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureSpell",
                columns: table => new
                {
                    CreatureEffectsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SummonedById = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureSpell", x => new { x.CreatureEffectsId, x.SummonedById });
                    table.ForeignKey(
                        name: "FK_CreatureSpell_Creature_CreatureEffectsId",
                        column: x => x.CreatureEffectsId,
                        principalTable: "Creature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureSpell_Spells_SummonedById",
                        column: x => x.SummonedById,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureTrait",
                columns: table => new
                {
                    CreaturesId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureTrait", x => new { x.CreaturesId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_CreatureTrait_Creature_CreaturesId",
                        column: x => x.CreaturesId,
                        principalTable: "Creature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EidolonAbility_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EidolonAbility_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EidolonAbility_Details_EidolonAbility_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "EidolonAbility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureFlavor_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureFlavor_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureFlavor_Details_CreatureFlavor_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "CreatureFlavor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CanBeLearnedMoreThanOnce = table.Column<bool>(type: "boolean", nullable: false),
                    Special = table.Column<string>(type: "text", nullable: true),
                    Trigger = table.Column<string>(type: "text", nullable: true),
                    Frequency = table.Column<string>(type: "text", nullable: true),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    ActionTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    RollableEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    PrerequisiteId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" }),
                    ArchetypeId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feats_ActionTypes_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalTable: "ActionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feats_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feats_RollableEffect_RollableEffectId",
                        column: x => x.RollableEffectId,
                        principalTable: "RollableEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feats_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Archetypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsMulticlassArchetype = table.Column<bool>(type: "boolean", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    DedicationFeatId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archetypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Archetypes_Feats_DedicationFeatId",
                        column: x => x.DedicationFeatId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Archetypes_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatRequirement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    FeatId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatRequirement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeatRequirement_Feats_FeatId",
                        column: x => x.FeatId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feats_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feats_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feats_Details_Feats_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatTrait",
                columns: table => new
                {
                    FeatsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatTrait", x => new { x.FeatsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_FeatTrait_Feats_FeatsId",
                        column: x => x.FeatsId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Archetypes_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archetypes_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Archetypes_Details_Archetypes_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Archetypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Archetypes_MulticlassDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archetypes_MulticlassDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Archetypes_MulticlassDetails_Archetypes_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Archetypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasePrerequisite",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsNegated = table.Column<bool>(type: "boolean", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Addendum = table.Column<string>(type: "text", nullable: true),
                    Operator = table.Column<int>(type: "integer", nullable: true),
                    RequiredPhilosophyId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredMagicTraditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredAlignmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredDomainId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredDivineFontId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredWeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveAnyLoreProficiencyPrerequisite_RequiredProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveAnyMeleeWeaponSpecificProficiencyPrerequisite_RequiredProf = table.Column<Guid>(name: "HaveAnyMeleeWeaponSpecificProficiencyPrerequisite_RequiredProf~", type: "uuid", nullable: true),
                    HaveAnyRangedWeaponSpecificProficiencyPrerequisite_RequiredPro = table.Column<Guid>(name: "HaveAnyRangedWeaponSpecificProficiencyPrerequisite_RequiredPro~", type: "uuid", nullable: true),
                    HaveAnySavingThrowSpecificProficiencyPrerequisite_RequiredProf = table.Column<Guid>(name: "HaveAnySavingThrowSpecificProficiencyPrerequisite_RequiredProf~", type: "uuid", nullable: true),
                    RequiredSenseAccuracyId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveAnySkillProficiencyPrerequisite_RequiredProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveAnySkillSpecificProficiencyPrerequisite_RequiredProficienc = table.Column<Guid>(name: "HaveAnySkillSpecificProficiencyPrerequisite_RequiredProficienc~", type: "uuid", nullable: true),
                    RequiredTraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveAnyWeaponCategorySpecificProficiencyPrerequisite_RequiredP = table.Column<Guid>(name: "HaveAnyWeaponCategorySpecificProficiencyPrerequisite_RequiredP~", type: "uuid", nullable: true),
                    HaveAnyWeaponGroupSpecificProficiencyPrerequisite_RequiredProf = table.Column<Guid>(name: "HaveAnyWeaponGroupSpecificProficiencyPrerequisite_RequiredProf~", type: "uuid", nullable: true),
                    ArmorCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveCurrentWeaponProficiencyPrerequisite_RequiredProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    Comparator = table.Column<int>(type: "integer", nullable: true),
                    HaveFavoredWeaponSpecificProficiencyPrerequisite_RequiredProfi = table.Column<Guid>(name: "HaveFavoredWeaponSpecificProficiencyPrerequisite_RequiredProfi~", type: "uuid", nullable: true),
                    Years = table.Column<int>(type: "integer", nullable: true),
                    HaveSpecificAgePrerequisite_Comparator = table.Column<int>(type: "integer", nullable: true),
                    HaveSpecificAlignmentPrerequisite_RequiredAlignmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    Amount = table.Column<int>(type: "integer", nullable: true),
                    HaveSpecificAncestryAmountPreqrequisite_Comparator = table.Column<int>(type: "integer", nullable: true),
                    RequiredAncestryId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificAnimalCompanionAmountPrerequisite_Amount = table.Column<int>(type: "integer", nullable: true),
                    HaveSpecificAnimalCompanionAmountPrerequisite_Comparator = table.Column<int>(type: "integer", nullable: true),
                    HaveSpecificArmorCategorySpecificProficiencyPrerequisite_Armor = table.Column<Guid>(name: "HaveSpecificArmorCategorySpecificProficiencyPrerequisite_Armor~", type: "uuid", nullable: true),
                    HaveSpecificArmorCategorySpecificProficiencyPrerequisite_Requi = table.Column<Guid>(name: "HaveSpecificArmorCategorySpecificProficiencyPrerequisite_Requi~", type: "uuid", nullable: true),
                    RequiredBloodlineId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredBloodlineMagicTraditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredCauseId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredClassFeatureId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredClassId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificDecipherWritingProficiencyPrerequisite_RequiredPro = table.Column<Guid>(name: "HaveSpecificDecipherWritingProficiencyPrerequisite_RequiredPro~", type: "uuid", nullable: true),
                    RequiredDeityId = table.Column<Guid>(type: "uuid", nullable: true),
                    WeaponCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredDivineAllyId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificDivineFontPrerequisite_RequiredDivineFontId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredDraconicExemplarId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredDruidicOrderId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredFeatId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredGunsinglersWayId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredHeritageId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredHybridStudyId = table.Column<Guid>(type: "uuid", nullable: true),
                    InnovationId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredInstinctId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificLanguageAmountPrerequisite_Comparator = table.Column<int>(type: "integer", nullable: true),
                    HaveSpecificLanguageAmountPrerequisite_Amount = table.Column<int>(type: "integer", nullable: true),
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredLevel = table.Column<int>(type: "integer", nullable: true),
                    HaveSpecificLevelPrerequisite_Comparator = table.Column<int>(type: "integer", nullable: true),
                    HaveSpecificLoreSpecificProficiencyPrerequisite_RequiredProfic = table.Column<Guid>(name: "HaveSpecificLoreSpecificProficiencyPrerequisite_RequiredProfic~", type: "uuid", nullable: true),
                    RequiredLoreId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredMagicSchoolId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificMagicTraditionPrerequisite_RequiredMagicTraditionId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredMeleeWeaponId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificMeleeWeaponSpecificProficiencyPrerequisite_Require = table.Column<Guid>(name: "HaveSpecificMeleeWeaponSpecificProficiencyPrerequisite_Require~", type: "uuid", nullable: true),
                    RequiredMethodologyId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredMovementMethod = table.Column<int>(type: "integer", nullable: true),
                    RequiredMuseId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredRacketId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredRangedWeaponId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificRangedWeaponSpecificProficiencyPrerequisite_Requir = table.Column<Guid>(name: "HaveSpecificRangedWeaponSpecificProficiencyPrerequisite_Requir~", type: "uuid", nullable: true),
                    HaveSpecificRecallKnowledgeProficiencyPrerequisite_RequiredPro = table.Column<Guid>(name: "HaveSpecificRecallKnowledgeProficiencyPrerequisite_RequiredPro~", type: "uuid", nullable: true),
                    RequiresAssurance = table.Column<bool>(type: "boolean", nullable: true),
                    RequiredSavingThrowStatId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificSavingThrowSpecificProficiencyPrerequisite_Require = table.Column<Guid>(name: "HaveSpecificSavingThrowSpecificProficiencyPrerequisite_Require~", type: "uuid", nullable: true),
                    RequiredSenseId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredSizeId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredSkillId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificSkillProficiencyPrerequisite_RequiredProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredProfiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificSpellAttackProficiencyPrerequisite_RequiredProfici = table.Column<Guid>(name: "HaveSpecificSpellAttackProficiencyPrerequisite_RequiredProfici~", type: "uuid", nullable: true),
                    HaveSpecificSpellDcProficiencyPrerequisite_RequiredProfiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificSpellDcProficiencyPrerequisite_RequiredProficiency = table.Column<Guid>(name: "HaveSpecificSpellDcProficiencyPrerequisite_RequiredProficiency~", type: "uuid", nullable: true),
                    RequiredSpellId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpellSlotLevel = table.Column<int>(type: "integer", nullable: true),
                    HaveSpecificStanceAmountPrerequisite_Comparator = table.Column<int>(type: "integer", nullable: true),
                    HaveSpecificStanceAmountPrerequisite_Amount = table.Column<int>(type: "integer", nullable: true),
                    RequiredStatValue = table.Column<int>(type: "integer", nullable: true),
                    RequiredStatId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredTennetId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificTraitPrerequisite_RequiredTraitId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredUnarmedWeaponId = table.Column<Guid>(type: "uuid", nullable: true),
                    HaveSpecificWeaponCategorySpecificProficiencyPrerequisite_Requ = table.Column<Guid>(name: "HaveSpecificWeaponCategorySpecificProficiencyPrerequisite_Requ~", type: "uuid", nullable: true),
                    HaveSpecificWeaponCategorySpecificProficiencyPrerequisite_Req1 = table.Column<Guid>(name: "HaveSpecificWeaponCategorySpecificProficiencyPrerequisite_Req~1", type: "uuid", nullable: true),
                    HaveSpecificWeaponGroupSpecificProficiencyPrerequisite_Require = table.Column<Guid>(name: "HaveSpecificWeaponGroupSpecificProficiencyPrerequisite_Require~", type: "uuid", nullable: true),
                    RequiredWeaponGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    Text = table.Column<string>(type: "text", nullable: true),
                    WorshipSpecificDeityPrerequisite_RequiredDeityId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasePrerequisite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Alignments_HaveSpecificAlignmentPrerequisi~",
                        column: x => x.HaveSpecificAlignmentPrerequisite_RequiredAlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Alignments_RequiredAlignmentId",
                        column: x => x.RequiredAlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Ancestries_RequiredAncestryId",
                        column: x => x.RequiredAncestryId,
                        principalTable: "Ancestries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_AncestrySizes_RequiredSizeId",
                        column: x => x.RequiredSizeId,
                        principalTable: "AncestrySizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_ArmorCategories_ArmorCategoryId",
                        column: x => x.ArmorCategoryId,
                        principalTable: "ArmorCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_ArmorCategories_HaveSpecificArmorCategoryS~",
                        column: x => x.HaveSpecificArmorCategorySpecificProficiencyPrerequisite_Armor,
                        principalTable: "ArmorCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Bloodlines_RequiredBloodlineId",
                        column: x => x.RequiredBloodlineId,
                        principalTable: "Bloodlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Causes_RequiredCauseId",
                        column: x => x.RequiredCauseId,
                        principalTable: "Causes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Classes_RequiredClassId",
                        column: x => x.RequiredClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_ClassFeatures_RequiredClassFeatureId",
                        column: x => x.RequiredClassFeatureId,
                        principalTable: "ClassFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Deities_RequiredDeityId",
                        column: x => x.RequiredDeityId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Deities_WorshipSpecificDeityPrerequisite_R~",
                        column: x => x.WorshipSpecificDeityPrerequisite_RequiredDeityId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_DivineAllies_RequiredDivineAllyId",
                        column: x => x.RequiredDivineAllyId,
                        principalTable: "DivineAllies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_DivineFonts_HaveSpecificDivineFontPrerequi~",
                        column: x => x.HaveSpecificDivineFontPrerequisite_RequiredDivineFontId,
                        principalTable: "DivineFonts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_DivineFonts_RequiredDivineFontId",
                        column: x => x.RequiredDivineFontId,
                        principalTable: "DivineFonts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Domains_RequiredDomainId",
                        column: x => x.RequiredDomainId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_DraconicExemplars_RequiredDraconicExemplar~",
                        column: x => x.RequiredDraconicExemplarId,
                        principalTable: "DraconicExemplars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_DruidicOrders_RequiredDruidicOrderId",
                        column: x => x.RequiredDruidicOrderId,
                        principalTable: "DruidicOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Feats_RequiredFeatId",
                        column: x => x.RequiredFeatId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Heritages_RequiredHeritageId",
                        column: x => x.RequiredHeritageId,
                        principalTable: "Heritages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_HybridStudies_RequiredHybridStudyId",
                        column: x => x.RequiredHybridStudyId,
                        principalTable: "HybridStudies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Innovations_InnovationId",
                        column: x => x.InnovationId,
                        principalTable: "Innovations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Instincts_RequiredInstinctId",
                        column: x => x.RequiredInstinctId,
                        principalTable: "Instincts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Items_RequiredMeleeWeaponId",
                        column: x => x.RequiredMeleeWeaponId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Items_RequiredRangedWeaponId",
                        column: x => x.RequiredRangedWeaponId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Lores_RequiredLoreId",
                        column: x => x.RequiredLoreId,
                        principalTable: "Lores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_MagicSchools_RequiredMagicSchoolId",
                        column: x => x.RequiredMagicSchoolId,
                        principalTable: "MagicSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_MagicTraditions_HaveSpecificMagicTradition~",
                        column: x => x.HaveSpecificMagicTraditionPrerequisite_RequiredMagicTraditionId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_MagicTraditions_RequiredBloodlineMagicTrad~",
                        column: x => x.RequiredBloodlineMagicTraditionId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_MagicTraditions_RequiredMagicTraditionId",
                        column: x => x.RequiredMagicTraditionId,
                        principalTable: "MagicTraditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Methodologies_RequiredMethodologyId",
                        column: x => x.RequiredMethodologyId,
                        principalTable: "Methodologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Muses_RequiredMuseId",
                        column: x => x.RequiredMuseId,
                        principalTable: "Muses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Philosophies_RequiredPhilosophyId",
                        column: x => x.RequiredPhilosophyId,
                        principalTable: "Philosophies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveAnyLoreProficiencyPrereq~",
                        column: x => x.HaveAnyLoreProficiencyPrerequisite_RequiredProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveAnyMeleeWeaponSpecificPr~",
                        column: x => x.HaveAnyMeleeWeaponSpecificProficiencyPrerequisite_RequiredProf,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveAnyRangedWeaponSpecificP~",
                        column: x => x.HaveAnyRangedWeaponSpecificProficiencyPrerequisite_RequiredPro,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveAnySavingThrowSpecificPr~",
                        column: x => x.HaveAnySavingThrowSpecificProficiencyPrerequisite_RequiredProf,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveAnySkillProficiencyPrere~",
                        column: x => x.HaveAnySkillProficiencyPrerequisite_RequiredProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveAnySkillSpecificProficie~",
                        column: x => x.HaveAnySkillSpecificProficiencyPrerequisite_RequiredProficienc,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveAnyWeaponCategorySpecifi~",
                        column: x => x.HaveAnyWeaponCategorySpecificProficiencyPrerequisite_RequiredP,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveAnyWeaponGroupSpecificPr~",
                        column: x => x.HaveAnyWeaponGroupSpecificProficiencyPrerequisite_RequiredProf,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveCurrentWeaponProficiency~",
                        column: x => x.HaveCurrentWeaponProficiencyPrerequisite_RequiredProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveFavoredWeaponSpecificPro~",
                        column: x => x.HaveFavoredWeaponSpecificProficiencyPrerequisite_RequiredProfi,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificArmorCategorySpe~",
                        column: x => x.HaveSpecificArmorCategorySpecificProficiencyPrerequisite_Requi,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificDecipherWritingP~",
                        column: x => x.HaveSpecificDecipherWritingProficiencyPrerequisite_RequiredPro,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificLoreSpecificProf~",
                        column: x => x.HaveSpecificLoreSpecificProficiencyPrerequisite_RequiredProfic,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificMeleeWeaponSpeci~",
                        column: x => x.HaveSpecificMeleeWeaponSpecificProficiencyPrerequisite_Require,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificRangedWeaponSpec~",
                        column: x => x.HaveSpecificRangedWeaponSpecificProficiencyPrerequisite_Requir,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificRecallKnowledgeP~",
                        column: x => x.HaveSpecificRecallKnowledgeProficiencyPrerequisite_RequiredPro,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificSavingThrowSpeci~",
                        column: x => x.HaveSpecificSavingThrowSpecificProficiencyPrerequisite_Require,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificSkillProficiency~",
                        column: x => x.HaveSpecificSkillProficiencyPrerequisite_RequiredProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificSpellAttackProfi~",
                        column: x => x.HaveSpecificSpellAttackProficiencyPrerequisite_RequiredProfici,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificSpellDcProficien~",
                        column: x => x.HaveSpecificSpellDcProficiencyPrerequisite_RequiredProficiency,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificWeaponCategorySp~",
                        column: x => x.HaveSpecificWeaponCategorySpecificProficiencyPrerequisite_Requ,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_HaveSpecificWeaponGroupSpeci~",
                        column: x => x.HaveSpecificWeaponGroupSpecificProficiencyPrerequisite_Require,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Proficiencies_RequiredProficiencyId",
                        column: x => x.RequiredProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Rackets_RequiredRacketId",
                        column: x => x.RequiredRacketId,
                        principalTable: "Rackets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_SavingThrowStats_RequiredSavingThrowStatId",
                        column: x => x.RequiredSavingThrowStatId,
                        principalTable: "SavingThrowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_SenseAccuracy_RequiredSenseAccuracyId",
                        column: x => x.RequiredSenseAccuracyId,
                        principalTable: "SenseAccuracy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Senses_RequiredSenseId",
                        column: x => x.RequiredSenseId,
                        principalTable: "Senses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Skills_RequiredSkillId",
                        column: x => x.RequiredSkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Spells_RequiredSpellId",
                        column: x => x.RequiredSpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Stats_RequiredStatId",
                        column: x => x.RequiredStatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Tenets_RequiredTennetId",
                        column: x => x.RequiredTennetId,
                        principalTable: "Tenets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Traits_HaveSpecificTraitPrerequisite_Requi~",
                        column: x => x.HaveSpecificTraitPrerequisite_RequiredTraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_Traits_RequiredTraitId",
                        column: x => x.RequiredTraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_UnarmedWeapons_RequiredUnarmedWeaponId",
                        column: x => x.RequiredUnarmedWeaponId,
                        principalTable: "UnarmedWeapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_WeaponCategories_HaveSpecificWeaponCategor~",
                        column: x => x.HaveSpecificWeaponCategorySpecificProficiencyPrerequisite_Req1,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_WeaponCategories_RequiredWeaponCategoryId",
                        column: x => x.RequiredWeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_WeaponCategories_WeaponCategoryId",
                        column: x => x.WeaponCategoryId,
                        principalTable: "WeaponCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisite_WeaponGroups_RequiredWeaponGroupId",
                        column: x => x.RequiredWeaponGroupId,
                        principalTable: "WeaponGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Backgrounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    RarityId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    PrerequisiteId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Backgrounds_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Backgrounds_BasePrerequisite_PrerequisiteId",
                        column: x => x.PrerequisiteId,
                        principalTable: "BasePrerequisite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Backgrounds_Rarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Backgrounds_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooleanPrerequisiteBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BooleanPrerequisiteId = table.Column<Guid>(type: "uuid", nullable: false),
                    PrerequisiteId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooleanPrerequisiteBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BooleanPrerequisiteBinding_BasePrerequisite_BooleanPrerequi~",
                        column: x => x.BooleanPrerequisiteId,
                        principalTable: "BasePrerequisite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooleanPrerequisiteBinding_BasePrerequisite_PrerequisiteId",
                        column: x => x.PrerequisiteId,
                        principalTable: "BasePrerequisite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EidolonHomePlane",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PlaneId = table.Column<Guid>(type: "uuid", nullable: false),
                    EidolonId = table.Column<Guid>(type: "uuid", nullable: false),
                    PrerequisiteId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EidolonHomePlane", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EidolonHomePlane_BasePrerequisite_PrerequisiteId",
                        column: x => x.PrerequisiteId,
                        principalTable: "BasePrerequisite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EidolonHomePlane_Eidolons_EidolonId",
                        column: x => x.EidolonId,
                        principalTable: "Eidolons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EidolonHomePlane_Planes_PlaneId",
                        column: x => x.PlaneId,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunslingersWays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SlingersReloadId = table.Column<Guid>(type: "uuid", nullable: false),
                    InitialDeedId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    PrerequisiteId = table.Column<Guid>(type: "uuid", nullable: true),
                    AdvancedDeedId = table.Column<Guid>(type: "uuid", nullable: false),
                    GreaterDeedId = table.Column<Guid>(type: "uuid", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunslingersWays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GunslingersWays_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GunslingersWays_BasePrerequisite_PrerequisiteId",
                        column: x => x.PrerequisiteId,
                        principalTable: "BasePrerequisite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GunslingersWays_Feats_AdvancedDeedId",
                        column: x => x.AdvancedDeedId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GunslingersWays_Feats_GreaterDeedId",
                        column: x => x.GreaterDeedId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GunslingersWays_Feats_InitialDeedId",
                        column: x => x.InitialDeedId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GunslingersWays_Feats_SlingersReloadId",
                        column: x => x.SlingersReloadId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GunslingersWays_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InnovationModifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    TypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourcePageId = table.Column<Guid>(type: "uuid", nullable: false),
                    InnovationId = table.Column<Guid>(type: "uuid", nullable: false),
                    EffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    PrerequisiteId = table.Column<Guid>(type: "uuid", nullable: true),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Name", "Description" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InnovationModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InnovationModifications_BaseEffect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "BaseEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InnovationModifications_BasePrerequisite_PrerequisiteId",
                        column: x => x.PrerequisiteId,
                        principalTable: "BasePrerequisite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InnovationModifications_InnovationModificationTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "InnovationModificationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InnovationModifications_Innovations_InnovationId",
                        column: x => x.InnovationId,
                        principalTable: "Innovations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InnovationModifications_SourcePage_SourcePageId",
                        column: x => x.SourcePageId,
                        principalTable: "SourcePage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Backgrounds_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Backgrounds_Details_Backgrounds_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundTrait",
                columns: table => new
                {
                    BackgroundsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundTrait", x => new { x.BackgroundsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_BackgroundTrait_Backgrounds_BackgroundsId",
                        column: x => x.BackgroundsId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunslingersWays_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SearchVector = table.Column<NpgsqlTsVector>(type: "tsvector", nullable: false)
                        .Annotation("Npgsql:TsVectorConfig", "english")
                        .Annotation("Npgsql:TsVectorProperties", new[] { "Text" })
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunslingersWays_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GunslingersWays_Details_GunslingersWays_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "GunslingersWays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunslingersWaySkill",
                columns: table => new
                {
                    GunslingersWaysId = table.Column<Guid>(type: "uuid", nullable: false),
                    WaySkillIdOptionsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunslingersWaySkill", x => new { x.GunslingersWaysId, x.WaySkillIdOptionsId });
                    table.ForeignKey(
                        name: "FK_GunslingersWaySkill_GunslingersWays_GunslingersWaysId",
                        column: x => x.GunslingersWaysId,
                        principalTable: "GunslingersWays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GunslingersWaySkill_Skills_WaySkillIdOptionsId",
                        column: x => x.WaySkillIdOptionsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_ActionTypeId",
                table: "Abilities",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_RollableEffectId",
                table: "Abilities",
                column: "RollableEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_SearchVector",
                table: "Abilities",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_SourcePageId",
                table: "Abilities",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_Effects_OwnerId",
                table: "Abilities_Effects",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_Effects_SearchVector",
                table: "Abilities_Effects",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityTrait_TraitsId",
                table: "AbilityTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_ActionTypeId",
                table: "Actions",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_RollableEffectId",
                table: "Actions",
                column: "RollableEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_SearchVector",
                table: "Actions",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_Details_OwnerId",
                table: "Actions_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_Details_SearchVector",
                table: "Actions_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ActionTrait_TraitsId",
                table: "ActionTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionTypes_SearchVector",
                table: "ActionTypes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_SearchVector",
                table: "Activities",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_SourcePageId",
                table: "Activities",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Details_OwnerId",
                table: "Activities_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Details_SearchVector",
                table: "Activities_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTrait_TraitsId",
                table: "ActivityTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_AlignmentDeity_FollowerAlignmentsId",
                table: "AlignmentDeity",
                column: "FollowerAlignmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_AlignmentEidolon_RequiredAlignmentsId",
                table: "AlignmentEidolon",
                column: "RequiredAlignmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Alignments_PhilosophyId",
                table: "Alignments",
                column: "PhilosophyId");

            migrationBuilder.CreateIndex(
                name: "IX_Alignments_SearchVector",
                table: "Alignments",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_EffectId",
                table: "Ancestries",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_RarityId",
                table: "Ancestries",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_SearchVector",
                table: "Ancestries",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_SourcePageId",
                table: "Ancestries",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_AdditionalMechanics_OwnerId",
                table: "Ancestries_AdditionalMechanics",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_AdditionalMechanics_SearchVector",
                table: "Ancestries_AdditionalMechanics",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_Adventurers_OwnerId",
                table: "Ancestries_Adventurers",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_Adventurers_SearchVector",
                table: "Ancestries_Adventurers",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_AlignmentAndReligion_OwnerId",
                table: "Ancestries_AlignmentAndReligion",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_AlignmentAndReligion_SearchVector",
                table: "Ancestries_AlignmentAndReligion",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_Description_OwnerId",
                table: "Ancestries_Description",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_Description_SearchVector",
                table: "Ancestries_Description",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_Names_OwnerId",
                table: "Ancestries_Names",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_Names_SearchVector",
                table: "Ancestries_Names",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_OtherInformation_OwnerId",
                table: "Ancestries_OtherInformation",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_OtherInformation_SearchVector",
                table: "Ancestries_OtherInformation",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_OthersProbably_OwnerId",
                table: "Ancestries_OthersProbably",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_OthersProbably_SearchVector",
                table: "Ancestries_OthersProbably",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_PhysicalDescription_OwnerId",
                table: "Ancestries_PhysicalDescription",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_PhysicalDescription_SearchVector",
                table: "Ancestries_PhysicalDescription",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_Society_OwnerId",
                table: "Ancestries_Society",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_Society_SearchVector",
                table: "Ancestries_Society",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_YouMight_OwnerId",
                table: "Ancestries_YouMight",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ancestries_YouMight_SearchVector",
                table: "Ancestries_YouMight",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_AncestryAncestrySize_SizesId",
                table: "AncestryAncestrySize",
                column: "SizesId");

            migrationBuilder.CreateIndex(
                name: "IX_AncestryHeritage_HeritagesId",
                table: "AncestryHeritage",
                column: "HeritagesId");

            migrationBuilder.CreateIndex(
                name: "IX_AncestrySizeEidolon_SizesId",
                table: "AncestrySizeEidolon",
                column: "SizesId");

            migrationBuilder.CreateIndex(
                name: "IX_AncestrySizes_SearchVector",
                table: "AncestrySizes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_AncestryTrait_AncestryTraitsId",
                table: "AncestryTrait",
                column: "AncestryTraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_ArcaneThesis_EffectId",
                table: "ArcaneThesis",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_ArcaneThesis_SearchVector",
                table: "ArcaneThesis",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ArcaneThesis_SourcePageId",
                table: "ArcaneThesis",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_ArcaneThesis_Details_OwnerId",
                table: "ArcaneThesis_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ArcaneThesis_Details_SearchVector",
                table: "ArcaneThesis_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Archetypes_DedicationFeatId",
                table: "Archetypes",
                column: "DedicationFeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Archetypes_SearchVector",
                table: "Archetypes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Archetypes_SourcePageId",
                table: "Archetypes",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Archetypes_Details_OwnerId",
                table: "Archetypes_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Archetypes_Details_SearchVector",
                table: "Archetypes_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Archetypes_MulticlassDetails_OwnerId",
                table: "Archetypes_MulticlassDetails",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Archetypes_MulticlassDetails_SearchVector",
                table: "Archetypes_MulticlassDetails",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorCategories_SearchVector",
                table: "ArmorCategories",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorGroups_SearchVector",
                table: "ArmorGroups",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorGroups_SourcePageId",
                table: "ArmorGroups",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_AttackTypes_SearchVector",
                table: "AttackTypes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_EffectId",
                table: "Backgrounds",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_PrerequisiteId",
                table: "Backgrounds",
                column: "PrerequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_RarityId",
                table: "Backgrounds",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_SearchVector",
                table: "Backgrounds",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_SourcePageId",
                table: "Backgrounds",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_Details_OwnerId",
                table: "Backgrounds_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_Details_SearchVector",
                table: "Backgrounds_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundTrait_TraitsId",
                table: "BackgroundTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_AbilityId",
                table: "BaseEffect",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ActionId",
                table: "BaseEffect",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_AlchemicalElixirId",
                table: "BaseEffect",
                column: "AlchemicalElixirId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_AncestryTraitId",
                table: "BaseEffect",
                column: "AncestryTraitId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ArmorCategoryId",
                table: "BaseEffect",
                column: "ArmorCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ArmorId",
                table: "BaseEffect",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_CauseId",
                table: "BaseEffect",
                column: "CauseId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ChoiceId",
                table: "BaseEffect",
                column: "ChoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ClassId",
                table: "BaseEffect",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ConditionId",
                table: "BaseEffect",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_DamageTypeId",
                table: "BaseEffect",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_DisableFeatPrerequisitesEffect_FeatId",
                table: "BaseEffect",
                column: "DisableFeatPrerequisitesEffect_FeatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_EnableSkillActionEffect_SkillActionId",
                table: "BaseEffect",
                column: "EnableSkillActionEffect_SkillActionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_EnableSkillActionEffect_SkillId",
                table: "BaseEffect",
                column: "EnableSkillActionEffect_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_FeatId",
                table: "BaseEffect",
                column: "FeatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainAnyClassFeatEffect_ClassId",
                table: "BaseEffect",
                column: "GainAnyClassFeatEffect_ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainAnyLoreProficiencyEffect_ProficiencyId",
                table: "BaseEffect",
                column: "GainAnyLoreProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainAnySavingThrowProficiencyEffect_ProficiencyId",
                table: "BaseEffect",
                column: "GainAnySavingThrowProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainAnySenseEffect_SenseAccuracyId",
                table: "BaseEffect",
                column: "GainAnySenseEffect_SenseAccuracyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainAnySkillProficiencyEffect_ProficiencyId",
                table: "BaseEffect",
                column: "GainAnySkillProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainAnySkillSkillFeatEffect_SkillId",
                table: "BaseEffect",
                column: "GainAnySkillSkillFeatEffect_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainAnyWeaponGroupProficiencyEffect_ProficiencyId",
                table: "BaseEffect",
                column: "GainAnyWeaponGroupProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainAnyWeaponGroupProficiencyEffect_WeaponCatego~",
                table: "BaseEffect",
                column: "GainAnyWeaponGroupProficiencyEffect_WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainChosenSkillProficiencyEffect_ProficiencyId",
                table: "BaseEffect",
                column: "GainChosenSkillProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainChosenWeaponGroupProficiencyEffect_Proficien~",
                table: "BaseEffect",
                column: "GainChosenWeaponGroupProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainChosenWeaponGroupProficiencyEffect_WeaponCat~",
                table: "BaseEffect",
                column: "GainChosenWeaponGroupProficiencyEffect_WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainDeityFavoredWeaponProficiencyEffect_Proficie~",
                table: "BaseEffect",
                column: "GainDeityFavoredWeaponProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSingularExpertiseEffect_WeaponGroupId",
                table: "BaseEffect",
                column: "GainSingularExpertiseEffect_WeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificAbilityBoostEffect_StatId",
                table: "BaseEffect",
                column: "GainSpecificAbilityBoostEffect_StatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificAbilityFlawEffect_StatId",
                table: "BaseEffect",
                column: "GainSpecificAbilityFlawEffect_StatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificActionCircumstanceBonusEffect_Action~",
                table: "BaseEffect",
                column: "GainSpecificActionCircumstanceBonusEffect_ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificAlchemicalBombProficiencyEffect_Prof~",
                table: "BaseEffect",
                column: "GainSpecificAlchemicalBombProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificArmorCategoryProficiencyEffect_Armor~",
                table: "BaseEffect",
                column: "GainSpecificArmorCategoryProficiencyEffect_ArmorCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificArmorCategoryProficiencyEffect_Profi~",
                table: "BaseEffect",
                column: "GainSpecificArmorCategoryProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificClassDcProficiencyEffect_Proficiency~",
                table: "BaseEffect",
                column: "GainSpecificClassDcProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificConditionAnySavingThrowCircumstanceB~",
                table: "BaseEffect",
                column: "GainSpecificConditionAnySavingThrowCircumstanceBonusEffect_Con~");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificDamageResistanceEffect_DamageTypeId",
                table: "BaseEffect",
                column: "GainSpecificDamageResistanceEffect_DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificDamageWeaknessEffect_DamageTypeId",
                table: "BaseEffect",
                column: "GainSpecificDamageWeaknessEffect_DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificFeatEffect_FeatId",
                table: "BaseEffect",
                column: "GainSpecificFeatEffect_FeatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificInnateSpellEffect_MagicTraditionId",
                table: "BaseEffect",
                column: "GainSpecificInnateSpellEffect_MagicTraditionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificInnateSpellEffect_SpellId",
                table: "BaseEffect",
                column: "GainSpecificInnateSpellEffect_SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificKeyAbilityOptionEffect_StatId",
                table: "BaseEffect",
                column: "GainSpecificKeyAbilityOptionEffect_StatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificLoreCategoryProficiencyEffect_Profic~",
                table: "BaseEffect",
                column: "GainSpecificLoreCategoryProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificLoreProficiencyEffect_ProficiencyId",
                table: "BaseEffect",
                column: "GainSpecificLoreProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificMagicSchoolAnySavingThrowCircumstanc~",
                table: "BaseEffect",
                column: "GainSpecificMagicSchoolAnySavingThrowCircumstanceBonusEffect_M~");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificMagicSchoolEffect_MagicSchoolId",
                table: "BaseEffect",
                column: "GainSpecificMagicSchoolEffect_MagicSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificMagicTraditionAnyInnateSpellEffect_M~",
                table: "BaseEffect",
                column: "GainSpecificMagicTraditionAnyInnateSpellEffect_MagicTraditionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificMagicTraditionAnySpellEffect_MagicTr~",
                table: "BaseEffect",
                column: "GainSpecificMagicTraditionAnySpellEffect_MagicTraditionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificMeleeWeaponEffect_MeleeWeaponId",
                table: "BaseEffect",
                column: "GainSpecificMeleeWeaponEffect_MeleeWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificMeleeWeaponProficiencyEffect_Profici~",
                table: "BaseEffect",
                column: "GainSpecificMeleeWeaponProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificRangedWeaponProficiencyEffect_Profic~",
                table: "BaseEffect",
                column: "GainSpecificRangedWeaponProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificRarityAnyLanguageEffect_RarityId",
                table: "BaseEffect",
                column: "GainSpecificRarityAnyLanguageEffect_RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSavingThrowProficiencyEffect_Profici~",
                table: "BaseEffect",
                column: "GainSpecificSavingThrowProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSavingThrowProficiencyEffect_SavingT~",
                table: "BaseEffect",
                column: "GainSpecificSavingThrowProficiencyEffect_SavingThrowStatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillActionCircumstanceBonusEffect_S~",
                table: "BaseEffect",
                column: "GainSpecificSkillActionCircumstanceBonusEffect_SkillActionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillActionSpecificSavingThrowCircu~1",
                table: "BaseEffect",
                column: "GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEf~3");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillActionSpecificSavingThrowCircum~",
                table: "BaseEffect",
                column: "GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEf~2");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillCircumstanceBonusEffect_SkillId",
                table: "BaseEffect",
                column: "GainSpecificSkillCircumstanceBonusEffect_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillDcCircumstanceBonusEffect_Skill~",
                table: "BaseEffect",
                column: "GainSpecificSkillDcCircumstanceBonusEffect_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillInitiativeCircumstanceBonusEffe~",
                table: "BaseEffect",
                column: "GainSpecificSkillInitiativeCircumstanceBonusEffect_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillProficiencyEffect_ProficiencyId",
                table: "BaseEffect",
                column: "GainSpecificSkillProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillProficiencyEffect_SkillId",
                table: "BaseEffect",
                column: "GainSpecificSkillProficiencyEffect_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillSpecificActionCircumstanceBonu~1",
                table: "BaseEffect",
                column: "GainSpecificSkillSpecificActionCircumstanceBonusEffect_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillSpecificActionCircumstanceBonus~",
                table: "BaseEffect",
                column: "GainSpecificSkillSpecificActionCircumstanceBonusEffect_ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillSpecificActionDcCircumstanceBo~1",
                table: "BaseEffect",
                column: "GainSpecificSkillSpecificActionDcCircumstanceBonusEffect_Skill~");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillSpecificActionDcCircumstanceBon~",
                table: "BaseEffect",
                column: "GainSpecificSkillSpecificActionDcCircumstanceBonusEffect_Actio~");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillSpecificSkillActionCircumstanc~1",
                table: "BaseEffect",
                column: "GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_S~1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillSpecificSkillActionCircumstance~",
                table: "BaseEffect",
                column: "GainSpecificSkillSpecificSkillActionCircumstanceBonusEffect_Sk~");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillSpecificSkillActionDcCircumsta~1",
                table: "BaseEffect",
                column: "GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect~3");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSkillSpecificSkillActionDcCircumstan~",
                table: "BaseEffect",
                column: "GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect~2");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSpellAttackProficiencyEffect_Profici~",
                table: "BaseEffect",
                column: "GainSpecificSpellAttackProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSpellcastingAbilityEffect_StatId",
                table: "BaseEffect",
                column: "GainSpecificSpellcastingAbilityEffect_StatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificSpellDcProficiencyEffect_Proficiency~",
                table: "BaseEffect",
                column: "GainSpecificSpellDcProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificStatSkillFeatEffect_StatId",
                table: "BaseEffect",
                column: "GainSpecificStatSkillFeatEffect_StatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificStatSkillProficiencyEffect_Proficien~",
                table: "BaseEffect",
                column: "GainSpecificStatSkillProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificStatSkillProficiencyEffect_StatId",
                table: "BaseEffect",
                column: "GainSpecificStatSkillProficiencyEffect_StatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificTraitAnySavingThrowCircumstanceBonus~",
                table: "BaseEffect",
                column: "GainSpecificTraitAnySavingThrowCircumstanceBonusEffect_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificTraitEffect_TraitId",
                table: "BaseEffect",
                column: "GainSpecificTraitEffect_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificTraitFeatEffect_TraitId",
                table: "BaseEffect",
                column: "GainSpecificTraitFeatEffect_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificTraitSpellEffect_TraitId",
                table: "BaseEffect",
                column: "GainSpecificTraitSpellEffect_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificUnarmedAttackEffect_WeaponGroupId",
                table: "BaseEffect",
                column: "GainSpecificUnarmedAttackEffect_WeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificWeaponCategoryProficiencyEffect_Prof~",
                table: "BaseEffect",
                column: "GainSpecificWeaponCategoryProficiencyEffect_ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificWeaponCategoryProficiencyEffect_Weap~",
                table: "BaseEffect",
                column: "GainSpecificWeaponCategoryProficiencyEffect_WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificWeaponCategorySpecializationEffect_W~",
                table: "BaseEffect",
                column: "GainSpecificWeaponCategorySpecializationEffect_WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificWeaponGroupCircumstanceBonusEffect_W~",
                table: "BaseEffect",
                column: "GainSpecificWeaponGroupCircumstanceBonusEffect_WeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificWeaponGroupProficiencyEffect_WeaponC~",
                table: "BaseEffect",
                column: "GainSpecificWeaponGroupProficiencyEffect_WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_GainSpecificWeaponGroupProficiencyEffect_WeaponG~",
                table: "BaseEffect",
                column: "GainSpecificWeaponGroupProficiencyEffect_WeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_HeritageId",
                table: "BaseEffect",
                column: "HeritageId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_HighestProficiencyId",
                table: "BaseEffect",
                column: "HighestProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ImproveSpecificConditionAnySavingThrowEffect_Con~",
                table: "BaseEffect",
                column: "ImproveSpecificConditionAnySavingThrowEffect_ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ImproveSpecificSkillActionCheckEffect_SkillActio~",
                table: "BaseEffect",
                column: "ImproveSpecificSkillActionCheckEffect_SkillActionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ImproveSpecificTraitAnySavingThrowEffect_TraitId",
                table: "BaseEffect",
                column: "ImproveSpecificTraitAnySavingThrowEffect_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_InnovationModificationTypeId",
                table: "BaseEffect",
                column: "InnovationModificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_InstinctAbilityId",
                table: "BaseEffect",
                column: "InstinctAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_InstinctId",
                table: "BaseEffect",
                column: "InstinctId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_LanguageId",
                table: "BaseEffect",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_LoreCategoryId",
                table: "BaseEffect",
                column: "LoreCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_LoreId",
                table: "BaseEffect",
                column: "LoreId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_MagicSchoolId",
                table: "BaseEffect",
                column: "MagicSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_MagicTraditionId",
                table: "BaseEffect",
                column: "MagicTraditionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_MeleeWeaponId",
                table: "BaseEffect",
                column: "MeleeWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ModificationEffectId",
                table: "BaseEffect",
                column: "ModificationEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ModifyFeatEffectsEffect_FeatId",
                table: "BaseEffect",
                column: "ModifyFeatEffectsEffect_FeatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ModifySpecificWeaponCategoryDamageDieAmountEffec~",
                table: "BaseEffect",
                column: "ModifySpecificWeaponCategoryDamageDieAmountEffect_WeaponCatego~");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_PotencyId",
                table: "BaseEffect",
                column: "PotencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_PrerequisiteId",
                table: "BaseEffect",
                column: "PrerequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ProficiencyId",
                table: "BaseEffect",
                column: "ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ProhibitedFeatId",
                table: "BaseEffect",
                column: "ProhibitedFeatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_ProhibitedMagicSchoolId",
                table: "BaseEffect",
                column: "ProhibitedMagicSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_RangedWeaponId",
                table: "BaseEffect",
                column: "RangedWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_RarityId",
                table: "BaseEffect",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_RequiredStatId",
                table: "BaseEffect",
                column: "RequiredStatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_RequiredTraitId",
                table: "BaseEffect",
                column: "RequiredTraitId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_RuneMagicId",
                table: "BaseEffect",
                column: "RuneMagicId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_SavingThrowStatId",
                table: "BaseEffect",
                column: "SavingThrowStatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_SenseAccuracyId",
                table: "BaseEffect",
                column: "SenseAccuracyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_SenseId",
                table: "BaseEffect",
                column: "SenseId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_SizeId",
                table: "BaseEffect",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_SkillActionId",
                table: "BaseEffect",
                column: "SkillActionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_SkillId",
                table: "BaseEffect",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_SpellId",
                table: "BaseEffect",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_StatId",
                table: "BaseEffect",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_TraitId",
                table: "BaseEffect",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_UnarmedWeaponId",
                table: "BaseEffect",
                column: "UnarmedWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_WeaponCategoryId",
                table: "BaseEffect",
                column: "WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEffect_WeaponGroupId",
                table: "BaseEffect",
                column: "WeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemTraitBinding_OwnerId",
                table: "BaseItemTraitBinding",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemTraitBinding_TraitId",
                table: "BaseItemTraitBinding",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_AlchemicalBombVariant_SearchVector",
                table: "BaseItemVariant",
                column: "AlchemicalBombVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_AlchemicalElixirVariant_PotencyId",
                table: "BaseItemVariant",
                column: "AlchemicalElixirVariant_PotencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_AlchemicalElixirVariant_SearchVector",
                table: "BaseItemVariant",
                column: "AlchemicalElixirVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_AlchemicalPoisonVariant_SearchVector",
                table: "BaseItemVariant",
                column: "AlchemicalPoisonVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_AlchemicalToolVariant_PotencyId",
                table: "BaseItemVariant",
                column: "AlchemicalToolVariant_PotencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_AlchemicalToolVariant_SearchVector",
                table: "BaseItemVariant",
                column: "AlchemicalToolVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_AlignmentId",
                table: "BaseItemVariant",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_AmmunitionVariant_SearchVector",
                table: "BaseItemVariant",
                column: "AmmunitionVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_ArmorPropertyRuneVariant_SearchVector",
                table: "BaseItemVariant",
                column: "ArmorPropertyRuneVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_ArmorVariant_SearchVector",
                table: "BaseItemVariant",
                column: "ArmorVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_ArtifactVariant_SearchVector",
                table: "BaseItemVariant",
                column: "ArtifactVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_BeastGunVariant_PotencyId",
                table: "BaseItemVariant",
                column: "BeastGunVariant_PotencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_BeastGunVariant_SearchVector",
                table: "BaseItemVariant",
                column: "BeastGunVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_BulkId",
                table: "BaseItemVariant",
                column: "BulkId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_CombinationWeaponVariant_SearchVector",
                table: "BaseItemVariant",
                column: "CombinationWeaponVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_DamageTypeId",
                table: "BaseItemVariant",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_FundamentalArmorRuneVariant_SearchVector",
                table: "BaseItemVariant",
                column: "FundamentalArmorRuneVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_FundamentalWeaponRuneVariant_SearchVector",
                table: "BaseItemVariant",
                column: "FundamentalWeaponRuneVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_HeldItemVariant_SearchVector",
                table: "BaseItemVariant",
                column: "HeldItemVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_ItemId",
                table: "BaseItemVariant",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_MeleeComponentId",
                table: "BaseItemVariant",
                column: "MeleeComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_MeleeWeaponVariant_DamageTypeId",
                table: "BaseItemVariant",
                column: "MeleeWeaponVariant_DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_MeleeWeaponVariant_SearchVector",
                table: "BaseItemVariant",
                column: "MeleeWeaponVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_PoisonEffectId",
                table: "BaseItemVariant",
                column: "PoisonEffectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_PotencyId",
                table: "BaseItemVariant",
                column: "PotencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_PreciousMaterialItemVariant_SearchVector",
                table: "BaseItemVariant",
                column: "PreciousMaterialItemVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_RangedComponentId",
                table: "BaseItemVariant",
                column: "RangedComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_RangedWeaponVariant_DamageTypeId",
                table: "BaseItemVariant",
                column: "RangedWeaponVariant_DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_RangedWeaponVariant_SearchVector",
                table: "BaseItemVariant",
                column: "RangedWeaponVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_RarityId",
                table: "BaseItemVariant",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_RollableEffectId",
                table: "BaseItemVariant",
                column: "RollableEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_RuneVariant_PotencyId",
                table: "BaseItemVariant",
                column: "RuneVariant_PotencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_SearchVector",
                table: "BaseItemVariant",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_ShieldVariant_SearchVector",
                table: "BaseItemVariant",
                column: "ShieldVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_StaveVariant_PotencyId",
                table: "BaseItemVariant",
                column: "StaveVariant_PotencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_StaveVariant_SearchVector",
                table: "BaseItemVariant",
                column: "StaveVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_WeaponPropertyRuneVariant_SearchVector",
                table: "BaseItemVariant",
                column: "WeaponPropertyRuneVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_WornItemVariant_SearchVector",
                table: "BaseItemVariant",
                column: "WornItemVariant_SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_Addendum_OwnerId",
                table: "BaseItemVariant_Addendum",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemVariant_Addendum_SearchVector",
                table: "BaseItemVariant_Addendum",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_ArmorCategoryId",
                table: "BasePrerequisite",
                column: "ArmorCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveAnyLoreProficiencyPrerequisite_Require~",
                table: "BasePrerequisite",
                column: "HaveAnyLoreProficiencyPrerequisite_RequiredProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveAnyMeleeWeaponSpecificProficiencyPrere~",
                table: "BasePrerequisite",
                column: "HaveAnyMeleeWeaponSpecificProficiencyPrerequisite_RequiredProf~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveAnyRangedWeaponSpecificProficiencyPrer~",
                table: "BasePrerequisite",
                column: "HaveAnyRangedWeaponSpecificProficiencyPrerequisite_RequiredPro~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveAnySavingThrowSpecificProficiencyPrere~",
                table: "BasePrerequisite",
                column: "HaveAnySavingThrowSpecificProficiencyPrerequisite_RequiredProf~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveAnySkillProficiencyPrerequisite_Requir~",
                table: "BasePrerequisite",
                column: "HaveAnySkillProficiencyPrerequisite_RequiredProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveAnySkillSpecificProficiencyPrerequisit~",
                table: "BasePrerequisite",
                column: "HaveAnySkillSpecificProficiencyPrerequisite_RequiredProficienc~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveAnyWeaponCategorySpecificProficiencyPr~",
                table: "BasePrerequisite",
                column: "HaveAnyWeaponCategorySpecificProficiencyPrerequisite_RequiredP~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveAnyWeaponGroupSpecificProficiencyPrere~",
                table: "BasePrerequisite",
                column: "HaveAnyWeaponGroupSpecificProficiencyPrerequisite_RequiredProf~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveCurrentWeaponProficiencyPrerequisite_R~",
                table: "BasePrerequisite",
                column: "HaveCurrentWeaponProficiencyPrerequisite_RequiredProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveFavoredWeaponSpecificProficiencyPrereq~",
                table: "BasePrerequisite",
                column: "HaveFavoredWeaponSpecificProficiencyPrerequisite_RequiredProfi~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificAlignmentPrerequisite_Required~",
                table: "BasePrerequisite",
                column: "HaveSpecificAlignmentPrerequisite_RequiredAlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificArmorCategorySpecificProficie~1",
                table: "BasePrerequisite",
                column: "HaveSpecificArmorCategorySpecificProficiencyPrerequisite_Requi~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificArmorCategorySpecificProficien~",
                table: "BasePrerequisite",
                column: "HaveSpecificArmorCategorySpecificProficiencyPrerequisite_Armor~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificDecipherWritingProficiencyPrer~",
                table: "BasePrerequisite",
                column: "HaveSpecificDecipherWritingProficiencyPrerequisite_RequiredPro~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificDivineFontPrerequisite_Require~",
                table: "BasePrerequisite",
                column: "HaveSpecificDivineFontPrerequisite_RequiredDivineFontId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificLoreSpecificProficiencyPrerequ~",
                table: "BasePrerequisite",
                column: "HaveSpecificLoreSpecificProficiencyPrerequisite_RequiredProfic~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificMagicTraditionPrerequisite_Req~",
                table: "BasePrerequisite",
                column: "HaveSpecificMagicTraditionPrerequisite_RequiredMagicTraditionId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificMeleeWeaponSpecificProficiency~",
                table: "BasePrerequisite",
                column: "HaveSpecificMeleeWeaponSpecificProficiencyPrerequisite_Require~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificRangedWeaponSpecificProficienc~",
                table: "BasePrerequisite",
                column: "HaveSpecificRangedWeaponSpecificProficiencyPrerequisite_Requir~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificRecallKnowledgeProficiencyPrer~",
                table: "BasePrerequisite",
                column: "HaveSpecificRecallKnowledgeProficiencyPrerequisite_RequiredPro~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificSavingThrowSpecificProficiency~",
                table: "BasePrerequisite",
                column: "HaveSpecificSavingThrowSpecificProficiencyPrerequisite_Require~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificSkillProficiencyPrerequisite_R~",
                table: "BasePrerequisite",
                column: "HaveSpecificSkillProficiencyPrerequisite_RequiredProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificSpellAttackProficiencyPrerequi~",
                table: "BasePrerequisite",
                column: "HaveSpecificSpellAttackProficiencyPrerequisite_RequiredProfici~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificSpellDcProficiencyPrerequisite~",
                table: "BasePrerequisite",
                column: "HaveSpecificSpellDcProficiencyPrerequisite_RequiredProficiency~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificTraitPrerequisite_RequiredTrai~",
                table: "BasePrerequisite",
                column: "HaveSpecificTraitPrerequisite_RequiredTraitId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificWeaponCategorySpecificProfici~1",
                table: "BasePrerequisite",
                column: "HaveSpecificWeaponCategorySpecificProficiencyPrerequisite_Req~1");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificWeaponCategorySpecificProficie~",
                table: "BasePrerequisite",
                column: "HaveSpecificWeaponCategorySpecificProficiencyPrerequisite_Requ~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_HaveSpecificWeaponGroupSpecificProficiency~",
                table: "BasePrerequisite",
                column: "HaveSpecificWeaponGroupSpecificProficiencyPrerequisite_Require~");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_InnovationId",
                table: "BasePrerequisite",
                column: "InnovationId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_LanguageId",
                table: "BasePrerequisite",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredAlignmentId",
                table: "BasePrerequisite",
                column: "RequiredAlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredAncestryId",
                table: "BasePrerequisite",
                column: "RequiredAncestryId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredBloodlineId",
                table: "BasePrerequisite",
                column: "RequiredBloodlineId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredBloodlineMagicTraditionId",
                table: "BasePrerequisite",
                column: "RequiredBloodlineMagicTraditionId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredCauseId",
                table: "BasePrerequisite",
                column: "RequiredCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredClassFeatureId",
                table: "BasePrerequisite",
                column: "RequiredClassFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredClassId",
                table: "BasePrerequisite",
                column: "RequiredClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredDeityId",
                table: "BasePrerequisite",
                column: "RequiredDeityId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredDivineAllyId",
                table: "BasePrerequisite",
                column: "RequiredDivineAllyId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredDivineFontId",
                table: "BasePrerequisite",
                column: "RequiredDivineFontId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredDomainId",
                table: "BasePrerequisite",
                column: "RequiredDomainId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredDraconicExemplarId",
                table: "BasePrerequisite",
                column: "RequiredDraconicExemplarId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredDruidicOrderId",
                table: "BasePrerequisite",
                column: "RequiredDruidicOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredFeatId",
                table: "BasePrerequisite",
                column: "RequiredFeatId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredGunsinglersWayId",
                table: "BasePrerequisite",
                column: "RequiredGunsinglersWayId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredHeritageId",
                table: "BasePrerequisite",
                column: "RequiredHeritageId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredHybridStudyId",
                table: "BasePrerequisite",
                column: "RequiredHybridStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredInstinctId",
                table: "BasePrerequisite",
                column: "RequiredInstinctId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredLoreId",
                table: "BasePrerequisite",
                column: "RequiredLoreId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredMagicSchoolId",
                table: "BasePrerequisite",
                column: "RequiredMagicSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredMagicTraditionId",
                table: "BasePrerequisite",
                column: "RequiredMagicTraditionId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredMeleeWeaponId",
                table: "BasePrerequisite",
                column: "RequiredMeleeWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredMethodologyId",
                table: "BasePrerequisite",
                column: "RequiredMethodologyId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredMuseId",
                table: "BasePrerequisite",
                column: "RequiredMuseId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredPhilosophyId",
                table: "BasePrerequisite",
                column: "RequiredPhilosophyId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredProficiencyId",
                table: "BasePrerequisite",
                column: "RequiredProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredRacketId",
                table: "BasePrerequisite",
                column: "RequiredRacketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredRangedWeaponId",
                table: "BasePrerequisite",
                column: "RequiredRangedWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredSavingThrowStatId",
                table: "BasePrerequisite",
                column: "RequiredSavingThrowStatId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredSenseAccuracyId",
                table: "BasePrerequisite",
                column: "RequiredSenseAccuracyId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredSenseId",
                table: "BasePrerequisite",
                column: "RequiredSenseId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredSizeId",
                table: "BasePrerequisite",
                column: "RequiredSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredSkillId",
                table: "BasePrerequisite",
                column: "RequiredSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredSpellId",
                table: "BasePrerequisite",
                column: "RequiredSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredStatId",
                table: "BasePrerequisite",
                column: "RequiredStatId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredTennetId",
                table: "BasePrerequisite",
                column: "RequiredTennetId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredTraitId",
                table: "BasePrerequisite",
                column: "RequiredTraitId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredUnarmedWeaponId",
                table: "BasePrerequisite",
                column: "RequiredUnarmedWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredWeaponCategoryId",
                table: "BasePrerequisite",
                column: "RequiredWeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_RequiredWeaponGroupId",
                table: "BasePrerequisite",
                column: "RequiredWeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_WeaponCategoryId",
                table: "BasePrerequisite",
                column: "WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisite_WorshipSpecificDeityPrerequisite_RequiredD~",
                table: "BasePrerequisite",
                column: "WorshipSpecificDeityPrerequisite_RequiredDeityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_AdvancedBloodlineSpellId",
                table: "Bloodlines",
                column: "AdvancedBloodlineSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_EffectId",
                table: "Bloodlines",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_GreaterBloodlineSpellId",
                table: "Bloodlines",
                column: "GreaterBloodlineSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_InitialBloodlineSpellId",
                table: "Bloodlines",
                column: "InitialBloodlineSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_RarityId",
                table: "Bloodlines",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_SearchVector",
                table: "Bloodlines",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_SourcePageId",
                table: "Bloodlines",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_SpellListTraditionId",
                table: "Bloodlines",
                column: "SpellListTraditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_Details_OwnerId",
                table: "Bloodlines_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_Details_SearchVector",
                table: "Bloodlines_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_TypeChoiceDetails_OwnerId",
                table: "Bloodlines_TypeChoiceDetails",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bloodlines_TypeChoiceDetails_SearchVector",
                table: "Bloodlines_TypeChoiceDetails",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_BloodlineSkill_BloodlinesId",
                table: "BloodlineSkill",
                column: "BloodlinesId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanEffectBinding_BooleanEffectId",
                table: "BooleanEffectBinding",
                column: "BooleanEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanEffectBinding_EffectId",
                table: "BooleanEffectBinding",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanPrerequisiteBinding_BooleanPrerequisiteId",
                table: "BooleanPrerequisiteBinding",
                column: "BooleanPrerequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanPrerequisiteBinding_PrerequisiteId",
                table: "BooleanPrerequisiteBinding",
                column: "PrerequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Causes_AlignmentId",
                table: "Causes",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Causes_ClassId",
                table: "Causes",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Causes_EffectId",
                table: "Causes",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Causes_SearchVector",
                table: "Causes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Causes_SourcePageId",
                table: "Causes",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Causes_Details_OwnerId",
                table: "Causes_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Causes_Details_SearchVector",
                table: "Causes_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Cell_RowId",
                table: "Cell",
                column: "RowId");

            migrationBuilder.CreateIndex(
                name: "IX_Choice_StatId",
                table: "Choice",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChoiceEffectBinding_ChoiceEffectId",
                table: "ChoiceEffectBinding",
                column: "ChoiceEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_ChoiceEffectBinding_EffectId",
                table: "ChoiceEffectBinding",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCharacteristic_ClassId",
                table: "ClassCharacteristic",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_AdvancedWeaponProficiencyId",
                table: "Classes",
                column: "AdvancedWeaponProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassDcProficiencyId",
                table: "Classes",
                column: "ClassDcProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_FortitudeProficiencyId",
                table: "Classes",
                column: "FortitudeProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_HeavyArmorProficiencyId",
                table: "Classes",
                column: "HeavyArmorProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_LightArmorProficiencyId",
                table: "Classes",
                column: "LightArmorProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_MartialWeaponProficiencyId",
                table: "Classes",
                column: "MartialWeaponProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_MediumArmorProficiencyId",
                table: "Classes",
                column: "MediumArmorProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_PerceptionProficiencyId",
                table: "Classes",
                column: "PerceptionProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_PredefinedMagicTraditionId",
                table: "Classes",
                column: "PredefinedMagicTraditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ReflexProficiencyId",
                table: "Classes",
                column: "ReflexProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SearchVector",
                table: "Classes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SimpleWeaponProficiencyId",
                table: "Classes",
                column: "SimpleWeaponProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SpellAttackProficiencyId",
                table: "Classes",
                column: "SpellAttackProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SpellDcProficiencyId",
                table: "Classes",
                column: "SpellDcProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UnarmedWeaponProficiencyId",
                table: "Classes",
                column: "UnarmedWeaponProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UnarmoredProficiencyId",
                table: "Classes",
                column: "UnarmoredProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_WillProficiencyId",
                table: "Classes",
                column: "WillProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassFeatureBinding_ClassFeatureId",
                table: "ClassFeatureBinding",
                column: "ClassFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassFeatureBinding_ClassId",
                table: "ClassFeatureBinding",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassFeatures_EffectId",
                table: "ClassFeatures",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassFeatures_SearchVector",
                table: "ClassFeatures",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ClassFeatures_SourcePageId",
                table: "ClassFeatures",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassFeatures_Details_OwnerId",
                table: "ClassFeatures_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassFeatures_Details_SearchVector",
                table: "ClassFeatures_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ClassMannerism_ClassId",
                table: "ClassMannerism",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStat_KeyAbilityClassesId",
                table: "ClassStat",
                column: "KeyAbilityClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_Column_TableId",
                table: "Column",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_CombinationWeaponComponent_CombinationWeaponRangedComponen~1",
                table: "CombinationWeaponComponent",
                column: "CombinationWeaponRangedComponent_WeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CombinationWeaponComponent_CombinationWeaponRangedComponent~",
                table: "CombinationWeaponComponent",
                column: "CombinationWeaponRangedComponent_DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CombinationWeaponComponent_DamageTypeId",
                table: "CombinationWeaponComponent",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CombinationWeaponComponent_WeaponGroupId",
                table: "CombinationWeaponComponent",
                column: "WeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CombinationWeaponComponentTraitBinding_OwnerId",
                table: "CombinationWeaponComponentTraitBinding",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CombinationWeaponComponentTraitBinding_TraitId",
                table: "CombinationWeaponComponentTraitBinding",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionCategories_SearchVector",
                table: "ConditionCategories",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_ConditionCategoryId",
                table: "Conditions",
                column: "ConditionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_OverridesConditionId",
                table: "Conditions",
                column: "OverridesConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_SearchVector",
                table: "Conditions",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_SourcePageId",
                table: "Conditions",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_Details_OwnerId",
                table: "Conditions_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_Details_SearchVector",
                table: "Conditions_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Creature_AlignmentId",
                table: "Creature",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Creature_AncestryId",
                table: "Creature",
                column: "AncestryId");

            migrationBuilder.CreateIndex(
                name: "IX_Creature_RarityId",
                table: "Creature",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_Creature_RecallKnowledgeId",
                table: "Creature",
                column: "RecallKnowledgeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Creature_SearchVector",
                table: "Creature",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Creature_SizeId",
                table: "Creature",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Creature_SourcePageId",
                table: "Creature",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Creature_Details_OwnerId",
                table: "Creature_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Creature_Details_SearchVector",
                table: "Creature_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureFlavor_CreatureId",
                table: "CreatureFlavor",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureFlavor_Details_OwnerId",
                table: "CreatureFlavor_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureFlavor_Details_SearchVector",
                table: "CreatureFlavor_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureImmunity_ImmunitiesId",
                table: "CreatureImmunity",
                column: "ImmunitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureLanguage_LanguagesId",
                table: "CreatureLanguage",
                column: "LanguagesId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureRecallKnowledge_SkillId",
                table: "CreatureRecallKnowledge",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureSense_CreatureId",
                table: "CreatureSense",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureSense_SenseId",
                table: "CreatureSense",
                column: "SenseId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureSkill_CreatureId",
                table: "CreatureSkill",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureSkill_SkillId",
                table: "CreatureSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureSpell_SummonedById",
                table: "CreatureSpell",
                column: "SummonedById");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureTrait_TraitsId",
                table: "CreatureTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Curses_SavingThrowStatId",
                table: "Curses",
                column: "SavingThrowStatId");

            migrationBuilder.CreateIndex(
                name: "IX_Curses_SearchVector",
                table: "Curses",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Curses_SourcePageId",
                table: "Curses",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Curses_Details_OwnerId",
                table: "Curses_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Curses_Details_SearchVector",
                table: "Curses_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_CurseTrait_TraitsId",
                table: "CurseTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_DamageTypes_SearchVector",
                table: "DamageTypes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_AlignmentId",
                table: "Deities",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_CategoryId",
                table: "Deities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_DevoteeEffectId",
                table: "Deities",
                column: "DevoteeEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_DivineIntercessionId",
                table: "Deities",
                column: "DivineIntercessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_SearchVector",
                table: "Deities",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_SourcePageId",
                table: "Deities",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_Details_OwnerId",
                table: "Deities_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_Details_SearchVector",
                table: "Deities_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_DeityCategories_SearchVector",
                table: "DeityCategories",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_DeityDivineFont_DivineFontsId",
                table: "DeityDivineFont",
                column: "DivineFontsId");

            migrationBuilder.CreateIndex(
                name: "IX_DeityDomain_DomainsId",
                table: "DeityDomain",
                column: "DomainsId");

            migrationBuilder.CreateIndex(
                name: "IX_DeityMeleeWeapon_FavoredMeleeWeaponsId",
                table: "DeityMeleeWeapon",
                column: "FavoredMeleeWeaponsId");

            migrationBuilder.CreateIndex(
                name: "IX_DeityRangedWeapon_FavoredRangedWeaponId",
                table: "DeityRangedWeapon",
                column: "FavoredRangedWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_DeitySkill_DivineSkillsId",
                table: "DeitySkill",
                column: "DivineSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_DeityStat_DivineStatsId",
                table: "DeityStat",
                column: "DivineStatsId");

            migrationBuilder.CreateIndex(
                name: "IX_DeityUnarmedWeapon_FavoredUnarmedWeaponId",
                table: "DeityUnarmedWeapon",
                column: "FavoredUnarmedWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_SavingThrowStatId",
                table: "Diseases",
                column: "SavingThrowStatId");

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_SearchVector",
                table: "Diseases",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_SourcePageId",
                table: "Diseases",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseStage_DiseaseId",
                table: "DiseaseStage",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseStageEffect_ConditionId",
                table: "DiseaseStageEffect",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseStageEffect_DamageTypeId",
                table: "DiseaseStageEffect",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseStageEffect_DiseaseStageId",
                table: "DiseaseStageEffect",
                column: "DiseaseStageId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseTrait_TraitsId",
                table: "DiseaseTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_DivineAllies_SearchVector",
                table: "DivineAllies",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_DivineAllies_SourcePageId",
                table: "DivineAllies",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_DivineFonts_SearchVector",
                table: "DivineFonts",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_DivineIntercession_SourcePageId",
                table: "DivineIntercession",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctrines_EffectId",
                table: "Doctrines",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctrines_SearchVector",
                table: "Doctrines",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Doctrines_SourcePageId",
                table: "Doctrines",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_DomainMystery_RelatedDomainsId",
                table: "DomainMystery",
                column: "RelatedDomainsId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_SearchVector",
                table: "Domains",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_DraconicExemplars_DamageTypeId",
                table: "DraconicExemplars",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DraconicExemplars_EffectShapeId",
                table: "DraconicExemplars",
                column: "EffectShapeId");

            migrationBuilder.CreateIndex(
                name: "IX_DraconicExemplars_SavingThrowStatId",
                table: "DraconicExemplars",
                column: "SavingThrowStatId");

            migrationBuilder.CreateIndex(
                name: "IX_DraconicExemplars_SearchVector",
                table: "DraconicExemplars",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_DraconicExemplars_SourcePageId",
                table: "DraconicExemplars",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_DruidicOrders_EffectId",
                table: "DruidicOrders",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_DruidicOrders_SearchVector",
                table: "DruidicOrders",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_DruidicOrders_SourcePageId",
                table: "DruidicOrders",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_EffectIncrement_EffectId",
                table: "EffectIncrement",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_EffectIncrement_ProficiencyId",
                table: "EffectIncrement",
                column: "ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_EffectIncrement_TriggerId",
                table: "EffectIncrement",
                column: "TriggerId");

            migrationBuilder.CreateIndex(
                name: "IX_EffectIncrement_WeaponCategoryId",
                table: "EffectIncrement",
                column: "WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EffectIncrementTrigger_ProficiencyId",
                table: "EffectIncrementTrigger",
                column: "ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_EffectIncrementTrigger_SkillId",
                table: "EffectIncrementTrigger",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_EffectShape_SearchVector",
                table: "EffectShape",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonAbility_EffectId",
                table: "EidolonAbility",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonAbility_EidolonId",
                table: "EidolonAbility",
                column: "EidolonId");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonAbility_SearchVector",
                table: "EidolonAbility",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonAbility_Details_OwnerId",
                table: "EidolonAbility_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonAbility_Details_SearchVector",
                table: "EidolonAbility_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonHomePlane_EidolonId",
                table: "EidolonHomePlane",
                column: "EidolonId");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonHomePlane_PlaneId",
                table: "EidolonHomePlane",
                column: "PlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonHomePlane_PrerequisiteId",
                table: "EidolonHomePlane",
                column: "PrerequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Eidolons_EffectId",
                table: "Eidolons",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Eidolons_LanguageId",
                table: "Eidolons",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Eidolons_MagicTraditionId",
                table: "Eidolons",
                column: "MagicTraditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Eidolons_SearchVector",
                table: "Eidolons",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Eidolons_SourcePageId",
                table: "Eidolons",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonSense_SensesId",
                table: "EidolonSense",
                column: "SensesId");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonSkill_SkillsId",
                table: "EidolonSkill",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonTrait_TraitsId",
                table: "EidolonTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonVariant_EidolonId",
                table: "EidolonVariant",
                column: "EidolonId");

            migrationBuilder.CreateIndex(
                name: "IX_EidolonVariant_SearchVector",
                table: "EidolonVariant",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_FamiliarAbilities_SearchVector",
                table: "FamiliarAbilities",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_FamiliarAbilities_SourcePageId",
                table: "FamiliarAbilities",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatRequirement_FeatId",
                table: "FeatRequirement",
                column: "FeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_ActionTypeId",
                table: "Feats",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_ArchetypeId",
                table: "Feats",
                column: "ArchetypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_EffectId",
                table: "Feats",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_PrerequisiteId",
                table: "Feats",
                column: "PrerequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_RollableEffectId",
                table: "Feats",
                column: "RollableEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_SearchVector",
                table: "Feats",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_SourcePageId",
                table: "Feats",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_Details_OwnerId",
                table: "Feats_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_Details_SearchVector",
                table: "Feats_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_FeatTrait_TraitsId",
                table: "FeatTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_GunslingersWays_AdvancedDeedId",
                table: "GunslingersWays",
                column: "AdvancedDeedId");

            migrationBuilder.CreateIndex(
                name: "IX_GunslingersWays_EffectId",
                table: "GunslingersWays",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_GunslingersWays_GreaterDeedId",
                table: "GunslingersWays",
                column: "GreaterDeedId");

            migrationBuilder.CreateIndex(
                name: "IX_GunslingersWays_InitialDeedId",
                table: "GunslingersWays",
                column: "InitialDeedId");

            migrationBuilder.CreateIndex(
                name: "IX_GunslingersWays_PrerequisiteId",
                table: "GunslingersWays",
                column: "PrerequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_GunslingersWays_SearchVector",
                table: "GunslingersWays",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_GunslingersWays_SlingersReloadId",
                table: "GunslingersWays",
                column: "SlingersReloadId");

            migrationBuilder.CreateIndex(
                name: "IX_GunslingersWays_SourcePageId",
                table: "GunslingersWays",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_GunslingersWays_Details_OwnerId",
                table: "GunslingersWays_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_GunslingersWays_Details_SearchVector",
                table: "GunslingersWays_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_GunslingersWaySkill_WaySkillIdOptionsId",
                table: "GunslingersWaySkill",
                column: "WaySkillIdOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_HarrowCards_AlignmentId",
                table: "HarrowCards",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HarrowCards_HarrowCategoryId",
                table: "HarrowCards",
                column: "HarrowCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HarrowCards_SearchVector",
                table: "HarrowCards",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_HarrowCategories_AffectedStatId",
                table: "HarrowCategories",
                column: "AffectedStatId");

            migrationBuilder.CreateIndex(
                name: "IX_HarrowCategories_SearchVector",
                table: "HarrowCategories",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_HarrowModes_SearchVector",
                table: "HarrowModes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_HazardComplexities_SearchVector",
                table: "HazardComplexities",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_HazardComponent_HazardId",
                table: "HazardComponent",
                column: "HazardId");

            migrationBuilder.CreateIndex(
                name: "IX_HazardDetectionRequirement_HazardId",
                table: "HazardDetectionRequirement",
                column: "HazardId");

            migrationBuilder.CreateIndex(
                name: "IX_HazardDetectionRequirement_RequiredProficiencyId",
                table: "HazardDetectionRequirement",
                column: "RequiredProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_HazardDisableRequirement_HazardId",
                table: "HazardDisableRequirement",
                column: "HazardId");

            migrationBuilder.CreateIndex(
                name: "IX_HazardDisableRequirement_RequiredProficiencyId",
                table: "HazardDisableRequirement",
                column: "RequiredProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_HazardDisableRequirement_SkillId",
                table: "HazardDisableRequirement",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_HazardDispellRequirement_HazardId",
                table: "HazardDispellRequirement",
                column: "HazardId");

            migrationBuilder.CreateIndex(
                name: "IX_HazardImmunity_ImmunitiesId",
                table: "HazardImmunity",
                column: "ImmunitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Hazards_ComplexityId",
                table: "Hazards",
                column: "ComplexityId");

            migrationBuilder.CreateIndex(
                name: "IX_Hazards_SearchVector",
                table: "Hazards",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Hazards_SourcePageId",
                table: "Hazards",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Hazards_TypeId",
                table: "Hazards",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Hazards_RoutineDetails_OwnerId",
                table: "Hazards_RoutineDetails",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Hazards_RoutineDetails_SearchVector",
                table: "Hazards_RoutineDetails",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_HazardTrait_TraitsId",
                table: "HazardTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_HazardTypes_SearchVector",
                table: "HazardTypes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_HazardTypes_SourcePageId",
                table: "HazardTypes",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Heritages_EffectId",
                table: "Heritages",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Heritages_RarityId",
                table: "Heritages",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_Heritages_SearchVector",
                table: "Heritages",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Heritages_SourcePageId",
                table: "Heritages",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Heritages_Details_OwnerId",
                table: "Heritages_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Heritages_Details_SearchVector",
                table: "Heritages_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_HuntersEdges_EffectId",
                table: "HuntersEdges",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntersEdges_SearchVector",
                table: "HuntersEdges",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_HuntersEdges_SourcePageId",
                table: "HuntersEdges",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_HybridStudies_ConfluxSpellId",
                table: "HybridStudies",
                column: "ConfluxSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_HybridStudies_EffectId",
                table: "HybridStudies",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_HybridStudies_EleventhSpellId",
                table: "HybridStudies",
                column: "EleventhSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_HybridStudies_SearchVector",
                table: "HybridStudies",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_HybridStudies_SeventhSpellId",
                table: "HybridStudies",
                column: "SeventhSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_HybridStudies_SourcePageId",
                table: "HybridStudies",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_HybridStudies_ThirteenthSpellId",
                table: "HybridStudies",
                column: "ThirteenthSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_HybridStudies_Details_OwnerId",
                table: "HybridStudies_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_HybridStudies_Details_SearchVector",
                table: "HybridStudies_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAction_ActionTypeId",
                table: "InlineAction",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAction_BaseItemId",
                table: "InlineAction",
                column: "BaseItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAction_BaseItemVariantId",
                table: "InlineAction",
                column: "BaseItemVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAction_HazardId",
                table: "InlineAction",
                column: "HazardId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAction_RollableEffectId",
                table: "InlineAction",
                column: "RollableEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAction_SpellId",
                table: "InlineAction",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAction_StaggeredEffectId",
                table: "InlineAction",
                column: "StaggeredEffectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InlineAction_UtilityGearId",
                table: "InlineAction",
                column: "UtilityGearId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAction_Effect_OwnerId",
                table: "InlineAction_Effect",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAction_Effect_SearchVector",
                table: "InlineAction_Effect",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_InlineActionTraitBinding_OwnerId",
                table: "InlineActionTraitBinding",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineActionTraitBinding_TraitId",
                table: "InlineActionTraitBinding",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAttack_ActionTypeId",
                table: "InlineAttack",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAttack_AttackTypeId",
                table: "InlineAttack",
                column: "AttackTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAttack_DamageTypeId",
                table: "InlineAttack",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAttack_HazardId",
                table: "InlineAttack",
                column: "HazardId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAttack_StaggeredEffectId",
                table: "InlineAttack",
                column: "StaggeredEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAttack_Effect_OwnerId",
                table: "InlineAttack_Effect",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAttack_Effect_SearchVector",
                table: "InlineAttack_Effect",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAttackTraitBinding_OwnerId",
                table: "InlineAttackTraitBinding",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_InlineAttackTraitBinding_TraitId",
                table: "InlineAttackTraitBinding",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_InnovationModifications_EffectId",
                table: "InnovationModifications",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_InnovationModifications_InnovationId",
                table: "InnovationModifications",
                column: "InnovationId");

            migrationBuilder.CreateIndex(
                name: "IX_InnovationModifications_PrerequisiteId",
                table: "InnovationModifications",
                column: "PrerequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_InnovationModifications_SearchVector",
                table: "InnovationModifications",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_InnovationModifications_SourcePageId",
                table: "InnovationModifications",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_InnovationModifications_TypeId",
                table: "InnovationModifications",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InnovationModificationTypes_SearchVector",
                table: "InnovationModificationTypes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_EffectId",
                table: "Innovations",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_SearchVector",
                table: "Innovations",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_SourcePageId",
                table: "Innovations",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_TableId",
                table: "Innovations",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_Details_OwnerId",
                table: "Innovations_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_Details_SearchVector",
                table: "Innovations_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_InstinctAbilities_SearchVector",
                table: "InstinctAbilities",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_InstinctAbilities_SourcePageId",
                table: "InstinctAbilities",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_InstinctAbilities_TableId",
                table: "InstinctAbilities",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Instincts_ClassId",
                table: "Instincts",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Instincts_InstinctAbilityEffectId",
                table: "Instincts",
                column: "InstinctAbilityEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Instincts_RagingEffectId",
                table: "Instincts",
                column: "RagingEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Instincts_SearchVector",
                table: "Instincts",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Instincts_SourcePageId",
                table: "Instincts",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Instincts_TableId",
                table: "Instincts",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategories_SearchVector",
                table: "ItemCategories",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCurses_SearchVector",
                table: "ItemCurses",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCurses_SourcePageId",
                table: "ItemCurses",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCurses_Details_OwnerId",
                table: "ItemCurses_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCurses_Details_SearchVector",
                table: "ItemCurses_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCurseTrait_TraitsId",
                table: "ItemCurseTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AlchemicalElixir_TraitId",
                table: "Items",
                column: "AlchemicalElixir_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AlchemicalPoison_TraitId",
                table: "Items",
                column: "AlchemicalPoison_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AlchemicalTool_TraitId",
                table: "Items",
                column: "AlchemicalTool_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AlignmentId",
                table: "Items",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Armor_TraitId",
                table: "Items",
                column: "Armor_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ArmorCategoryId",
                table: "Items",
                column: "ArmorCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ArmorGroupId",
                table: "Items",
                column: "ArmorGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ArmorPropertyRune_TraitId",
                table: "Items",
                column: "ArmorPropertyRune_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Artifact_TraitId",
                table: "Items",
                column: "Artifact_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_BeastGun_TraitId",
                table: "Items",
                column: "BeastGun_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_BeastGun_WeaponGroupId",
                table: "Items",
                column: "BeastGun_WeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CombinationWeapon_TraitId",
                table: "Items",
                column: "CombinationWeapon_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CombinationWeapon_WeaponCategoryId",
                table: "Items",
                column: "CombinationWeapon_WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_FundamentalArmorRune_TraitId",
                table: "Items",
                column: "FundamentalArmorRune_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_FundamentalWeaponRune_TraitId",
                table: "Items",
                column: "FundamentalWeaponRune_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_MeleeWeapon_TraitId",
                table: "Items",
                column: "MeleeWeapon_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_MeleeWeapon_WeaponCategoryId",
                table: "Items",
                column: "MeleeWeapon_WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_MeleeWeapon_WeaponGroupId",
                table: "Items",
                column: "MeleeWeapon_WeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_RangedWeapon_TraitId",
                table: "Items",
                column: "RangedWeapon_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_RangedWeapon_WeaponCategoryId",
                table: "Items",
                column: "RangedWeapon_WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_RangedWeapon_WeaponGroupId",
                table: "Items",
                column: "RangedWeapon_WeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SourcePageId",
                table: "Items",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Stave_TraitId",
                table: "Items",
                column: "Stave_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_TableId",
                table: "Items",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_TraitId",
                table: "Items",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_WeaponCategoryId",
                table: "Items",
                column: "WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_WeaponGroupId",
                table: "Items",
                column: "WeaponGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_WeaponPropertyRune_TraitId",
                table: "Items",
                column: "WeaponPropertyRune_TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Details_OwnerId",
                table: "Items_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Details_SearchVector",
                table: "Items_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_SearchVector",
                table: "Languages",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_TypeId",
                table: "Languages",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTypes_SearchVector",
                table: "LanguageTypes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_LoreCategories_SearchVector",
                table: "LoreCategories",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_LoreCategories_StatModifierId",
                table: "LoreCategories",
                column: "StatModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_Lores_SearchVector",
                table: "Lores",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Lores_StatModifierId",
                table: "Lores",
                column: "StatModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicEssences_SearchVector",
                table: "MagicEssences",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_MagicSchools_SearchVector",
                table: "MagicSchools",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_MagicTraditions_SearchVector",
                table: "MagicTraditions",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_MagicTraditionSpell_TraditionsId",
                table: "MagicTraditionSpell",
                column: "TraditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterAbilities_SearchVector",
                table: "MasterAbilities",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_MasterAbilities_SourcePageId",
                table: "MasterAbilities",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Methodologies_EffectId",
                table: "Methodologies",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Methodologies_SearchVector",
                table: "Methodologies",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Methodologies_SourcePageId",
                table: "Methodologies",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Methodologies_Details_OwnerId",
                table: "Methodologies_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Methodologies_Details_SearchVector",
                table: "Methodologies_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Muses_EffectId",
                table: "Muses",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Muses_SearchVector",
                table: "Muses",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Muses_SourcePageId",
                table: "Muses",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_AdvancedRevelationId",
                table: "Mysteries",
                column: "AdvancedRevelationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_EffectId",
                table: "Mysteries",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_GrantedCantripId",
                table: "Mysteries",
                column: "GrantedCantripId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_GreaterRevelationId",
                table: "Mysteries",
                column: "GreaterRevelationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_InitialRevelationId",
                table: "Mysteries",
                column: "InitialRevelationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_MysteryCurseId",
                table: "Mysteries",
                column: "MysteryCurseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_SearchVector",
                table: "Mysteries",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_SourcePageId",
                table: "Mysteries",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_TrainedSkillId",
                table: "Mysteries",
                column: "TrainedSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_Details_OwnerId",
                table: "Mysteries_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_Details_SearchVector",
                table: "Mysteries_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_MysteryBenefits_OwnerId",
                table: "Mysteries_MysteryBenefits",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Mysteries_MysteryBenefits_SearchVector",
                table: "Mysteries_MysteryBenefits",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_MysteryCurse_SourcePageId",
                table: "MysteryCurse",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_MysteryCurse_TableId",
                table: "MysteryCurse",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_MysteryCurse_Details_OwnerId",
                table: "MysteryCurse_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_MysteryCurse_Details_SearchVector",
                table: "MysteryCurse_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_MysteryCursePotency_MysteryCurseId",
                table: "MysteryCursePotency",
                column: "MysteryCurseId");

            migrationBuilder.CreateIndex(
                name: "IX_MysteryCursePotency_PotencyId",
                table: "MysteryCursePotency",
                column: "PotencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MysteryCursePotency_Details_OwnerId",
                table: "MysteryCursePotency_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_MysteryCursePotency_Details_SearchVector",
                table: "MysteryCursePotency_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectGrade_SearchVector",
                table: "ObjectGrade",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PatronThemes_EffectId",
                table: "PatronThemes",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_PatronThemes_MagicTraditionId",
                table: "PatronThemes",
                column: "MagicTraditionId");

            migrationBuilder.CreateIndex(
                name: "IX_PatronThemes_PatronSkillId",
                table: "PatronThemes",
                column: "PatronSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_PatronThemes_RarityId",
                table: "PatronThemes",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_PatronThemes_SearchVector",
                table: "PatronThemes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PatronThemes_SourcePageId",
                table: "PatronThemes",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_PatronThemeSpell_PatronThemesId",
                table: "PatronThemeSpell",
                column: "PatronThemesId");

            migrationBuilder.CreateIndex(
                name: "IX_Philosophies_SearchVector",
                table: "Philosophies",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Philosophies_SourcePageId",
                table: "Philosophies",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Philosophies_Details_OwnerId",
                table: "Philosophies_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Philosophies_Details_SearchVector",
                table: "Philosophies_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PlaneCategories_SearchVector",
                table: "PlaneCategories",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_AlignmentId",
                table: "Planes",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_CategoryId",
                table: "Planes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_SearchVector",
                table: "Planes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_Details_OwnerId",
                table: "Planes_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_Details_SearchVector",
                table: "Planes_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PlaneTrait_TraitsId",
                table: "PlaneTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayModeSkillAction_SkillActionsId",
                table: "PlayModeSkillAction",
                column: "SkillActionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Potencies_SearchVector",
                table: "Potencies",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialArmors_SearchVector",
                table: "PreciousMaterialArmors",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialArmors_SourcePageId",
                table: "PreciousMaterialArmors",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialArmors_Details_OwnerId",
                table: "PreciousMaterialArmors_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialArmors_Details_SearchVector",
                table: "PreciousMaterialArmors_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialArmorTrait_TraitsId",
                table: "PreciousMaterialArmorTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialArmorVariant_ArmorId",
                table: "PreciousMaterialArmorVariant",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialArmorVariant_GradeId",
                table: "PreciousMaterialArmorVariant",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialItemCategories_SearchVector",
                table: "PreciousMaterialItemCategories",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialObjectInformation_CategoryId",
                table: "PreciousMaterialObjectInformation",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialObjectInformation_GradeId",
                table: "PreciousMaterialObjectInformation",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialObjectInformation_MaterialId",
                table: "PreciousMaterialObjectInformation",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterials_ArmorId",
                table: "PreciousMaterials",
                column: "ArmorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterials_SearchVector",
                table: "PreciousMaterials",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterials_ShieldId",
                table: "PreciousMaterials",
                column: "ShieldId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterials_SourcePageId",
                table: "PreciousMaterials",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterials_WeaponId",
                table: "PreciousMaterials",
                column: "WeaponId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterials_Details_OwnerId",
                table: "PreciousMaterials_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterials_Details_SearchVector",
                table: "PreciousMaterials_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialShields_SearchVector",
                table: "PreciousMaterialShields",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialShields_SourcePageId",
                table: "PreciousMaterialShields",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialShields_Details_OwnerId",
                table: "PreciousMaterialShields_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialShields_Details_SearchVector",
                table: "PreciousMaterialShields_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialShieldTrait_TraitsId",
                table: "PreciousMaterialShieldTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialShieldVariant_BulkId",
                table: "PreciousMaterialShieldVariant",
                column: "BulkId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialShieldVariant_GradeId",
                table: "PreciousMaterialShieldVariant",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialShieldVariant_ShieldId",
                table: "PreciousMaterialShieldVariant",
                column: "ShieldId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialTrait_TraitsId",
                table: "PreciousMaterialTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialWeapons_SearchVector",
                table: "PreciousMaterialWeapons",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialWeapons_SourcePageId",
                table: "PreciousMaterialWeapons",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialWeapons_Details_OwnerId",
                table: "PreciousMaterialWeapons_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialWeapons_Details_SearchVector",
                table: "PreciousMaterialWeapons_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialWeaponTrait_TraitsId",
                table: "PreciousMaterialWeaponTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialWeaponVariant_GradeId",
                table: "PreciousMaterialWeaponVariant",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_PreciousMaterialWeaponVariant_WeaponId",
                table: "PreciousMaterialWeaponVariant",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Proficiencies_SearchVector",
                table: "Proficiencies",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Rackets_EffectId",
                table: "Rackets",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Rackets_SearchVector",
                table: "Rackets",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Rackets_SourcePageId",
                table: "Rackets",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Rackets_Details_OwnerId",
                table: "Rackets_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rackets_Details_SearchVector",
                table: "Rackets_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Rarities_SearchVector",
                table: "Rarities",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchFields_EffectId",
                table: "ResearchFields",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchFields_SearchVector",
                table: "ResearchFields",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchFields_SourcePageId",
                table: "ResearchFields",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchFields_Details_OwnerId",
                table: "ResearchFields_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchFields_Details_SearchVector",
                table: "ResearchFields_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_RollableEffect_SearchVector",
                table: "RollableEffect",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_RollableEffect_SpellId",
                table: "RollableEffect",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Row_TableId",
                table: "Row",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_SearchVector",
                table: "Rules",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_SourcePageId",
                table: "Rules",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_Details_OwnerId",
                table: "Rules_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_Details_SearchVector",
                table: "Rules_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_RuneMagics_AdvancedRuneSpellId",
                table: "RuneMagics",
                column: "AdvancedRuneSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_RuneMagics_EffectId",
                table: "RuneMagics",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_RuneMagics_InitialRuneSpellId",
                table: "RuneMagics",
                column: "InitialRuneSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_RuneMagics_MagicSchoolId",
                table: "RuneMagics",
                column: "MagicSchoolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RuneMagics_SearchVector",
                table: "RuneMagics",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_RuneMagics_SourcePageId",
                table: "RuneMagics",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_RuneMagicSchoolBinding_MagicSchoolId",
                table: "RuneMagicSchoolBinding",
                column: "MagicSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_RuneMagicSchoolBinding_RuneMagicId",
                table: "RuneMagicSchoolBinding",
                column: "RuneMagicId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrowStats_SearchVector",
                table: "SavingThrowStats",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrowStats_Details_OwnerId",
                table: "SavingThrowStats_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrowStats_Details_SearchVector",
                table: "SavingThrowStats_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_SenseAccuracy_SearchVector",
                table: "SenseAccuracy",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_SenseAccuracy_SourcePageId",
                table: "SenseAccuracy",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Senses_SearchVector",
                table: "Senses",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Senses_SourcePageId",
                table: "Senses",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Senses_Details_OwnerId",
                table: "Senses_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Senses_Details_SearchVector",
                table: "Senses_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActionExample_ProficiencyId",
                table: "SkillActionExample",
                column: "ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActionExample_SkillActionId",
                table: "SkillActionExample",
                column: "SkillActionId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActions_ActionTypeId",
                table: "SkillActions",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActions_RequireProficiencyId",
                table: "SkillActions",
                column: "RequireProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActions_RollableEffectId",
                table: "SkillActions",
                column: "RollableEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActions_SearchVector",
                table: "SkillActions",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActions_SourcePageId",
                table: "SkillActions",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActions_TableId",
                table: "SkillActions",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActions_Details_OwnerId",
                table: "SkillActions_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActions_Details_SearchVector",
                table: "SkillActions_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActionTrait_TraitsId",
                table: "SkillActionTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillBenefit_BenefitTypeId",
                table: "SkillBenefit",
                column: "BenefitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillBenefit_SkillId",
                table: "SkillBenefit",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SearchVector",
                table: "Skills",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_StatModifierId",
                table: "Skills",
                column: "StatModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSkillAction_SkillsId",
                table: "SkillSkillAction",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_SourcePage_SourceId",
                table: "SourcePage",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Sources_SearchVector",
                table: "Sources",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_SpellComponents_SearchVector",
                table: "SpellComponents",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_SpellHeightening_SpellId",
                table: "SpellHeightening",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellHeightening_Details_OwnerId",
                table: "SpellHeightening_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellHeightening_Details_SearchVector",
                table: "SpellHeightening_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_ActionTypeId",
                table: "Spells",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_ClassId",
                table: "Spells",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_DomainId",
                table: "Spells",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_MagicSchoolId",
                table: "Spells",
                column: "MagicSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SavingThrowStatId",
                table: "Spells",
                column: "SavingThrowStatId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SearchVector",
                table: "Spells",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SourcePageId",
                table: "Spells",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SpellTypeId",
                table: "Spells",
                column: "SpellTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_StaggeredEffectId",
                table: "Spells",
                column: "StaggeredEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_TableId",
                table: "Spells",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_TraitId",
                table: "Spells",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_Details_OwnerId",
                table: "Spells_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_Details_SearchVector",
                table: "Spells_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_SpellSpellComponent_SpellsId",
                table: "SpellSpellComponent",
                column: "SpellsId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellTraitBinding_OwnerId",
                table: "SpellTraitBinding",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellTraitBinding_TraitId",
                table: "SpellTraitBinding",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellTypes_SearchVector",
                table: "SpellTypes",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_StaggeredEffect_SavingThrowStatId",
                table: "StaggeredEffect",
                column: "SavingThrowStatId");

            migrationBuilder.CreateIndex(
                name: "IX_StaggeredEffectStage_StaggeredEffectId",
                table: "StaggeredEffectStage",
                column: "StaggeredEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_StaggeredEffectStageEffect_ConditionId",
                table: "StaggeredEffectStageEffect",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_StaggeredEffectStageEffect_DamageTypeId",
                table: "StaggeredEffectStageEffect",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StaggeredEffectStageEffect_StaggeredEffectStageId",
                table: "StaggeredEffectStageEffect",
                column: "StaggeredEffectStageId");

            migrationBuilder.CreateIndex(
                name: "IX_StaggeredEffectTraitBinding_OwnerId",
                table: "StaggeredEffectTraitBinding",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_StaggeredEffectTraitBinding_TraitId",
                table: "StaggeredEffectTraitBinding",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_SearchVector",
                table: "Stats",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_StaveSpell_SpellId",
                table: "StaveSpell",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_StaveSpell_StaveVariantId",
                table: "StaveSpell",
                column: "StaveVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_SwashbucklersStyle_EffectId",
                table: "SwashbucklersStyle",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_SwashbucklersStyle_SearchVector",
                table: "SwashbucklersStyle",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_SwashbucklersStyle_SourcePageId",
                table: "SwashbucklersStyle",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenets_SearchVector",
                table: "Tenets",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Tenets_SourcePageId",
                table: "Tenets",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenets_Details_OwnerId",
                table: "Tenets_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenets_Details_SearchVector",
                table: "Tenets_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_SearchVector",
                table: "Traits",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_SourcePageId",
                table: "Traits",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_Details_OwnerId",
                table: "Traits_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_Details_SearchVector",
                table: "Traits_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_UnarmedWeapons_SearchVector",
                table: "UnarmedWeapons",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityGear_SearchVector",
                table: "UtilityGear",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityGear_SourcePageId",
                table: "UtilityGear",
                column: "SourcePageId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityGear_Details_OwnerId",
                table: "UtilityGear_Details",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityGear_Details_SearchVector",
                table: "UtilityGear_Details",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityGearTraitBinding_OwnerId",
                table: "UtilityGearTraitBinding",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityGearTraitBinding_TraitId",
                table: "UtilityGearTraitBinding",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityGearVariant_BulkId",
                table: "UtilityGearVariant",
                column: "BulkId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityGearVariant_RarityId",
                table: "UtilityGearVariant",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityGearVariant_UtilityGearId",
                table: "UtilityGearVariant",
                column: "UtilityGearId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityGearVariant_Addendum_OwnerId",
                table: "UtilityGearVariant_Addendum",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityGearVariant_Addendum_SearchVector",
                table: "UtilityGearVariant_Addendum",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponCategories_SearchVector",
                table: "WeaponCategories",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponGroups_SearchVector",
                table: "WeaponGroups",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponGroups_SourcePageId",
                table: "WeaponGroups",
                column: "SourcePageId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEffect_BasePrerequisite_PrerequisiteId",
                table: "BaseEffect",
                column: "PrerequisiteId",
                principalTable: "BasePrerequisite",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEffect_Causes_CauseId",
                table: "BaseEffect",
                column: "CauseId",
                principalTable: "Causes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEffect_Feats_DisableFeatPrerequisitesEffect_FeatId",
                table: "BaseEffect",
                column: "DisableFeatPrerequisitesEffect_FeatId",
                principalTable: "Feats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEffect_Feats_FeatId",
                table: "BaseEffect",
                column: "FeatId",
                principalTable: "Feats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEffect_Feats_GainSpecificFeatEffect_FeatId",
                table: "BaseEffect",
                column: "GainSpecificFeatEffect_FeatId",
                principalTable: "Feats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEffect_Feats_ModifyFeatEffectsEffect_FeatId",
                table: "BaseEffect",
                column: "ModifyFeatEffectsEffect_FeatId",
                principalTable: "Feats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEffect_Feats_ProhibitedFeatId",
                table: "BaseEffect",
                column: "ProhibitedFeatId",
                principalTable: "Feats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEffect_Heritages_HeritageId",
                table: "BaseEffect",
                column: "HeritageId",
                principalTable: "Heritages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEffect_Instincts_InstinctId",
                table: "BaseEffect",
                column: "InstinctId",
                principalTable: "Instincts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEffect_RuneMagics_RuneMagicId",
                table: "BaseEffect",
                column: "RuneMagicId",
                principalTable: "RuneMagics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_Archetypes_ArchetypeId",
                table: "Feats",
                column: "ArchetypeId",
                principalTable: "Archetypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_BasePrerequisite_PrerequisiteId",
                table: "Feats",
                column: "PrerequisiteId",
                principalTable: "BasePrerequisite",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasePrerequisite_GunslingersWays_RequiredGunsinglersWayId",
                table: "BasePrerequisite",
                column: "RequiredGunsinglersWayId",
                principalTable: "GunslingersWays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abilities_ActionTypes_ActionTypeId",
                table: "Abilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Actions_ActionTypes_ActionTypeId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_ActionTypes_ActionTypeId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillActions_ActionTypes_ActionTypeId",
                table: "SkillActions");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_ActionTypes_ActionTypeId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Abilities_RollableEffect_RollableEffectId",
                table: "Abilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Actions_RollableEffect_RollableEffectId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_RollableEffect_RollableEffectId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillActions_RollableEffect_RollableEffectId",
                table: "SkillActions");

            migrationBuilder.DropForeignKey(
                name: "FK_Abilities_SourcePage_SourcePageId",
                table: "Abilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Ancestries_SourcePage_SourcePageId",
                table: "Ancestries");

            migrationBuilder.DropForeignKey(
                name: "FK_Archetypes_SourcePage_SourcePageId",
                table: "Archetypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ArmorGroups_SourcePage_SourcePageId",
                table: "ArmorGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Bloodlines_SourcePage_SourcePageId",
                table: "Bloodlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Causes_SourcePage_SourcePageId",
                table: "Causes");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassFeatures_SourcePage_SourcePageId",
                table: "ClassFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Conditions_SourcePage_SourcePageId",
                table: "Conditions");

            migrationBuilder.DropForeignKey(
                name: "FK_Deities_SourcePage_SourcePageId",
                table: "Deities");

            migrationBuilder.DropForeignKey(
                name: "FK_DivineAllies_SourcePage_SourcePageId",
                table: "DivineAllies");

            migrationBuilder.DropForeignKey(
                name: "FK_DivineIntercession_SourcePage_SourcePageId",
                table: "DivineIntercession");

            migrationBuilder.DropForeignKey(
                name: "FK_DraconicExemplars_SourcePage_SourcePageId",
                table: "DraconicExemplars");

            migrationBuilder.DropForeignKey(
                name: "FK_DruidicOrders_SourcePage_SourcePageId",
                table: "DruidicOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_SourcePage_SourcePageId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_GunslingersWays_SourcePage_SourcePageId",
                table: "GunslingersWays");

            migrationBuilder.DropForeignKey(
                name: "FK_Heritages_SourcePage_SourcePageId",
                table: "Heritages");

            migrationBuilder.DropForeignKey(
                name: "FK_HybridStudies_SourcePage_SourcePageId",
                table: "HybridStudies");

            migrationBuilder.DropForeignKey(
                name: "FK_Innovations_SourcePage_SourcePageId",
                table: "Innovations");

            migrationBuilder.DropForeignKey(
                name: "FK_InstinctAbilities_SourcePage_SourcePageId",
                table: "InstinctAbilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Instincts_SourcePage_SourcePageId",
                table: "Instincts");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_SourcePage_SourcePageId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Methodologies_SourcePage_SourcePageId",
                table: "Methodologies");

            migrationBuilder.DropForeignKey(
                name: "FK_Muses_SourcePage_SourcePageId",
                table: "Muses");

            migrationBuilder.DropForeignKey(
                name: "FK_Philosophies_SourcePage_SourcePageId",
                table: "Philosophies");

            migrationBuilder.DropForeignKey(
                name: "FK_Rackets_SourcePage_SourcePageId",
                table: "Rackets");

            migrationBuilder.DropForeignKey(
                name: "FK_RuneMagics_SourcePage_SourcePageId",
                table: "RuneMagics");

            migrationBuilder.DropForeignKey(
                name: "FK_SenseAccuracy_SourcePage_SourcePageId",
                table: "SenseAccuracy");

            migrationBuilder.DropForeignKey(
                name: "FK_Senses_SourcePage_SourcePageId",
                table: "Senses");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillActions_SourcePage_SourcePageId",
                table: "SkillActions");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_SourcePage_SourcePageId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenets_SourcePage_SourcePageId",
                table: "Tenets");

            migrationBuilder.DropForeignKey(
                name: "FK_Traits_SourcePage_SourcePageId",
                table: "Traits");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponGroups_SourcePage_SourcePageId",
                table: "WeaponGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Abilities_AbilityId",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Traits_AncestryTraitId",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Traits_GainSpecificTraitAnySavingThrowCircumstan~",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Traits_GainSpecificTraitEffect_TraitId",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Traits_GainSpecificTraitFeatEffect_TraitId",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Traits_GainSpecificTraitSpellEffect_TraitId",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Traits_ImproveSpecificTraitAnySavingThrowEffect_~",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Traits_RequiredTraitId",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Traits_TraitId",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisite_Traits_HaveSpecificTraitPrerequisite_Requi~",
                table: "BasePrerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisite_Traits_RequiredTraitId",
                table: "BasePrerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_AlchemicalElixir_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_AlchemicalPoison_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_AlchemicalTool_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_Armor_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_ArmorPropertyRune_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_Artifact_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_BeastGun_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_CombinationWeapon_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_FundamentalArmorRune_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_FundamentalWeaponRune_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_MeleeWeapon_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_RangedWeapon_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_Stave_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Traits_WeaponPropertyRune_TraitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Traits_TraitId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Actions_ActionId",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Actions_GainSpecificActionCircumstanceBonusEffec~",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Actions_GainSpecificSkillSpecificActionCircumsta~",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEffect_Actions_GainSpecificSkillSpecificActionDcCircums~",
                table: "BaseEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisite_Alignments_HaveSpecificAlignmentPrerequisi~",
                table: "BasePrerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisite_Alignments_RequiredAlignmentId",
                table: "BasePrerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_Causes_Alignments_AlignmentId",
                table: "Causes");

            migrationBuilder.DropForeignKey(
                name: "FK_Deities_Alignments_AlignmentId",
                table: "Deities");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Alignments_AlignmentId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisite_Deities_RequiredDeityId",
                table: "BasePrerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisite_Deities_WorshipSpecificDeityPrerequisite_R~",
                table: "BasePrerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisite_Philosophies_RequiredPhilosophyId",
                table: "BasePrerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_Ancestries_BaseEffect_EffectId",
                table: "Ancestries");

            migrationBuilder.DropForeignKey(
                name: "FK_Bloodlines_BaseEffect_EffectId",
                table: "Bloodlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Causes_BaseEffect_EffectId",
                table: "Causes");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassFeatures_BaseEffect_EffectId",
                table: "ClassFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_DruidicOrders_BaseEffect_EffectId",
                table: "DruidicOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_BaseEffect_EffectId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_GunslingersWays_BaseEffect_EffectId",
                table: "GunslingersWays");

            migrationBuilder.DropForeignKey(
                name: "FK_Heritages_BaseEffect_EffectId",
                table: "Heritages");

            migrationBuilder.DropForeignKey(
                name: "FK_HybridStudies_BaseEffect_EffectId",
                table: "HybridStudies");

            migrationBuilder.DropForeignKey(
                name: "FK_Innovations_BaseEffect_EffectId",
                table: "Innovations");

            migrationBuilder.DropForeignKey(
                name: "FK_Instincts_BaseEffect_InstinctAbilityEffectId",
                table: "Instincts");

            migrationBuilder.DropForeignKey(
                name: "FK_Instincts_BaseEffect_RagingEffectId",
                table: "Instincts");

            migrationBuilder.DropForeignKey(
                name: "FK_Methodologies_BaseEffect_EffectId",
                table: "Methodologies");

            migrationBuilder.DropForeignKey(
                name: "FK_Muses_BaseEffect_EffectId",
                table: "Muses");

            migrationBuilder.DropForeignKey(
                name: "FK_Rackets_BaseEffect_EffectId",
                table: "Rackets");

            migrationBuilder.DropForeignKey(
                name: "FK_RuneMagics_BaseEffect_EffectId",
                table: "RuneMagics");

            migrationBuilder.DropForeignKey(
                name: "FK_Ancestries_Rarities_RarityId",
                table: "Ancestries");

            migrationBuilder.DropForeignKey(
                name: "FK_Bloodlines_Rarities_RarityId",
                table: "Bloodlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Heritages_Rarities_RarityId",
                table: "Heritages");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisite_Ancestries_RequiredAncestryId",
                table: "BasePrerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisite_AncestrySizes_RequiredSizeId",
                table: "BasePrerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisite_Heritages_RequiredHeritageId",
                table: "BasePrerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_Archetypes_Feats_DedicationFeatId",
                table: "Archetypes");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisite_Feats_RequiredFeatId",
                table: "BasePrerequisite");

            migrationBuilder.DropForeignKey(
                name: "FK_GunslingersWays_Feats_AdvancedDeedId",
                table: "GunslingersWays");

            migrationBuilder.DropForeignKey(
                name: "FK_GunslingersWays_Feats_GreaterDeedId",
                table: "GunslingersWays");

            migrationBuilder.DropForeignKey(
                name: "FK_GunslingersWays_Feats_InitialDeedId",
                table: "GunslingersWays");

            migrationBuilder.DropForeignKey(
                name: "FK_GunslingersWays_Feats_SlingersReloadId",
                table: "GunslingersWays");

            migrationBuilder.DropForeignKey(
                name: "FK_GunslingersWays_BasePrerequisite_PrerequisiteId",
                table: "GunslingersWays");

            migrationBuilder.DropTable(
                name: "Abilities_Effects");

            migrationBuilder.DropTable(
                name: "AbilityTrait");

            migrationBuilder.DropTable(
                name: "Actions_Details");

            migrationBuilder.DropTable(
                name: "ActionTrait");

            migrationBuilder.DropTable(
                name: "Activities_Details");

            migrationBuilder.DropTable(
                name: "ActivityTrait");

            migrationBuilder.DropTable(
                name: "AlignmentDeity");

            migrationBuilder.DropTable(
                name: "AlignmentEidolon");

            migrationBuilder.DropTable(
                name: "Ancestries_AdditionalMechanics");

            migrationBuilder.DropTable(
                name: "Ancestries_Adventurers");

            migrationBuilder.DropTable(
                name: "Ancestries_AlignmentAndReligion");

            migrationBuilder.DropTable(
                name: "Ancestries_Description");

            migrationBuilder.DropTable(
                name: "Ancestries_Names");

            migrationBuilder.DropTable(
                name: "Ancestries_OtherInformation");

            migrationBuilder.DropTable(
                name: "Ancestries_OthersProbably");

            migrationBuilder.DropTable(
                name: "Ancestries_PhysicalDescription");

            migrationBuilder.DropTable(
                name: "Ancestries_Society");

            migrationBuilder.DropTable(
                name: "Ancestries_YouMight");

            migrationBuilder.DropTable(
                name: "AncestryAncestrySize");

            migrationBuilder.DropTable(
                name: "AncestryHeritage");

            migrationBuilder.DropTable(
                name: "AncestrySizeEidolon");

            migrationBuilder.DropTable(
                name: "AncestryTrait");

            migrationBuilder.DropTable(
                name: "AnimalCompanion");

            migrationBuilder.DropTable(
                name: "ArcaneThesis_Details");

            migrationBuilder.DropTable(
                name: "Archetypes_Details");

            migrationBuilder.DropTable(
                name: "Archetypes_MulticlassDetails");

            migrationBuilder.DropTable(
                name: "Backgrounds_Details");

            migrationBuilder.DropTable(
                name: "BackgroundTrait");

            migrationBuilder.DropTable(
                name: "BaseItemTraitBinding");

            migrationBuilder.DropTable(
                name: "BaseItemVariant_Addendum");

            migrationBuilder.DropTable(
                name: "Bloodlines_Details");

            migrationBuilder.DropTable(
                name: "Bloodlines_TypeChoiceDetails");

            migrationBuilder.DropTable(
                name: "BloodlineSkill");

            migrationBuilder.DropTable(
                name: "BooleanEffectBinding");

            migrationBuilder.DropTable(
                name: "BooleanPrerequisiteBinding");

            migrationBuilder.DropTable(
                name: "Causes_Details");

            migrationBuilder.DropTable(
                name: "Cell");

            migrationBuilder.DropTable(
                name: "ChoiceEffectBinding");

            migrationBuilder.DropTable(
                name: "ClassCharacteristic");

            migrationBuilder.DropTable(
                name: "ClassFeatureBinding");

            migrationBuilder.DropTable(
                name: "ClassFeatures_Details");

            migrationBuilder.DropTable(
                name: "ClassMannerism");

            migrationBuilder.DropTable(
                name: "ClassStat");

            migrationBuilder.DropTable(
                name: "Column");

            migrationBuilder.DropTable(
                name: "CombinationWeaponComponentTraitBinding");

            migrationBuilder.DropTable(
                name: "Conditions_Details");

            migrationBuilder.DropTable(
                name: "Creature_Details");

            migrationBuilder.DropTable(
                name: "CreatureFlavor_Details");

            migrationBuilder.DropTable(
                name: "CreatureImmunity");

            migrationBuilder.DropTable(
                name: "CreatureLanguage");

            migrationBuilder.DropTable(
                name: "CreatureSense");

            migrationBuilder.DropTable(
                name: "CreatureSkill");

            migrationBuilder.DropTable(
                name: "CreatureSpell");

            migrationBuilder.DropTable(
                name: "CreatureTrait");

            migrationBuilder.DropTable(
                name: "Curses_Details");

            migrationBuilder.DropTable(
                name: "CurseTrait");

            migrationBuilder.DropTable(
                name: "Deities_Details");

            migrationBuilder.DropTable(
                name: "DeityDivineFont");

            migrationBuilder.DropTable(
                name: "DeityDomain");

            migrationBuilder.DropTable(
                name: "DeityMeleeWeapon");

            migrationBuilder.DropTable(
                name: "DeityRangedWeapon");

            migrationBuilder.DropTable(
                name: "DeitySkill");

            migrationBuilder.DropTable(
                name: "DeityStat");

            migrationBuilder.DropTable(
                name: "DeityUnarmedWeapon");

            migrationBuilder.DropTable(
                name: "DiseaseStageEffect");

            migrationBuilder.DropTable(
                name: "DiseaseTrait");

            migrationBuilder.DropTable(
                name: "Doctrines");

            migrationBuilder.DropTable(
                name: "DomainMystery");

            migrationBuilder.DropTable(
                name: "EffectIncrement");

            migrationBuilder.DropTable(
                name: "EidolonAbility_Details");

            migrationBuilder.DropTable(
                name: "EidolonHomePlane");

            migrationBuilder.DropTable(
                name: "EidolonSense");

            migrationBuilder.DropTable(
                name: "EidolonSkill");

            migrationBuilder.DropTable(
                name: "EidolonTrait");

            migrationBuilder.DropTable(
                name: "EidolonVariant");

            migrationBuilder.DropTable(
                name: "FamiliarAbilities");

            migrationBuilder.DropTable(
                name: "FeatRequirement");

            migrationBuilder.DropTable(
                name: "Feats_Details");

            migrationBuilder.DropTable(
                name: "FeatTrait");

            migrationBuilder.DropTable(
                name: "Frequency");

            migrationBuilder.DropTable(
                name: "GunslingersWays_Details");

            migrationBuilder.DropTable(
                name: "GunslingersWaySkill");

            migrationBuilder.DropTable(
                name: "HarrowCards");

            migrationBuilder.DropTable(
                name: "HarrowModes");

            migrationBuilder.DropTable(
                name: "HazardComponent");

            migrationBuilder.DropTable(
                name: "HazardDetectionRequirement");

            migrationBuilder.DropTable(
                name: "HazardDisableRequirement");

            migrationBuilder.DropTable(
                name: "HazardDispellRequirement");

            migrationBuilder.DropTable(
                name: "HazardImmunity");

            migrationBuilder.DropTable(
                name: "Hazards_RoutineDetails");

            migrationBuilder.DropTable(
                name: "HazardTrait");

            migrationBuilder.DropTable(
                name: "Heritages_Details");

            migrationBuilder.DropTable(
                name: "HuntersEdges");

            migrationBuilder.DropTable(
                name: "HybridStudies_Details");

            migrationBuilder.DropTable(
                name: "InlineAction_Effect");

            migrationBuilder.DropTable(
                name: "InlineActionTraitBinding");

            migrationBuilder.DropTable(
                name: "InlineAttack_Effect");

            migrationBuilder.DropTable(
                name: "InlineAttackTraitBinding");

            migrationBuilder.DropTable(
                name: "InnovationModifications");

            migrationBuilder.DropTable(
                name: "Innovations_Details");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "ItemCurses_Details");

            migrationBuilder.DropTable(
                name: "ItemCurseTrait");

            migrationBuilder.DropTable(
                name: "Items_Details");

            migrationBuilder.DropTable(
                name: "MagicEssences");

            migrationBuilder.DropTable(
                name: "MagicTraditionSpell");

            migrationBuilder.DropTable(
                name: "MasterAbilities");

            migrationBuilder.DropTable(
                name: "Methodologies_Details");

            migrationBuilder.DropTable(
                name: "Mysteries_Details");

            migrationBuilder.DropTable(
                name: "Mysteries_MysteryBenefits");

            migrationBuilder.DropTable(
                name: "MysteryCurse_Details");

            migrationBuilder.DropTable(
                name: "MysteryCursePotency_Details");

            migrationBuilder.DropTable(
                name: "PatronThemeSpell");

            migrationBuilder.DropTable(
                name: "Philosophies_Details");

            migrationBuilder.DropTable(
                name: "Planes_Details");

            migrationBuilder.DropTable(
                name: "PlaneTrait");

            migrationBuilder.DropTable(
                name: "PlayModeSkillAction");

            migrationBuilder.DropTable(
                name: "PreciousMaterialArmors_Details");

            migrationBuilder.DropTable(
                name: "PreciousMaterialArmorTrait");

            migrationBuilder.DropTable(
                name: "PreciousMaterialArmorVariant");

            migrationBuilder.DropTable(
                name: "PreciousMaterialGrade");

            migrationBuilder.DropTable(
                name: "PreciousMaterialObjectInformation");

            migrationBuilder.DropTable(
                name: "PreciousMaterials_Details");

            migrationBuilder.DropTable(
                name: "PreciousMaterialShields_Details");

            migrationBuilder.DropTable(
                name: "PreciousMaterialShieldTrait");

            migrationBuilder.DropTable(
                name: "PreciousMaterialShieldVariant");

            migrationBuilder.DropTable(
                name: "PreciousMaterialTrait");

            migrationBuilder.DropTable(
                name: "PreciousMaterialWeapons_Details");

            migrationBuilder.DropTable(
                name: "PreciousMaterialWeaponTrait");

            migrationBuilder.DropTable(
                name: "PreciousMaterialWeaponVariant");

            migrationBuilder.DropTable(
                name: "Rackets_Details");

            migrationBuilder.DropTable(
                name: "ResearchFields_Details");

            migrationBuilder.DropTable(
                name: "Rules_Details");

            migrationBuilder.DropTable(
                name: "RuneMagicSchoolBinding");

            migrationBuilder.DropTable(
                name: "SavingThrowStats_Details");

            migrationBuilder.DropTable(
                name: "Senses_Details");

            migrationBuilder.DropTable(
                name: "SkillActionExample");

            migrationBuilder.DropTable(
                name: "SkillActions_Details");

            migrationBuilder.DropTable(
                name: "SkillActionTrait");

            migrationBuilder.DropTable(
                name: "SkillBenefit");

            migrationBuilder.DropTable(
                name: "SkillSkillAction");

            migrationBuilder.DropTable(
                name: "SpellHeightening_Details");

            migrationBuilder.DropTable(
                name: "Spells_Details");

            migrationBuilder.DropTable(
                name: "SpellSpellComponent");

            migrationBuilder.DropTable(
                name: "SpellTraitBinding");

            migrationBuilder.DropTable(
                name: "StaggeredEffectStageEffect");

            migrationBuilder.DropTable(
                name: "StaggeredEffectTraitBinding");

            migrationBuilder.DropTable(
                name: "StaveSpell");

            migrationBuilder.DropTable(
                name: "SwashbucklersStyle");

            migrationBuilder.DropTable(
                name: "Tenets_Details");

            migrationBuilder.DropTable(
                name: "Traits_Details");

            migrationBuilder.DropTable(
                name: "UtilityGear_Details");

            migrationBuilder.DropTable(
                name: "UtilityGearTraitBinding");

            migrationBuilder.DropTable(
                name: "UtilityGearVariant_Addendum");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "ArcaneThesis");

            migrationBuilder.DropTable(
                name: "Backgrounds");

            migrationBuilder.DropTable(
                name: "Row");

            migrationBuilder.DropTable(
                name: "CreatureFlavor");

            migrationBuilder.DropTable(
                name: "Curses");

            migrationBuilder.DropTable(
                name: "DiseaseStage");

            migrationBuilder.DropTable(
                name: "EffectIncrementTrigger");

            migrationBuilder.DropTable(
                name: "EidolonAbility");

            migrationBuilder.DropTable(
                name: "HarrowCategories");

            migrationBuilder.DropTable(
                name: "HazardImmunities");

            migrationBuilder.DropTable(
                name: "InlineAction");

            migrationBuilder.DropTable(
                name: "InlineAttack");

            migrationBuilder.DropTable(
                name: "ItemCurses");

            migrationBuilder.DropTable(
                name: "Mysteries");

            migrationBuilder.DropTable(
                name: "MysteryCursePotency");

            migrationBuilder.DropTable(
                name: "PatronThemes");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "PlayModes");

            migrationBuilder.DropTable(
                name: "PreciousMaterialItemCategories");

            migrationBuilder.DropTable(
                name: "PreciousMaterials");

            migrationBuilder.DropTable(
                name: "ObjectGrade");

            migrationBuilder.DropTable(
                name: "ResearchFields");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "BenefitTypes");

            migrationBuilder.DropTable(
                name: "SpellHeightening");

            migrationBuilder.DropTable(
                name: "SpellComponents");

            migrationBuilder.DropTable(
                name: "StaggeredEffectStage");

            migrationBuilder.DropTable(
                name: "UtilityGearVariant");

            migrationBuilder.DropTable(
                name: "Creature");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Eidolons");

            migrationBuilder.DropTable(
                name: "BaseItemVariant");

            migrationBuilder.DropTable(
                name: "AttackTypes");

            migrationBuilder.DropTable(
                name: "Hazards");

            migrationBuilder.DropTable(
                name: "MysteryCurse");

            migrationBuilder.DropTable(
                name: "PlaneCategories");

            migrationBuilder.DropTable(
                name: "PreciousMaterialArmors");

            migrationBuilder.DropTable(
                name: "PreciousMaterialShields");

            migrationBuilder.DropTable(
                name: "PreciousMaterialWeapons");

            migrationBuilder.DropTable(
                name: "UtilityGear");

            migrationBuilder.DropTable(
                name: "CreatureRecallKnowledge");

            migrationBuilder.DropTable(
                name: "Bulks");

            migrationBuilder.DropTable(
                name: "CombinationWeaponComponent");

            migrationBuilder.DropTable(
                name: "HazardComplexities");

            migrationBuilder.DropTable(
                name: "HazardTypes");

            migrationBuilder.DropTable(
                name: "ActionTypes");

            migrationBuilder.DropTable(
                name: "RollableEffect");

            migrationBuilder.DropTable(
                name: "SourcePage");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Alignments");

            migrationBuilder.DropTable(
                name: "Deities");

            migrationBuilder.DropTable(
                name: "DeityCategories");

            migrationBuilder.DropTable(
                name: "DivineIntercession");

            migrationBuilder.DropTable(
                name: "Philosophies");

            migrationBuilder.DropTable(
                name: "BaseEffect");

            migrationBuilder.DropTable(
                name: "Choice");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "InnovationModificationTypes");

            migrationBuilder.DropTable(
                name: "InstinctAbilities");

            migrationBuilder.DropTable(
                name: "LoreCategories");

            migrationBuilder.DropTable(
                name: "Potencies");

            migrationBuilder.DropTable(
                name: "RuneMagics");

            migrationBuilder.DropTable(
                name: "SkillActions");

            migrationBuilder.DropTable(
                name: "ConditionCategories");

            migrationBuilder.DropTable(
                name: "Rarities");

            migrationBuilder.DropTable(
                name: "Ancestries");

            migrationBuilder.DropTable(
                name: "AncestrySizes");

            migrationBuilder.DropTable(
                name: "Heritages");

            migrationBuilder.DropTable(
                name: "Feats");

            migrationBuilder.DropTable(
                name: "Archetypes");

            migrationBuilder.DropTable(
                name: "BasePrerequisite");

            migrationBuilder.DropTable(
                name: "Bloodlines");

            migrationBuilder.DropTable(
                name: "Causes");

            migrationBuilder.DropTable(
                name: "ClassFeatures");

            migrationBuilder.DropTable(
                name: "DivineAllies");

            migrationBuilder.DropTable(
                name: "DivineFonts");

            migrationBuilder.DropTable(
                name: "DraconicExemplars");

            migrationBuilder.DropTable(
                name: "DruidicOrders");

            migrationBuilder.DropTable(
                name: "GunslingersWays");

            migrationBuilder.DropTable(
                name: "HybridStudies");

            migrationBuilder.DropTable(
                name: "Innovations");

            migrationBuilder.DropTable(
                name: "Instincts");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Lores");

            migrationBuilder.DropTable(
                name: "Methodologies");

            migrationBuilder.DropTable(
                name: "Muses");

            migrationBuilder.DropTable(
                name: "Rackets");

            migrationBuilder.DropTable(
                name: "SenseAccuracy");

            migrationBuilder.DropTable(
                name: "Senses");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Tenets");

            migrationBuilder.DropTable(
                name: "UnarmedWeapons");

            migrationBuilder.DropTable(
                name: "DamageTypes");

            migrationBuilder.DropTable(
                name: "EffectShape");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "ArmorCategories");

            migrationBuilder.DropTable(
                name: "ArmorGroups");

            migrationBuilder.DropTable(
                name: "WeaponCategories");

            migrationBuilder.DropTable(
                name: "WeaponGroups");

            migrationBuilder.DropTable(
                name: "LanguageTypes");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Domains");

            migrationBuilder.DropTable(
                name: "MagicSchools");

            migrationBuilder.DropTable(
                name: "SpellTypes");

            migrationBuilder.DropTable(
                name: "StaggeredEffect");

            migrationBuilder.DropTable(
                name: "Table");

            migrationBuilder.DropTable(
                name: "MagicTraditions");

            migrationBuilder.DropTable(
                name: "Proficiencies");

            migrationBuilder.DropTable(
                name: "SavingThrowStats");
        }
    }
}
