using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Silvester.Pathfinder.Official.Database.Migrations
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
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alignments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alignments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArmorGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorGroups", x => x.Id);
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
                name: "DeityCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeityCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeatTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Frequencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    TimeSpan = table.Column<TimeSpan>(type: "interval", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frequencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeritageRarities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeritageRarities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PageNumber = table.Column<int>(type: "integer", nullable: false)
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
                    Name = table.Column<string>(type: "text", nullable: false)
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
                    Description = table.Column<string>(type: "text", nullable: false)
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
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicSchools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaneCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaneCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proficiencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Bonus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RaceRarities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceRarities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RaceSizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Space = table.Column<int>(type: "integer", nullable: false),
                    HeightReach = table.Column<int>(type: "integer", nullable: false),
                    BreadthReach = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RollableEffect",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CriticalSuccess = table.Column<string>(type: "text", nullable: true),
                    Success = table.Column<string>(type: "text", nullable: true),
                    Failure = table.Column<string>(type: "text", nullable: true),
                    CriticalFailure = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RollableEffect", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavingThrowStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
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
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpellTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActionDetailsBlock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    ActionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionDetailsBlock", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ActionsId = table.Column<Guid>(type: "uuid", nullable: true),
                    FeatsId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpellsId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits", x => x.Id);
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
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Actions_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Level = table.Column<int>(type: "integer", nullable: false),
                    ActionTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    FeatTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    FrequencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    RollableEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: true)
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
                        name: "FK_Feats_FeatTypes_FeatTypeId",
                        column: x => x.FeatTypeId,
                        principalTable: "FeatTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feats_Frequencies_FrequencyId",
                        column: x => x.FrequencyId,
                        principalTable: "Frequencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feats_RollableEffect_RollableEffectId",
                        column: x => x.RollableEffectId,
                        principalTable: "RollableEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feats_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaseFeatEffectBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    FeatId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseFeatEffectBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseFeatEffectBinding_Feats_FeatId",
                        column: x => x.FeatId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatDetailsBlock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    FeatId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatDetailsBlock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeatDetailsBlock_Feats_FeatId",
                        column: x => x.FeatId,
                        principalTable: "Feats",
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
                name: "FeatEffect",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BindingId = table.Column<Guid>(type: "uuid", nullable: false),
                    TriggeredAtLevel = table.Column<int>(type: "integer", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    OrFeatEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    HeritageRarityId = table.Column<Guid>(type: "uuid", nullable: true),
                    Level = table.Column<int>(type: "integer", nullable: true),
                    ProficiencyId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatEffect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeatEffect_BaseFeatEffectBinding_BindingId",
                        column: x => x.BindingId,
                        principalTable: "BaseFeatEffectBinding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatEffect_FeatEffect_OrFeatEffectId",
                        column: x => x.OrFeatEffectId,
                        principalTable: "FeatEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FeatEffect_HeritageRarities_HeritageRarityId",
                        column: x => x.HeritageRarityId,
                        principalTable: "HeritageRarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatEffect_Proficiencies_ProficiencyId",
                        column: x => x.ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Range = table.Column<int>(type: "integer", nullable: true),
                    CastTime = table.Column<TimeSpan>(type: "interval", nullable: true),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Targets = table.Column<string>(type: "text", nullable: true),
                    IsDismissable = table.Column<bool>(type: "boolean", nullable: false),
                    Area = table.Column<string>(type: "text", nullable: true),
                    Duration = table.Column<string>(type: "text", nullable: true),
                    ActionTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpellTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    SavingThrowStatId = table.Column<Guid>(type: "uuid", nullable: true),
                    RollableEffectId = table.Column<Guid>(type: "uuid", nullable: true),
                    MagicSchoolId = table.Column<Guid>(type: "uuid", nullable: false),
                    ComponentsId = table.Column<Guid>(type: "uuid", nullable: true),
                    TraditionsId = table.Column<Guid>(type: "uuid", nullable: true),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: true)
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
                        name: "FK_Spells_MagicSchools_MagicSchoolId",
                        column: x => x.MagicSchoolId,
                        principalTable: "MagicSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spells_RollableEffect_RollableEffectId",
                        column: x => x.RollableEffectId,
                        principalTable: "RollableEffect",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_SavingThrowStats_SavingThrowStatId",
                        column: x => x.SavingThrowStatId,
                        principalTable: "SavingThrowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_SpellTypes_SpellTypeId",
                        column: x => x.SpellTypeId,
                        principalTable: "SpellTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spells_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MagicTraditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SpellsId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicTraditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicTraditions_Spells_SpellsId",
                        column: x => x.SpellsId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpellComponents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SpellsId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellComponents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellComponents_Spells_SpellsId",
                        column: x => x.SpellsId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpellDetailBlock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    SpellId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellDetailBlock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellDetailBlock_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpellHeightening",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
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
                name: "SpellRequirement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    SpellId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellRequirement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellRequirement_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpellTrait",
                columns: table => new
                {
                    SpellsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellTrait", x => new { x.SpellsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_SpellTrait_Spells_SpellsId",
                        column: x => x.SpellsId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpellTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpellTrigger",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    SpellId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellTrigger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellTrigger_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
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
                name: "SpellSpellComponent",
                columns: table => new
                {
                    SpellsId = table.Column<Guid>(type: "uuid", nullable: false),
                    ComponentsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSpellComponent", x => new { x.SpellsId, x.ComponentsId });
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
                name: "SpellHeighteningDetailBlock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    SpellHeighteningId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellHeighteningDetailBlock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellHeighteningDetailBlock_SpellHeightening_SpellHeighteni~",
                        column: x => x.SpellHeighteningId,
                        principalTable: "SpellHeightening",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    AlignmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    DivineFontsId = table.Column<Guid>(type: "uuid", nullable: true),
                    DomainsId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deities_Alignments_AlignmentId",
                        column: x => x.AlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deities_DeityCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "DeityCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeityFollowerAlignments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DeityId = table.Column<Guid>(type: "uuid", nullable: false),
                    AlignmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeityFollowerAlignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeityFollowerAlignments_Alignments_AlignmentId",
                        column: x => x.AlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeityFollowerAlignments_Deities_DeityId",
                        column: x => x.DeityId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DivineFonts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DeitiesId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivineFonts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DivineFonts_Deities_DeitiesId",
                        column: x => x.DeitiesId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DeitiesId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Domains_Deities_DeitiesId",
                        column: x => x.DeitiesId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Planes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    AlignmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: true)
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
                name: "PlaneTraits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PlanesId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaneTraits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaneTraits_Planes_PlanesId",
                        column: x => x.PlanesId,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlanePlaneTrait",
                columns: table => new
                {
                    PlanesId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanePlaneTrait", x => new { x.PlanesId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_PlanePlaneTrait_Planes_PlanesId",
                        column: x => x.PlanesId,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanePlaneTrait_PlaneTraits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "PlaneTraits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prerequisites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BindingId = table.Column<Guid>(type: "uuid", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    OrPrerequisiteId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredDeityId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredFeatId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredLevel = table.Column<int>(type: "integer", nullable: true),
                    RequiredProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    RecallKnowledgePrerequisite_RequiredProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiresAssurance = table.Column<bool>(type: "boolean", nullable: true),
                    RequiredSkillId = table.Column<Guid>(type: "uuid", nullable: true),
                    SkillPrerequisite_RequiredProficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequiredStatValue = table.Column<int>(type: "integer", nullable: true),
                    RequiredStatId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prerequisites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prerequisites_Deities_RequiredDeityId",
                        column: x => x.RequiredDeityId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prerequisites_Feats_RequiredFeatId",
                        column: x => x.RequiredFeatId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prerequisites_Prerequisites_OrPrerequisiteId",
                        column: x => x.OrPrerequisiteId,
                        principalTable: "Prerequisites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prerequisites_Proficiencies_RecallKnowledgePrerequisite_Req~",
                        column: x => x.RecallKnowledgePrerequisite_RequiredProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prerequisites_Proficiencies_RequiredProficiencyId",
                        column: x => x.RequiredProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prerequisites_Proficiencies_SkillPrerequisite_RequiredProfi~",
                        column: x => x.SkillPrerequisite_RequiredProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasePrerequisiteBinding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    FeatId = table.Column<Guid>(type: "uuid", nullable: true),
                    PrerequisiteId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasePrerequisiteBinding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasePrerequisiteBinding_Feats_FeatId",
                        column: x => x.FeatId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePrerequisiteBinding_Prerequisites_PrerequisiteId",
                        column: x => x.PrerequisiteId,
                        principalTable: "Prerequisites",
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
                });

            migrationBuilder.CreateTable(
                name: "ClassFeature",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    ClassId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassFeature", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "ClassStat",
                columns: table => new
                {
                    KeyAbilityClassesId = table.Column<Guid>(type: "uuid", nullable: false),
                    KeyAbilitiesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassStat", x => new { x.KeyAbilityClassesId, x.KeyAbilitiesId });
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Abbreviation = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    KeyAbilityClassesId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
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
                    KeyAbilitiesId = table.Column<Guid>(type: "uuid", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Classes_Stats_KeyAbilitiesId",
                        column: x => x.KeyAbilitiesId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    StatModifierId = table.Column<Guid>(type: "uuid", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Consumable = table.Column<string>(type: "text", nullable: true),
                    Creature = table.Column<string>(type: "text", nullable: true),
                    DeityId = table.Column<Guid>(type: "uuid", nullable: true),
                    PlaneId = table.Column<Guid>(type: "uuid", nullable: true),
                    Settlement = table.Column<string>(type: "text", nullable: true),
                    Terrain = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lores_Deities_DeityId",
                        column: x => x.DeityId,
                        principalTable: "Deities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lores_Planes_PlaneId",
                        column: x => x.PlaneId,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    StatModifierId = table.Column<Guid>(type: "uuid", nullable: false)
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
                name: "Heritages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RarityId = table.Column<Guid>(type: "uuid", nullable: false),
                    RacesId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heritages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heritages_HeritageRarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "HeritageRarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeritageRace",
                columns: table => new
                {
                    HeritagesId = table.Column<Guid>(type: "uuid", nullable: false),
                    RacesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeritageRace", x => new { x.HeritagesId, x.RacesId });
                    table.ForeignKey(
                        name: "FK_HeritageRace_Heritages_HeritagesId",
                        column: x => x.HeritagesId,
                        principalTable: "Heritages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    BaseSpeed = table.Column<int>(type: "integer", nullable: false),
                    BaseHealth = table.Column<int>(type: "integer", nullable: false),
                    SizeId = table.Column<Guid>(type: "uuid", nullable: false),
                    RarityId = table.Column<Guid>(type: "uuid", nullable: false),
                    HeritagesId = table.Column<Guid>(type: "uuid", nullable: true),
                    LanguagesId = table.Column<Guid>(type: "uuid", nullable: true),
                    RaceTraitsId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Races_Heritages_HeritagesId",
                        column: x => x.HeritagesId,
                        principalTable: "Heritages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Races_RaceRarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "RaceRarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Races_RaceSizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "RaceSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    RacesId = table.Column<Guid>(type: "uuid", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Languages_Races_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RaceTraits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RacesId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceTraits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceTraits_Races_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LanguageRace",
                columns: table => new
                {
                    RacesId = table.Column<Guid>(type: "uuid", nullable: false),
                    LanguagesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageRace", x => new { x.RacesId, x.LanguagesId });
                    table.ForeignKey(
                        name: "FK_LanguageRace_Languages_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageRace_Races_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceRaceTrait",
                columns: table => new
                {
                    RacesId = table.Column<Guid>(type: "uuid", nullable: false),
                    RaceTraitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceRaceTrait", x => new { x.RacesId, x.RaceTraitsId });
                    table.ForeignKey(
                        name: "FK_RaceRaceTrait_Races_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceRaceTrait_RaceTraits_RaceTraitsId",
                        column: x => x.RaceTraitsId,
                        principalTable: "RaceTraits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), "No Action" },
                    { new Guid("4716abe4-50c3-447d-bb27-2b268667b3c2"), "Free" },
                    { new Guid("668ed964-cf7f-43df-b4b3-6a89c28551aa"), "Reaction" },
                    { new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "One Action" },
                    { new Guid("fe122850-b449-482d-8350-ac21e8985594"), "Two Actions" },
                    { new Guid("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8"), "Three Actions" },
                    { new Guid("11d73724-984e-4258-9157-6d0373363faa"), "One or Two Actions" },
                    { new Guid("80db0630-824c-4664-8ed8-460979a18404"), "Two or Three Actions" }
                });

            migrationBuilder.InsertData(
                table: "Alignments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("25f9299a-9a7c-40bc-b8bd-58588d19381b"), "A chaotic evil character tends to have no respect for rules, other people's lives, or anything but their own desires, which are typically selfish and cruel. They set a high value on personal freedom, but do not have much regard for the lives or freedom of other people. Chaotic evil characters do not work well in groups because they resent being given orders and usually do not behave themselves unless there is no alternative.", "Chaotic Evil" },
                    { new Guid("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), "A neutral evil character is typically selfish and has no qualms about turning on allies-of-the-moment, and usually makes allies primarily to further their own goals. A neutral evil character has no compunctions about harming others to get what they want, but neither will they go out of their way to cause carnage or mayhem when they see no direct benefit for themselves. Another valid interpretation of neutral evil holds up evil as an ideal, doing evil for evil's sake and trying to spread its influence. Examples of the first type are an assassin who has little regard for formal laws but does not needlessly kill, a henchman who plots behind their superior's back, or a mercenary who readily switches sides if made a better offer. An example of the second type would be a masked killer who strikes only for the sake of causing fear and distrust in the community.", "Neutral Evil" },
                    { new Guid("54f32060-3da3-4edf-b6dc-3839b8b7415d"), "A lawful evil character sees a well-ordered system as being easier to exploit than to necessarily follow. Examples of this alignment include tyrants, dictators, corrupt officials, or undiscriminating mercenary types who have a strict code of conduct.", "Lawful Evil" },
                    { new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), "A true neutral character is neutral on both axes and tends not to feel strongly towards any alignment, or actively seeks their balance.", "True Neutral" },
                    { new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), "A neutral good character typically acts altruistically, without regard for or against lawful precepts such as rules or tradition. A neutral good character has no problems with cooperating with lawful officials, but does not feel beholden to them. In the event that doing the right thing requires the bending or breaking of rules, they do not suffer the same inner conflict that a lawful good character would.", "Neutral Good" },
                    { new Guid("2ad80bbd-a735-4431-9e3a-f784e053b756"), "A chaotic neutral character is an individualist who follows their own heart and generally shirks rules and traditions. Although chaotic neutral characters promote the ideals of freedom, it is their own freedom that comes first; good and evil come second to their need to be free.", "Chaotic Neutral" },
                    { new Guid("add12009-9c8a-4287-b02b-7e5b9459bf44"), "A chaotic good character does what is necessary to bring about change for the better, disdains bureaucratic organizations that get in the way of social improvement, and places a high value on personal freedom, not only for oneself, but for others as well. Chaotic good characters usually intend to do the right thing, but their methods are generally disorganized and often out of sync with the rest of society.", "Chaotic Good" },
                    { new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), "A lawful good character typically acts with compassion and always with honor and a sense of duty. However, lawful good characters will often regret taking any action they fear would violate their code, even if they recognize such action as being good.", "Lawful Good" },
                    { new Guid("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), "A lawful neutral character typically believes strongly in lawful concepts such as honor, order, rules, and tradition, but often follows a personal code in addition to, or even in preference to, one set down by a benevolent authority. Examples of this alignment include a soldier who always follows orders, a judge or enforcer who adheres mercilessly to the letter of the law, or a disciplined monk.", "Lawful Neutral" }
                });

            migrationBuilder.InsertData(
                table: "ArmorGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("28f6b905-0c5e-4cc0-8164-8e623fdfb367"), "Light Armor" },
                    { new Guid("199f2e7d-5249-45ee-af4d-b3f7cdd257b8"), "Medium Armor" },
                    { new Guid("f3d2b25b-e222-4af2-9287-a6036e6bb0b7"), "Heavy Armor" },
                    { new Guid("3e53fcd2-e07b-4af5-b331-b4372acacf74"), "Unarmored" }
                });

            migrationBuilder.InsertData(
                table: "BenefitTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2cf97405-0831-45eb-a8e9-6c732079dd37"), "Assurance" });

            migrationBuilder.InsertData(
                table: "Bulks",
                columns: new[] { "Id", "BulkWeight", "LightWeight", "Name" },
                values: new object[,]
                {
                    { new Guid("b5de3410-d051-4dfe-be54-dde62ee45bc1"), 0, 0, "-" },
                    { new Guid("978d32f8-10b7-4150-bd9f-b8f037220542"), 0, 1, "L" },
                    { new Guid("8ad6f1e7-1ac2-47fd-b374-bb4f077a2545"), 1, 0, "1" },
                    { new Guid("28310eb8-9bee-46f0-9b93-e0965207169a"), 2, 0, "2" },
                    { new Guid("d09af7fc-06b3-41c5-89f7-7cbb3fb6f93b"), 3, 0, "3" },
                    { new Guid("61e784de-dd93-4d53-acda-61dff663e2a3"), 4, 0, "4" }
                });

            migrationBuilder.InsertData(
                table: "DeityCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1a209857-903b-4a88-9c42-bfcaf5f7b053"), "Although once mostly forgotten, the Old Sun Gods have slowly been brought back to the people of Mzali thanks to Sihar and the Bright Lions.", "Old Sun Gods" },
                    { new Guid("cb0c42c1-2f21-4c52-b419-09d55a7b8eca"), "The Outer Gods, along with the Great Old Ones with whom the Outer Gods are sometimes confused, are ancient, inscrutable, cosmic beings. The Great Old Ones are titanic monstrosities imprisoned since time immemorial beneath the sea, deep within the world, or on other planets, but the Outer Gods are even less comprehensible. These unfathomable entities lurk within the Dark Tapestry—the vast void between the stars on the Material Plane—and dwarf other deities just as those deities dwarf ordinary mortals. To worship these gods is to acknowledge a cold truth: the universe has no meaning. All the things mortal civilizations hold dear—virtues, deities, great works— are things those mortals have invented to distract them from their own insignificance. History is a comforting lie told because mortals are afraid of the dark. The universe is immeasurably vast, beyond understanding, and cares nothing for life. Ultimately, every creature is alone, unmourned, and unloved. And because life has no meaning or purpose, self-indulgence and nihilism are the only rational responses.", "Outer Gods and Great Old Ones" },
                    { new Guid("95ffee72-4042-47a8-8e82-3ff82c51d55c"), "A pantheon is a group of related gods worshipped either individually or together. Most pantheons are associated with a specific ancestry or geopolitical region, but rarely, a pantheon consists of deities with overlapping areas of concern. Followers work to advance the shared interests of their pantheon, directing prayers to whichever god presides over their current activity or circumstance. At the GM's discretion, champions and clerics can dedicate themselves to a pantheon. In such cases, the characters still worship a specific patron deity among those in the pantheon, but also follow the edicts and anathema of the pantheon as a whole. A character who worships a pantheon this way can gain the domains, alternate domains, and spells from the pantheon instead of those from their patron deity. They must uphold the ideals of both their patron deity and the pantheon, though the patron deity's edicts and anathema take precedence. For example, a worshipper of Iomedae could worship the Godclaw, but they wouldn't take the tyranny domain, as it would be in conflict with Iomedae's edicts. In rare cases, a character can worship a pantheon without following a patron deity. Such cases are unique and subject to GM approval.", "Pantheons" },
                    { new Guid("9071aac4-ebdd-45a5-ba88-e4af3c56d111"), "No official description was provided.", "Vudrani Gods" },
                    { new Guid("aa2c5a37-9a30-4bdb-904e-ca1de189edbb"), "No official description was provided.", "Sarkorian Gods" },
                    { new Guid("60738a86-c7af-4b79-b29c-a0e861a08da4"), "No official description was provided.", "Tian Gods" },
                    { new Guid("45bda584-ba71-45c5-a91d-a3e9e07ee0a3"), "While fiends exploit mortals' baser natures and celestials encourage their better selves, monitors are concerned more with method than morality, from the rigid law of aeons and inevitables to the pragmatic neutrality of psychopomps, to the unpredictable chaos of proteans. Rather than immersing themselves in issues of philosophy, monitors take a more cosmic approach, battling each other over universal laws, the planes, and reality itself. Mortals worship monitor demigods just as they do empyreal lords and fiendish demigods. Some are drawn to the enigmatic Monad or primordial inevitables out of a desire for control or the reassurance of an orderly universe—often those in governance or academia. Artists and bon vivants who seek the creativity and freedom offered by the paragons of chaos revere protean lords. While many assume worshippers of psychopomp ushers to be morbid, that is rarely the case. Psychopomp worship is also found among those who bring life into the world, such as midwives and farmers, and those who eschew idealism for more practical philosophies.", "Monitor Demigods" },
                    { new Guid("cb6ebc9d-9a0e-4d7c-9a7d-d5da7ea043bd"), "The Queens of the Night have won their own measure of power in Hell.", "Queens of the Night" },
                    { new Guid("4d699f44-5321-4d9b-ba78-026c638260e9"), "At the end of the River Styx await the rulers of Abaddon: the Four Horsemen of the Apocalypse and their daemonic brood. Hatred for living things fuels all of daemonkind, who see existence as a great mistake. Though all of the Horsemen began their lives as mortals, they are completely devoted to the eradication of reality itself. Riding atop their dreaded steeds, they strive for true apocalypse. Only when all life has been snuffed out does their mission end, and they can then consign themselves to the waiting oblivion. Only the truly nihilistic worship the Horsemen. Those who seek vengeance on all the world or lust for power are drawn to the Horsemen's easy promises, thinking they will be spared from their masters' cataclysmic mission. They never are. To the Horsemen, their followers are entirely disposable, tools with a purpose until they too are devoured.", "Horsemen" },
                    { new Guid("21e59657-5e46-4c14-87ac-a7349f030f19"), "The traditional deities of the elven pantheon are Calistria, Desna, Findeladlara (goddess of twilight and traditional art and architecture), Ketephys (god of hunting and the moon), and Yuelral (goddess of gems, craft, and magic). Elves have also adopted Alseta, a minor goddess of doors and transitions, as their patron of teleportation and aiudara (commonly known as elf gates). Most elves value magic, beauty, freedom, and friendship as part of a fulfilling life and tend to worship all of the deities together as exemplars of these values. Alongside fullblooded elves, many half-elves—whether raised by elves or seeking a closer connection to their elven heritage— worship the elven pantheon.", "Elven Gods" },
                    { new Guid("88b9adbd-19a6-43ae-8086-01688c9c84b2"), "Born amid the primal chaos of the multiverse's earliest days, the eight elemental lords are divine embodiments of the Inner Spheres' raw elemental forces. With two lords of air, two of earth, two of fire, and two of water, half their number represent the aspects of each element that mortals consider benevolent, while the others represent the malicious and destructive aspects of those same elements. When the Material Plane was born, the benevolent elemental lords seeded it with all the potential of their elements, creating planets, stars, oceans, and life. Yet as mortality evolved, it began harnessing the elements for malevolent purposes, causing anguished dissent between the benevolent elemental lords and emboldening their evil counterparts. Kelizandri, the fearsome lord of water, forged an alliance with the other evil elemental lords— Ayrzul, Hshurha, and Ymeri—to seal each good elemental lord in a prison penetrable only by combining the other three elemental powers once more; this feat has been achieved only once in the ages since. The four surviving lords have ruled their respective planes mercilessly for time uncounted, free to write the stories of their own creations, invent their own titles of nobility, and claim sole dominion over the elemental planes.", "Elemental Lords" },
                    { new Guid("e2cdeaf6-9ea1-464c-aa82-045d042da2b5"), "When the gods abandoned the First World—their initial rough draft of creation shaped in distant prehistory— native beings of incredible power stepped in to fill the vacuum. These beings, called the Eldest, hold deific power over the First World but have little of the other gods' aspirations. The Eldest don't concern themselves with expanding their followings or advocating particular ideologies. Many barely acknowledge their worshippers at all, concerning themselves only with their own mysterious motivations and doling out divine power merely because they have much to spare and doing so amuses them.", "Eldest" },
                    { new Guid("cfa57951-60a1-48eb-9ac7-ff5ac36c8b02"), "The dwarven gods are one large family, with Torag as its patriarch. He is joined by his brothers Magrim (the Taskmaster) and Angradd (the Forge Fire), his half-sister Dranngvit (the Debt Minder), and his wife Folgrit (the Watchful Mother). His children are Bolka (the Golden Gift), Grundinnar (the Peacemaker), Kols (the Oath-Keeper), and Trudd (the Mighty). Torag's evil former student Droskar (the Dark Smith), though technically part of the dwarven pantheon, is rarely invoked by any save duergars.", "Dwarven Gods" },
                    { new Guid("141f20fa-a6a8-4ac7-88b8-edb2badc5b90"), "The Outer Rifts of the Abyss consist of unending layers of evil and depravity, many of which are ruled over by powerful, unique fiends known as demon lords. These demigods have risen above their peers through strength, cunning, or an unmatched capacity for cruelty, overseeing innumerable lesser demons that serve, fear, and revile them. Beneath them, yet more demons clamor to attain their heights of power as nascent demon lords, waiting for the right opportunity to complete their ascension. Fortunately for the mortals of the world, while the ranks of the demon lords are numerous beyond comprehension, only a small subset have so intensely turned their baleful gazes toward Golarion as to have a presence on the planet. These demon lords are served by vile cults that commit atrocities and blasphemies in exchange for power, wealth, and the opportunity to indulge their hearts' darkest desires.", "Demon Lords" },
                    { new Guid("dd52c19b-ce83-4e46-ae17-6560d42c8c1a"), "Each archdevil holds uncontested rule over one of the first eight realms of Hell.", "Archdevils" },
                    { new Guid("064c64d0-17be-4237-89b0-f04cf6e0fbfe"), " No official description was provided.", "Ancient Osirian Gods" },
                    { new Guid("d4f49f9c-0107-478c-9d21-c9c5214e76bb"), "These deities are not quite as widely worshiped as the 20 primary deities of the Inner Sea region, though they grant their worshippers just as much power and are just as important in their worshippers' lives.", "Other Gods" },
                    { new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "The 20 primary deities of the Inner Sea region are well known due to either widespread worship or their historical tendency to help or harm the people who live there.", "Gods of the Inner Sea" },
                    { new Guid("50493d06-f3a6-4247-abb8-58202aa07447"), "Much as demon lords and archdevils are the preeminent incarnations of malice and sin, on the side of righteousness stand the empyreal lords—exceptional beings that represent the good in the myriad everyday actions of the multiverse. Drawn from the most powerful ranks of the celestial host, the multitudinous empyreal lords include agathions, angels, archons, and azatas alike. Most of these beings gained prominence as immortal champions of virtue, though some are instead mortal paragons who ascended, while others spontaneously formed from exceptional deeds of good that echoed throughout the planes. While all empyreal lords are dedicated to good, their philosophies, interests, and personalities vary, and they don't always agree with one another. Worship of the empyreal lords is not nearly as widespread as that of the major deities, but it is still surprisingly common. Most worship takes place at small shrines, statues, or artifacts (such as the sculpture known as the Mistress of Angels in Magnimar), or simply through the doing of deeds that reflect an empyreal lord's interest or beliefs. Centers of worship like churches or cathedrals are extremely uncommon. Most followers consider worship to be an individual matter, and it is rare to see a follower of any empyreal lord proselytizing. However, adherents sometimes congregate in small groups called mystery cults, and some of these groups maintain small temples. The city of Magnimar is home to several mystery cults, as the Varisian people have long held the empyreal lords in high esteem. It is not uncommon for mystery cultists to worship multiple empyreal lords in various combinations, or even all of them, though most have a favorite patron.", "Empyreal Lords" }
                });

            migrationBuilder.InsertData(
                table: "DivineFonts",
                columns: new[] { "Id", "DeitiesId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be"), null, "You gain additional spell slots each day at your highest level of cleric spell slots. You can prepare only harm spells (page 343) in these slots, and the number of slots is equal to 1 plus your Charisma modifier.", "Harm" },
                    { new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653"), null, "You gain additional spell slots each day at your highest level of cleric spell slots. You can prepare only heal spells (page 343) in these slots, and the number of slots is equal to 1 plus your Charisma modifier.", "Heal" }
                });

            migrationBuilder.InsertData(
                table: "Domains",
                columns: new[] { "Id", "DeitiesId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("d3a39e59-080b-4324-8921-124763c5b6af"), null, "You harness the power of the sun and other light sources, and punish undead.", "Sun" },
                    { new Guid("4387ee8e-ad61-4d20-817a-deeebc8bb1da"), null, "You ease mental burdens", "Repose" },
                    { new Guid("9eafb500-89d8-46ff-b315-856f11aca152"), null, "You ward yourself and others.", "Protection" },
                    { new Guid("8eb27986-a0a7-433c-90b0-fe992c088bfe"), null, "You strive to perfect your mind, body, and spirit.", "Perfection" },
                    { new Guid("62a8bd3c-1541-43a7-b1ab-5e4c0b63be84"), null, "You command powers associated with the moon.", "Moon" },
                    { new Guid("526ee5b8-2123-45ea-9711-123252645561"), null, "You punish those who displease you with the sharp sting of pain.", "Pain" },
                    { new Guid("9cc28967-eeee-4300-8723-a1fb61075bbc"), null, "You fill minds with horror and dread.", "Nightmares" },
                    { new Guid("ab621b51-801a-4e47-9581-c7fa211731b3"), null, "You hold power over animals and plants.", "Nature" },
                    { new Guid("da053ff5-4d67-4b00-bce6-19eb9a5f94bd"), null, "You command the power of the stars.", "Star" },
                    { new Guid("e3128860-aa47-47ac-a090-8252e83cec96"), null, "You evoke passion, whether as love or lust.", "Passion" },
                    { new Guid("4c7d189c-915f-4c09-b711-fa65a68a34d7"), null, "You exert control over masses of creatures.", "Swarm" },
                    { new Guid("3c78a88a-9b78-4dc7-8f97-231a5788714e"), null, "You wield power to rule and enslave others.", "Tyranny" },
                    { new Guid("3658060d-b09b-4e73-b949-0255b77bd07b"), null, "You reign over the flow of time.", "Time" },
                    { new Guid("1a434308-2ec6-4963-aa14-b82efa52fb98"), null, "You have power over movement and journeys.", "Travel" },
                    { new Guid("ce60c9f8-e9a7-42e2-87e5-5d7e5210dbfa"), null, "You deceive others and cause mischief.", "Trickery" },
                    { new Guid("833f560a-af75-49c8-8da6-d4e15a6a18a0"), null, "You pierce lies and discover the truth.", "Truth" },
                    { new Guid("8e2fe9d1-c723-4754-8cb3-8955bb0094fc"), null, "Your magic carries close ties to the undead.", "Undeath" },
                    { new Guid("c803d19e-6341-4d09-b96f-2926c23c6bcf"), null, "You watch over those long passed and guard their secrets.", "Vigil" },
                    { new Guid("611f0345-55bd-4632-9bfc-b10a5cf64491"), null, "You draw power from emptiness.", "Void" },
                    { new Guid("e41819f7-aa1b-416f-99c5-62bde7886a79"), null, "You control water and bodies of water.", "Water" },
                    { new Guid("794329a6-ca37-4ec4-b3bf-e979c639d628"), null, "You hold power over wealth, trade, and treasure.", "Wealth" },
                    { new Guid("1fc1a8d3-cf3d-4e81-a1d5-f737a2e747f6"), null, "Your inner fire increases your combat prowess.", "Zeal" },
                    { new Guid("175bf44e-7909-46eb-b135-a7e97297d8df"), null, "You wield power over the spiritual..", "Soul" },
                    { new Guid("3eb1a047-7ae9-481b-a9ab-675684b2a67e"), null, "Your physical power is bolstered by divine strength.", "Might" },
                    { new Guid("433f01f4-387d-4cb7-b327-2b63bf21c16c"), null, "You protect secrets and keep them hidden.", "Secrecy" },
                    { new Guid("8ab289e9-baf0-407e-80af-280774a66c15"), null, "You control electricity, thunder, and storms.", "Lightning" },
                    { new Guid("09797fbb-48b5-42fa-abf3-5468c06dbbce"), null, "You can control winds and the weather.", "Air" },
                    { new Guid("768a6f8b-75cb-4439-a95a-1a41ef36abd8"), null, "You have powers over urban environments and denizens.", "Cities" },
                    { new Guid("3020bd98-a4f8-4e92-9c92-58110679137f"), null, "You overcome your fear and project pride.", "Confidence" },
                    { new Guid("eceea1c6-3be5-49dd-bfb4-fca321132069"), null, "You control ice, snow, and freezing temperatures.", "Cold" },
                    { new Guid("0b2dd6ec-60ae-4cab-ade5-b5bccdc8a993"), null, "You have divine abilities related to crafting and art.", "Creation" },
                    { new Guid("9c5f23af-1bf7-46c8-bdba-8067b03f752f"), null, "You can restructure the physical and metaphysical.", "Change" },
                    { new Guid("c750af99-1697-4c06-abb1-cb91bc2f8099"), null, "You operate in the darkness and take away the light.", "Darkness" },
                    { new Guid("21481675-8a0d-4e7c-a373-fad64f4c14e7"), null, "You have the power to end lives and destroy undead.", "Death" },
                    { new Guid("ab698922-2a43-4eb1-a400-2b96abcbb255"), null, "You have the power to spoil and deteriorate matter.", "Decay" },
                    { new Guid("d09b4a1e-21fd-4dda-9fe6-8679bd6e3eef"), null, "You are a conduit for divine devastation.", "Destruction" },
                    { new Guid("e214011e-7af3-4a53-9b4a-e0ed7ae4479a"), null, "You have the power to enter and manipulate dreams.", "Dreams" },
                    { new Guid("78d1b6a0-7f67-4e3c-a25c-dbf4aa4cd838"), null, "You strive to keep up with and outpace the competition.", "Ambition" },
                    { new Guid("41f79fe2-6ac6-42ec-a69c-15046cd962f4"), null, "You control soil and stone.", "Earth" },
                    { new Guid("ef17f4d2-95cd-4561-86fc-487a749244e4"), null, "You defend oaths and carry out your divine missions with great dedication.", "Duty" },
                    { new Guid("87a70253-a298-467a-92e1-a3be315e34b0"), null, "You’re unnaturally lucky and keep out of harm’s way.", "Luck" },
                    { new Guid("a434a214-22db-4d03-bd31-d2af7f4c4f76"), null, "You receive divine insights.", "Knowledge" },
                    { new Guid("7463725f-9db1-45ce-8bde-57857ab6a2f9"), null, "You feast mightily and can shake off the effects of overindulging.", "Indulgence" },
                    { new Guid("3b1c75b0-524c-4a08-b04b-9e66b69b42fc"), null, "Your healing magic is particularly potent.", "Healing" },
                    { new Guid("9eadaa7c-bb04-4017-a31c-77a5355e0d2c"), null, "You perform the unexpected and inexplicable.", "Magic" },
                    { new Guid("216d5607-4d52-4581-a669-06d0f2773b65"), null, "You liberate yourself and others from shackles and constraints.", "Freedom" },
                    { new Guid("f1a372b7-a9bc-4571-b0ca-69780008e40a"), null, "You control flame.", "Fire" },
                    { new Guid("696cb38a-1f8f-4506-b3e6-06c5b5e802af"), null, "You see and understand hidden inevitabilities.", "Fate" },
                    { new Guid("bc369149-d7c5-4319-b7d8-8137f9cfdcd8"), null, "You wield power over written words and symbols.", "Glyph" },
                    { new Guid("49ba8be3-a11f-4d61-9b64-d8d1fd208ffe"), null, "You aid and protect your family and community more effectively.", "Family" }
                });

            migrationBuilder.InsertData(
                table: "FeatTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c15fb53a-0b27-47c1-8ef4-eba2d982075c"), "Heritage" },
                    { new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), "General" },
                    { new Guid("cc6e0f95-a0f4-4521-9c53-7f3484be3530"), "Class" }
                });

            migrationBuilder.InsertData(
                table: "Frequencies",
                columns: new[] { "Id", "Amount", "Name", "TimeSpan" },
                values: new object[,]
                {
                    { new Guid("aa64b0f6-fb62-4af8-bba8-a174f19a1b73"), 1, "Once per ten minutes.", new TimeSpan(0, 0, 10, 0, 0) },
                    { new Guid("7d26de34-8d31-4b00-8ce8-3d2712c2ee3d"), 1, "Once per round.", new TimeSpan(0, 0, 0, 6, 0) },
                    { new Guid("effdc3c2-b381-4a3b-883c-12c9e9479878"), 1, "Once per hour.", new TimeSpan(0, 1, 0, 0, 0) },
                    { new Guid("e1160af3-7dae-49e2-bacf-2d558be08fd6"), 1, "Once per day.", new TimeSpan(1, 0, 0, 0, 0) },
                    { new Guid("6d3d62d7-9630-4933-9db4-983720eb6042"), 2, "Twice per day.", new TimeSpan(1, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "HeritageRarities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7eb0082a-50c0-44ef-a990-7aae6cb9cf27"), "Uncommon" },
                    { new Guid("6ccbbd83-6da1-488b-9a1f-9a658fcdbd84"), "Rare" },
                    { new Guid("8def5893-8645-4396-9692-cebfad1ea649"), "Unique" },
                    { new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807"), "Common" }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "Id", "Description", "Name", "PageNumber" },
                values: new object[,]
                {
                    { new Guid("d907ade1-335e-48cd-9e9f-d407d11fd82b"), "Consist of a vast collection of clothing and other items you wear on your body.", "Worn Items", 603 },
                    { new Guid("8a494ffa-3f11-4e4e-9373-b376942fc75d"), "Modify armor and weapons when etched onto them. This section includes fundamental runes for weapons (weapon potency and striking) and armor (armor potency and resilient).", "Runes", 580 },
                    { new Guid("7c5752cf-64d2-4d3e-a4ba-604969266172"), "The rules for basic magical weapons, weapons made from precious materials, and specific magic weapons.", "Weapons", 599 },
                    { new Guid("8f737ba1-e70a-4583-b55c-cc874f0f5660"), "Hold a spell of the crafter’s choice, and can be used to repeatedly cast that spell.", "Wands", 597 },
                    { new Guid("559392e9-b613-46bd-87d8-e7f74a6c5d56"), "Consumables that are affixed to items and then activated for a one-time combat or physical benefit.", "Talismans", 565 },
                    { new Guid("680c5c0f-dc56-4937-a179-b78c90a94164"), "Buildings, tents, and other larger items.", "Structures", 596 },
                    { new Guid("64a4ddc3-6da3-475e-a65c-dafc742dfea7"), "Provide flexible spellcasting options.", "Staves", 592 },
                    { new Guid("4557c11d-e0fb-40ee-8b3c-b6c3340fc151"), "Single-use traps typically made by rangers.", "Snares", 589 },
                    { new Guid("eed4990e-e635-4683-a920-1937bf9736f2"), "More durable shields and ones with special magical powers.", "Shields", 586 },
                    { new Guid("44429e3b-ba5c-4733-826b-2a21758ebfca"), "Consumables that allow spellcasters to cast more spells.", "Scrolls", 564 },
                    { new Guid("f18f1a5c-790a-42ce-b629-1db465289c25"), "Consumable magical liquids you drink to activate.", "Potions", 562 },
                    { new Guid("9229852f-02cb-43d5-ae10-c1ab7bc66cfa"), "Can be used to make items with unique properties and other advantages.", "Materials", 577 },
                    { new Guid("40c1e3c7-9870-4c2d-a45f-0f70f0d8139f"), "Powered by the reactions of alchemical reagents. Almost all alchemical items are consumable items that are used up when you activate them. This category includes bombs, elixirs (including mutagens), poisons, and alchemical tools.", "Alchemical Items", 543 },
                    { new Guid("a3d34e6e-4c6e-4351-8b66-3e9faf08ca8f"), "Includes different types of magical arrows, crossbow bolts, and other types of ammunition.", "Ammunition", 559 },
                    { new Guid("76b819ea-1c05-4a54-9b9a-3528535e8b68"), "A subcategory of worn items of a high level that increase an ability score.", "Apex Items", 603 },
                    { new Guid("cea8ef00-93a9-4657-a712-c4904a79a6c7"), "Consumables applied to the surface of an object or person.", "Oils", 561 },
                    { new Guid("60022ff2-b13c-4a74-a82f-a084b5b9f44e"), "A category of worn items meant for animal companions and mounts.", "Companion Items", 604 },
                    { new Guid("14299b81-a8c5-4136-b230-ecbb7653a150"), "Used up when you activate them, and include ammunition, oils, potions, scrolls, and talismans, among others. Categories of items that are consumables but have specific rules, such as alchemical items, are presented separately.", "Consumables", 559 },
                    { new Guid("4346421f-aa3b-46aa-8783-3bdb5095df43"), "A wide variety of items you use with your hands. This doesn’t include more narrow categories of held items, such as weapons.", "Held Items", 572 },
                    { new Guid("5d8aa60d-58e9-425a-9c92-0cac9eb5202d"), "Includes the rules for basic magical armor as well as special suits of armor.", "Armor", 555 }
                });

            migrationBuilder.InsertData(
                table: "LanguageTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac"), "Common" },
                    { new Guid("9e4b5cea-7c60-4396-aa80-307379d155ab"), "Secret" },
                    { new Guid("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0"), "Regional" },
                    { new Guid("705b76de-5a42-4e7b-aaf2-16feb7b232d0"), "Sign" },
                    { new Guid("ddd66834-fd35-4361-b798-c389e81b12a0"), "Uncommon" }
                });

            migrationBuilder.InsertData(
                table: "MagicEssences",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("c02c29d8-351b-4690-bfd6-85447ee129e1"), "Also called body, material essence, or physical essence, matter is the fundamental building block that makes up all physical things in the universe. The arcane and primal traditions are especially attuned toward manipulating and shaping matter. Spells that are used to create or alter matter most often come from the conjuration, evocation, or transmutation schools.", "Matter" },
                    { new Guid("3a378975-c527-4240-a39c-4b854bc00573"), "Also called soul, ethereal essence, or spiritual essence, spirit is an otherworldly building block that makes up a being’s immaterial and immortal self. The spirit travels through the Ethereal Plane and into the Great Beyond after the death of the physical body. The spirit is most easily affected by divine and occult spells. Spirit spells are usually of the divination or necromancy schools.", "Spirit" },
                    { new Guid("b5228b30-f243-4ad2-94f4-499eb98919ac"), "Also called thought, mental, or astral essence, mind is what allows thinking creatures to have rational thoughts, ideas, plans, logic, and memories. Mind touches even nonsapient creatures like animals, though in a more limited capacity. Arcane and occult casters usually excel at mind spells. Spells that use mind essence are usually found in the divination, enchantment, and illusion schools.", "Mind" },
                    { new Guid("044429ac-181c-46a8-b031-c163ae407509"), "Also called heart, faith, instinct, or vital essence, life represents the animating universal force within all things. Whereas matter provides the base materials for a body, life keeps it alive and well. This essence is responsible for unconscious responses and belief, such as ancestral instincts and divine guidance. The divine and primal traditions hold power over life. Life spells are usually necromancy.", "Life" }
                });

            migrationBuilder.InsertData(
                table: "MagicSchools",
                columns: new[] { "Id", "Abbreviation", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("ab0fac81-a9ed-410e-9886-99923111080a"), "TRA", "Transmutation spells make alterations to or transform the physical form of a creature or object.The morph and polymorph traits appear primarily in transmutation spells.", "Transmutation" },
                    { new Guid("dd5fe60b-e821-4f80-86cb-ed5a9791d1e7"), "ILL", "Illusions create the semblance of something real, the eyes, ears, and other senses.Depending on how the illusion is perceived, it might have the auditory or traits, and some also have the mental trait.", "Illusion" },
                    { new Guid("fe316215-5436-422b-bd3f-c499d05b5b99"), "NEC", "Necromancy spells harness the power of life and death. They can sap life essence or sustain creatures with life-saving healing. Necromancy spells often have the curse, death, healing, negative, or positive traits.", "Necromancy" },
                    { new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "EVO", "Evocations capture magical energy and then shape it to harm your foes or protect your allies. Evocation spells often have a trait that comes from the type of damage they deal, such as acid, cold, fire, force, or sonic.", "Evocation" },
                    { new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "DIV", "Divinations allow you to learn the secrets of the present, past, and future.They bestow good fortune, grant you the ability to perceive remote locations, and reveal secret knowledge. Divinations often have the detection trait if they find something, the prediction trait if they grant you insight about what might happen in the future, the revelation trait if they show things as they truly are, or the scrying trait if they let you perceive another location.", "Divination" },
                    { new Guid("1c401dd4-21d6-477d-9ca1-1a6a9d1a8a0d"), "CON", "Conjuration spells transport creatures via teleportation, create an object, bring a creature or object from somewhere else (typically from plane) to follow your commands Conjuration spells often have the teleportation trait, and creatures summoned by conjuration spells have the summoned trait.", "Conjuration" },
                    { new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "ABJ", "Abjurations protect and ward. They create barriers that keep out attacks effects, or even certain types of creatures. They also create effects that harm trespassers or banish interlopers.", "Abjuration" },
                    { new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "ENC", "Enchantments affect the minds and emotions of other creatures—sometimes to influence and control them, and other times to bolster them to greater heights of courage. Enchantment spells almost always have the mental trait, and many have the emotion trait or the fear trait.", "Enchantment" }
                });

            migrationBuilder.InsertData(
                table: "MagicTraditions",
                columns: new[] { "Id", "Description", "Name", "SpellsId" },
                values: new object[,]
                {
                    { new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e"), "Arcane spellcasters use logic and rationality to categorize the magic inherent in the world around them. Because of its far-reaching approach, the arcane tradition has the broadest spell list, though it’s generally poor at affecting the spirit or the soul. Wizards are the most iconic arcane spellcasters, poring over tomes and grimoires, though arcane sorcerers study the secrets of their blood to unlock the power within themselves.", "Arcane", null },
                    { new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698"), "The power of the divine is steeped in faith, the unseen, and belief in a power source from beyond the Material Plane. Clerics are the most iconic divine spellcasters, beseeching the gods to grant them their magic. Divine sorcerers can use the blood of their celestial or fiendish ancestors as a divine conduit, and champions call upon their gods to grant them martial prowess through divine guidance.", "Divine", null },
                    { new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8"), "The practitioners of occult traditions seek to understand the unexplainable, categorize the bizarre, and otherwise access the ephemeral in a systematic way. Bards are the most iconic occult spellcasters, collecting strange esoterica and using their performances to influence the mind or elevate the soul, and occult sorcerers strive to understand the mysterious power in their blood.", "Occult", null },
                    { new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b"), "An instinctual connection to and faith in the world, the cycle of day and night, the turning of the seasons, and the natural selection of predator and prey drive the primal tradition. Druids are the most iconic primal spellcasters, calling upon the magic of nature through deep faith and a connection to the plants and animals around them, and primal sorcerers call upon their fey or beast blood to harness the same natural energies.", "Primal", null }
                });

            migrationBuilder.InsertData(
                table: "PlaneCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("c64c6e93-aa40-4010-8fbc-592c1f0e017a"), "The planes of the Outer Sphere are the manifest realms of alignment: chaos, evil, good, law, neutrality, and their admixtures, populated by celestials, fiends, monitors, and others who promote these moral concepts. These planes are the backdrop upon which the mortal afterlife reaches its apparent conclusion, and the end destination of the River of Souls. The Outer Planes are regions of stability adrift in the raw, chaotic quintessence of the primordial Maelstrom, its tides forever gnawing at their edges even as mortal souls sustain them. The Abyss manifests as cracks in the Outer Sphere’s fabric, while rising from the metropolitan Axis is the Boneyard’s spire, the location where mortal souls are judged and then sent to their final destinations, be they reward, suffering, or oblivion. The Outer Planes are places of majesty, wonder, terror, and danger outstripping anything mortal adventurers might encounter anywhere else.", "Outer Sphere Plane" },
                    { new Guid("a1485da2-c025-45cd-bc59-f08fe12b7d5b"), "At a minimum, each Transitive Plane coexists with one or more other planes, a relationship oversimplified by stating that Transitive Planes are just used to get from one plane to another. The mists of the Ethereal Plane overlap the planes of the Inner Sphere, while the Astral Plane borders every other plane in existence like the backstage of the cosmos. Bright and dark mirrors of the Material Plane, the First World and Shadow Plane overlap the mortal world, albeit often in bizarre ways such that a short distance in one might be a vast gulf in the other. The daring, wise, or desperate can utilize these planes to bypass barriers in the Material Plane or rapidly cross vast distances through much swifter travel.", "Transitive Plane" },
                    { new Guid("906654b0-cf06-4b89-981b-07b50afa956d"), "Existing in the metaphorical space between the Transitive Planes and smaller, finite demiplanes, dimensions are a category unto themselves, defying the neat categorization of planar scholars and adventurers. Seemingly infinite in scale, not necessarily spatial in the same way as a plane, and overlaying every other plane at once—including one another—dimensions and planes are most significantly differentiated in how each of them breaks the commonly held rules of the other. Although some scholars include other extraplanar realms within the ranks of dimensions, only two such realms are uniformly agreed upon and classified as such. The Dreamlands, also known as the Dimension of Dreams, is readily accessed by mortal dreamers, while the Dimension of Time is notorious for the near impossibility of accessing it as well as the bizarre, often deadly restrictions upon travel to and within its bounds.", "Dimension" },
                    { new Guid("3bbe8661-ea39-4b26-8723-eb04b151062f"), "The planes of the Inner Sphere form the heart of the cosmos. They are the home of mortal life, the focus of divine attention, the source of mortal souls, and the origin point of the great cycle of quintessence that fuels the motions and stability of reality itself. Arranged in a nested series of shells, like layers of an onion, the planes of the Inner Sphere include, from outer to inner: the Elemental Planes of Fire, Earth, Water, and Air; the universe of the Material Plane; and at the very core of this cosmological ensemble, the raw forces of creation and destruction of the Positive and Negative Energy Planes.", "Inner Sphere Plane" }
                });

            migrationBuilder.InsertData(
                table: "PlaneTraits",
                columns: new[] { "Id", "Description", "Name", "PlanesId" },
                values: new object[,]
                {
                    { new Guid("8112fec1-79be-4738-9dc1-d98222fc1a6f"), "Objects remain where they are (and what they are) unless affected by physical force or magic. Creatures can change the immediate environment as a result of tangible effort, such as by digging a hole.", "Metamorphic", null },
                    { new Guid("7b459163-b6bf-4471-976f-3489eab76349"), "Planes with this trait loop back on themselves when a creature reaches the plane’s edge.", "Unbounded", null },
                    { new Guid("97dd8e80-f871-4a0b-943c-c6fc6b532d81"), "Planes with this trait are umbral with murky light. On a shadow plane, the radius of all light from light sources and the areas of light spells are halved. Darkness and shadow magic are enhanced, and light magic is impeded.", "Shadow", null },
                    { new Guid("348aeff9-7683-4763-b61d-79cba5b4547d"), "These planes are awash with life energy. Colors are brighter, fires are hotter, noises are louder, and sensations are more intense. At the end of each round, an undead creature takes at least minor positive environmental damage. In the strongest areas of a positive plane, they could take moderate or even major positive damage at the end of each round. While this might seem safe for living creatures, positive planes present a different danger. Living creatures regain an amount of HP each round equal to the environmental damage undead take in the same area. If this would bring the living creature above their maximum HP, any excess becomes temporary HP. Unlike normal, these temporary HP combine with each other, and they last until the creature leaves the plane. If a creature’s temporary HP from a positive plane ever exceeds its maximum HP, it explodes in a burst of overloaded positive energy, spreading across the area to birth new souls. Positive magic is enhanced, and negative magic is impeded.", "Positive", null },
                    { new Guid("e7f12fc2-3003-4472-9ff0-904a838e1e75"), "Planes with this trait are vast, empty reaches that suck the life from the living. They tend to be lonely, haunted planes, drained of color and filled with winds carrying the moans of those who died within them. At the end of each round, a living creature takes at least minor negative environmental damage. In the strongest areas of a negative plane, they could take moderate or even major negative damage at the end of each round. This damage has the death trait, and if a living creature is reduced to 0 Hit Points by this negative damage and killed, it crumbles into ash and can become a wraith (Bestiary 335). Negative magic is enhanced, and positive magic is impeded.", "Negative", null },
                    { new Guid("83998080-dd80-4522-b1ef-75c6918c35ff"), "These planes are mostly liquid. Visitors who can’t breathe water or reach an air pocket likely drown. Water magic is enhanced, and fire magic is impeded. Creatures with a weakness to water take damage equal to double their weakness at the end of each round.", "Water", null },
                    { new Guid("a415e74d-e174-4573-b311-c02ea2fc2875"), "Planes with this trait are composed of flames that continually burn with no fuel source. Fire planes are extremely hostile to non-fire creatures. Unprotected wood, paper,cloth, and other flammable materials catch fire almost immediately, and creatures wearing unprotected flammable clothing catch fire, typically taking 1d6 persistent fire damage.Extraplanar creatures take moderate environmental fire damage at the end of each round(sometimes minor environmental damage in safer areas, or major or massive damage in even more fiery areas).Fire magic is enhanced, and cold and water magic are impeded.Water creatures are extremely uncomfortable on a fire plane, and any natural resistance they have against fire doesn’t function against this environmental fire damage.", "Fire", null },
                    { new Guid("9740e5d6-b49e-4827-8962-e70ffaa4e8be"), "These planes are mostly solid. Travelers arriving upon an earth plane risk suffocation if they don’t reach a cavern or some other air pocket within the plane’s solid matter. Creatures who can’t burrow are entombed in the plane’s substance and must attempt to dig their way toward an air pocket. Earth magic is enhanced, and air magic is impeded. Air creatures are ill at ease, as they rarely have the space to move freely through even the most lofty warrens.", "Earth", null },
                    { new Guid("76206317-bdb6-4f71-b4c6-6536d06172d9"), "Planes with this trait consist mostly of open spaces and air of various levels of turbulence, though they also contain rare islands of floating stone and other elements and energies. Air planes usually have breathable atmospheres, though they may include clouds of acidic or toxic gas. Air magic is enhanced, and earth magic is impeded. Earth creatures often find themselves at a disadvantage within air planes, which tend to at least make them uncomfortable, as there is little solid ground for them to gain their bearings.", "Air", null },
                    { new Guid("c5358cea-44ea-4ef0-b6eb-281bdbc80e2a"), "Visitors can’t affect living residents of the plane or objects the denizens carry in any way. Any spells that would affect those on the plane have no effect unless the static trait is somehow removed or suppressed.", "Static", null },
                    { new Guid("9c610160-b8ea-4d22-833b-f3dd8bf068c1"), "The plane changes based on its own whims.", "Sentient", null },
                    { new Guid("eba4f250-66db-48f2-b902-1398ba91a753"), "Time still passes, but the effects of time are diminished. Creatures on these planes don’t feel hunger, thirst, or the effects of aging or natural healing. The effects of poison, diseases, and other kinds of healing may also be diminished on certain timeless planes. Spell energy and other effects still dissipate, so the durations of spells and other effects function as normal. The danger of this trait is that when a creature leaves a timeless plane and enters a plane with another time trait, the effects of hunger, thirst, aging, and other effects slowed or arrested by the timeless trait occur retroactively in the instant of transition, possibly causing the creature to immediately starve or die of old age.", "Timeless", null },
                    { new Guid("75c056af-e3c7-4c22-866a-f27533399b6b"), " As in normal gravity, bodies of great mass act as centers of gravity, but the force relative to the size of the body is greater than on the Material Plane. The Bulk of all creatures and objects is doubled, meaning creatures acclimated to normal gravity can carry only half as much. Creatures used to normal gravity move at half Speed and can jump only half as high and far. Physical ranged attacks are impossible beyond the third range increment (instead of the sixth). Creatures that fall in high gravity take bludgeoning damage equal to the distance they fell.", "High Gravity", null },
                    { new Guid("2556952c-915d-4bc6-85f2-39b640854c9b"), "Time slows down and speeds up, so an individual may lose or gain time as they move between planes. When a creature moves from a plane with erratic time to one with normal time, roll a DC 11 flat check. Creatures that leave an erratic time plane together share the same result.", "Erratic Time", null },
                    { new Guid("5dca1675-95f7-4411-b1c3-307e98aaf2c7"), " Time passes the same way it does on the Material Plane. One hour on a plane with normal time equals 1 hour on the Material Plane.", "Normal Time", null },
                    { new Guid("5f8d1fc6-5199-4c64-9633-f22db88b0b9e"), "All bodies of mass can be centers of gravity with the same force, but only if a non-mindless creature wills it. Unattended items, objects, and mindless creatures treat the plane as having microgravity. Creatures on a plane with subjective gravity can move normally along a solid surface by imagining “down” near their feet. Designating this downward direction is a free action that has the concentration trait. If suspended in midair, a creature can replicate flight by choosing a “down” direction and falling in that direction, moving up to their Speed or fly Speed. This pseudo-flight uses the Fly action.", "Subjective Gravity", null },
                    { new Guid("fe17801c-43b7-4bbc-802d-40e2bc8b4b5b"), "All bodies of mass are centers of gravity with roughly the same force. A creature can stand on any solid objects that is as large as or larger than themself.", "Strange Gravity", null },
                    { new Guid("f3d65fdd-a015-4432-a2bd-5f85b00159a3"), "There is little to no gravity on this plane. Creatures float in space unless they can push off a surface or use some force to propel themselves throughout the plane.", "Microgravity", null },
                    { new Guid("9cb4a5c0-d672-47f3-9d21-6b91c5714d5b"), "As in normal gravity, bodies of great mass act as centers of gravity, but the force relative to the size of the body is less than on the Material Plane. The Bulk of all creatures and objects is halved, meaning creatures acclimated to normal gravity can carry twice as much and jump twice as high and far. Physical ranged attacks are possible up to the twelfth range increment (instead of the sixth). Creatures that fall in low gravity take no damage for the first 10 feet of a fall, and then take bludgeoning damage equal to a quarter of the remaining distance it fell.", "Low Gravity", null },
                    { new Guid("ccc03793-3fbe-4947-b411-96b49613e5c6"), "Planes with this trait have a flow of time that is consistently faster or slower than that of other planes", "Flowing", null },
                    { new Guid("48204675-e1dd-4ec1-89d6-7fee012a50d5"), "Bodies of great mass are the centers of gravity, and objects fall toward those centers with a measured amount of force relative to the size of the body.", "Normal Gravity", null },
                    { new Guid("2f525514-878f-4127-a702-b349b9bfb777"), "Most planes are immeasurable, so immense they are impossible to quantify. Which immeasurable planes, if any, are infinite is a subject of debate among philosophers and scholars alike. Since so many planes are immeasurable, those planes omit a scope trait. Otherwise, the plane likely has either the finite or unbounded trait.", "Scope", null },
                    { new Guid("b04c60f8-feab-4d1f-964c-63674f871191"), "Certain planes, particularly in the Outer Sphere, are attuned to an alignment. Most inhabitants share that alignment— even powerful creatures such as deities. Planes with the neutral alignment trait are more often a mix of alignments than strongly neutral, and planes with no alignment affinity simply don’t have an alignment trait, rather than being neutral. Alignments are given as an abbreviation (Pathfinder Bestiary 345), which appears first in the plane’s list of traits. Spells that share any of the plane’s alignment traits are enhanced, and those with opposing traits are impeded.For instance, in the chaotic evil Abyss, chaotic and evil spells are enhanced, and lawful and good spells are impeded.", "Alignment", null },
                    { new Guid("44acf71b-a1e2-4cb4-9596-dace6c47d0f1"), "Some planes enhance certain magic and impede opposing effects. A plane that enhances a particular type of magic grants anyone Casting a Spell with that trait a +1 circumstance bonus to their spell DC or spell attack roll with that spell. Impeded magic means a character who Casts a Spell or Activates an Item with the specified trait must succeed at a DC 6 flat check or lose the spell or activation.", "Enhanced and Impeded Magic", null }
                });

            migrationBuilder.InsertData(
                table: "Proficiencies",
                columns: new[] { "Id", "Bonus", "Name" },
                values: new object[,]
                {
                    { new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), 8, "Legendary" },
                    { new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), 4, "Expert" },
                    { new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), 6, "Master" },
                    { new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 0, "Untrained" },
                    { new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), 2, "Trained" }
                });

            migrationBuilder.InsertData(
                table: "RaceRarities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("52091c82-7a39-4a66-919e-ac268375b792"), "Common" },
                    { new Guid("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), "Uncommon" },
                    { new Guid("863d10bd-583b-41e9-ae52-2d94cf0a2bff"), "Rare" }
                });

            migrationBuilder.InsertData(
                table: "RaceSizes",
                columns: new[] { "Id", "BreadthReach", "HeightReach", "Name", "Space" },
                values: new object[,]
                {
                    { new Guid("f44c1295-604f-443b-9ecc-870d82264eb5"), 0, 0, "Tiny", 3 },
                    { new Guid("0a06e806-0314-455c-8af8-c81ecc1e0dd2"), 5, 5, "Small", 5 },
                    { new Guid("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991"), 5, 5, "Medium", 5 },
                    { new Guid("abe0e587-0fda-48d3-9206-1d43e727bcab"), 10, 5, "Large", 10 },
                    { new Guid("eba80c08-8f5b-4dee-8d43-f1aa5fc30d8b"), 15, 20, "Huge", 15 },
                    { new Guid("93daa531-f40c-4db8-8cc2-65f8e32b951b"), 20, 15, "Gargantuan", 20 }
                });

            migrationBuilder.InsertData(
                table: "RaceTraits",
                columns: new[] { "Id", "Name", "RacesId" },
                values: new object[,]
                {
                    { new Guid("ca44727c-ddd1-45b3-bb03-2e0cf7c10dc6"), "Catfolk", null },
                    { new Guid("2ee1182b-590e-4ba0-b25a-404ebdfa365d"), "Ratfolk", null },
                    { new Guid("06fa7847-6549-48a9-81cf-54be921e98bb"), "Orc", null },
                    { new Guid("e6ec055e-2598-48c4-b003-2b07f8847a41"), "Kobold", null },
                    { new Guid("aab5afb3-53d2-4b4f-a070-bf6e697844f3"), "Human", null },
                    { new Guid("4f75a119-344a-488a-b905-ed558e450f33"), "Tengu", null },
                    { new Guid("d15ee066-6c0e-4068-825e-79a87e3fecd6"), "Goblin", null },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), "Humanoid", null },
                    { new Guid("21de256c-7e2c-401c-bc8e-d2ad49ac1473"), "Elf", null },
                    { new Guid("6857833c-2458-4ece-b784-69b45a8afa63"), "Halfling", null },
                    { new Guid("5138d6c9-4abf-446c-9e1b-5660a956242a"), "Gnome", null },
                    { new Guid("852a5dc2-9cc6-4fb0-9250-801e27b1f8a3"), "Dwarf", null }
                });

            migrationBuilder.InsertData(
                table: "RollableEffect",
                columns: new[] { "Id", "CriticalFailure", "CriticalSuccess", "Failure", "Success" },
                values: new object[,]
                {
                    { new Guid("9dab564c-885e-492a-a52e-af745342c53d"), null, "As success, but you deal double damage (page 451).", null, "You deal damage according to the weapon or unarmed attack, including any modifiers, bonuses, and penalties you have to damage." },
                    { new Guid("e83cff43-911b-41f0-a5d3-e67bed0ca36b"), "You get a false sense of the creature’s intentions.", "You determine the creature’s true intentions and get a solid idea of any mental magic affecting it.", "You detect what a deceptive creature wants you to believe. If they’re not being deceptive, you believe they’re behaving normally.", "You can tell whether the creature is behaving normally, but you don’t know its exact intentions or what magic might be affecting it." },
                    { new Guid("c6c59505-6b03-46fe-b154-1c303d7176e4"), null, "If you were searching for creatures, any undetected or hidden creature you critically succeeded against becomes observed by you. If you were searching for an object, you learn its location.", null, "If you were searching for creatures, any undetected creature you succeeded against becomes hidden from you instead of undetected, and any hidden creature you succeeded against becomes observed by you. If you were searching for an object, you learn its location or get a clue to its whereabouts, as determined by the GM." },
                    { new Guid("f5c01f9a-15de-47c0-8f65-470f0c4442dd"), "You continue to fall, and if you’ve fallen 20 feet or more before you use this reaction, you take 10 bludgeoning damage from the impact for every 20 feet fallen.", "You grab the edge or handhold, whether or not you have a hand free, typically by using a suitable held item to catch yourself (catching a battle axe on a ledge, for example). You still take damage from the distance fallen so far, but you treat the fall as though it were 30 feet shorter.", null, "If you have at least one hand free, you grab the edge or handhold, stopping your fall. You still take damage from the distance fallen so far, but you treat the fall as though it were 20 feet shorter. If you have no hands free, you continue to fall as if you had failed the check." },
                    { new Guid("6a073760-7f3c-41ea-adbc-276607b88ece"), "The target takes double damage, is stupefied 1 for 1 round, and can’t cast divine spells for 1 round.", "The target is unaffected.", "The target takes full damage; if the target can cast divine spells, it’s stupefied 1 for 1 round.", "The target takes half damage." },
                    { new Guid("3d116422-8cc0-11eb-8dcd-0242ac130003"), null, null, null, "You fall gently, taking no damage from the fall." },
                    { new Guid("5c94d039-e421-42b3-af86-d33a8f266410"), "Your ally takes a –1 circumstance penalty to the triggering check.", " You grant your ally a +2 circumstance bonus to the triggering check. If you’re a master with the check you attempted, the bonus is +3, and if you’re legendary, it’s +4.", null, "You grant your ally a +1 circumstance bonus to the triggering check." },
                    { new Guid("1d9d9b1c-7036-46dd-9067-f132780d776c"), "The creature takes double damage and is enfeebled 2 for 1 minute. On your home plane, a creature that critically fails is banished with the effect of a failed banishment save. A 10th-level creature or lower must attempt a Will save. On a failure, it’s paralyzed for 1 minute; on a critical failure, it dies.", "The creature is unaffected.", "The creature takes full damage and is enfeebled 2 for 1 minute.", "The creature takes half damage." },
                    { new Guid("7c7d9f59-2899-4af7-9596-cf6a7711da5a"), "The creature is also enfeebled 1 for 1 round.", null, null, null },
                    { new Guid("7a397e05-ef94-4531-a4d8-24e4596d37c7"), "The effect’s duration is 1 hour.", "The target is unaffected.", "The effect’s duration is 10 minutes.", "The effect’s duration is 1 minute." },
                    { new Guid("1d97f155-61d4-4e3e-b56a-5db39776f857"), null, "The target is unaffected.", "The target dies.", "The target’s dying value increases by 1." },
                    { new Guid("fa67be43-2108-4e4d-ab58-18edad117031"), "The target is deafened permanently.", "The target is unaffected.", "The target is deafened for 10 minutes.", "The target is deafened for 1 round." },
                    { new Guid("48a3785a-a84b-4290-9316-b41d51744c0a"), "As failure, and the creature is automatically slowed 1 for 1 minute.", "The creature is unaffected.", "As success, but the duration is 1 minute.", "For 1 round, the creature can’t use reactions and must attempt another save at the start of its turn; on a failure, it is slowed 1 for that turn as it sobs uncontrollably." },
                    { new Guid("42f02449-6552-40db-adea-e635cb50c071"), "You don’t get free, and you can’t attempt to Escape again until your next turn.", "You get free and remove the grabbed, immobilized, and restrained conditions imposed by your chosen target. You can then Stride up to 5 feet.", null, "You get free and remove the grabbed, immobilized, and restrained conditions imposed by your chosen target." },
                    { new Guid("c52f431c-b8b3-4c0b-946d-1491a8e5168f"), "The target is confused for 1 minute, with no save to end early.", "The target is unaffected.", "The target is confused for 1 minute. It can attempt a new save at the end of each of its turns to end the confusion.", "The target babbles incoherently and is stunned 1." },
                    { new Guid("c5391ad6-09cd-42a9-ac94-74f04f4efc97"), "The creature is stunned for 1 round and blinded for 1 minute.", "The creature is unaffected.", "The creature is stunned 1, blinded for 1 round, and dazzled for 1 minute.", "The creature is dazzled for 1 round." },
                    { new Guid("ab1082ab-df6b-4a9d-880f-7ab186891b2f"), "You misidentify the spell as another spell entirely, of the GM’s choice.", "You correctly recognize the spell and gain a +1 circumstance bonus to your saving throw or your AC against it.", "You fail to recognize the spell.", "You correctly recognize the spell." },
                    { new Guid("a2a1dedd-eaa8-49bd-9189-7ce92039987e"), "The target is unaffected.", "The target must succeed at a Fortitude save against your Intimidation DC or die. If the target succeeds at its save, it becomes frightened 2 and is fleeing for 1 round; it suffers no effect on a critical success.", "The target becomes frightened 1.", "The target becomes frightened 2." },
                    { new Guid("e2d96fa8-70a4-45cf-b7a1-010a8790b583"), null, null, "The animal doesn’t learn the trick.", "The animal learns the action. If it was an action the animal already knew, you can Command the Animal to take that action without attempting a Nature check. If it was a new basic action, add that action to the actions the animal can take when Commanded, but you must still roll." },
                    { new Guid("45c9b2e8-2604-494e-a500-7f16a680eb4c"), "The target must use all its actions on its next turn to obey your command.", null, "For the first action on its next turn, the creature must use a single action to do as you command.", "The creature is unaffected." },
                    { new Guid("0450af9d-7660-403b-8970-5515635a7779"), "The target is afflicted with Abyssal plague at stage 2.", "The target is unaffected.", "The target is afflicted with Abyssal plague at stage 1.", "The target takes 2 evil damage per spell level, and takes a –2 status penalty to saves against Abyssal plague for 1 day or until the target contracts it, whichever comes first." },
                    { new Guid("f5e8d362-20e3-4342-bd65-73ca29c1825b"), "The target is transformed into the chosen harmless animal, body and mind, for an unlimited duration.", "The target is unaffected.", "The target transforms for 1 minute but keeps its mind. If it spends all its actions on its turn concentrating on its original form, it can attempt a Will save to end the effect immediately.", "The target’s body gains minor features of the harmless animal. Its insides churn as they partially transform, causing it to be sickened 1. When it recovers from the sickened condition, its features revert to normal." },
                    { new Guid("14481cdc-273c-4a73-9c45-58d2db7309f4"), "You can’t use the item, and you can’t try to trick it again until your next daily preparations.", null, "You can’t use the item or try to trick it again this turn, but you can try again on subsequent turns.", "For the rest of the current turn, you can spend actions to activate the item as if you could normally use it." },
                    { new Guid("2130dd1b-4239-4b15-9565-f962a6bf3cee"), "The target is blinded permanently.", "The target is unaffected.", "The target is blinded for 1 minute.", "The target is blinded until its next turn begins." },
                    { new Guid("ca435a76-e666-4d33-8087-ca973e4cd537"), "As failure, but hostility doesn’t end the effect.", "The creature is unaffected.", "Any emotion effects that would affect the creature are suppressed and the creature can’t use hostile actions. If the target is subject to hostility from any other creature, it ceases to be affected by calm emotions.", "Calming urges impose a –1 status penalty to the creature’s attack rolls." },
                    { new Guid("ace65902-0a3b-4cec-acb6-6f8282687977"), "The target’s attitude becomes helpful toward you, and it can’t use hostile actions against you.", "The target is unaffected and aware you tried to charm it.", "The target’s attitude becomes friendly toward you. If it was friendly, it becomes helpful. It can’t use hostile actions against you.", "The target is unaffected but thinks your spell was something harmless instead of charm, unless it identifies the spell (see Identifying Spells on page 305)." },
                    { new Guid("c067daf9-15b6-4f2a-9bac-303584f7f85d"), null, "The target takes double damage.", null, "The target takes full damage." },
                    { new Guid("1396db52-7879-4bee-afcb-71cc424a3726"), "The attacker is stunned for 1 round. The creature is temporarily immune until the end of its turn; this effect has the incapacitation trait.", null, "The attacker is blinded for 1 round.", "The attacker is unaffected." },
                    { new Guid("1220f4e1-8504-4702-9fcc-5318b162bb12"), null, "The target can teleport if it wants, but it chooses the destination within range.", "You teleport the target and choose its destination.", "The target is unaffected." },
                    { new Guid("dd05b759-b382-42f9-bfef-e8600b2b28f9"), "The target is banished and can’t return by any means to the plane it’s banished from for 1 week.", "The target resists being banished and you are stunned 1.", "The target is banished.", "The target resists being banished." }
                });

            migrationBuilder.InsertData(
                table: "SavingThrowStats",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("83f532a1-dad3-4dc8-b13d-77e69959444a"), "Fortitude" },
                    { new Guid("5048e38a-a47c-4832-b37f-fd3818eced35"), "Reflex" },
                    { new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), "Will" }
                });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f81a5e37-0ec8-443d-924b-75769a2d321b"), "Custom" },
                    { new Guid("4e85ec44-4a72-4bea-a3e5-5e6d88882d75"), "Core Rulebook" },
                    { new Guid("979e79d5-05ab-4c2f-b8eb-872f89367ddc"), "Advanced Rulebook" }
                });

            migrationBuilder.InsertData(
                table: "SpellComponents",
                columns: new[] { "Id", "Description", "Name", "SpellsId" },
                values: new object[,]
                {
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), "A verbal component is a vocalization of words of power. You must speak them in a strong voice, so it’s hard to conceal that you’re Casting a Spell.The spell gains the concentrate trait.You must be able to speak to provide this component.", "Verbal", null },
                    { new Guid("1438bb9e-3ce3-4b33-93a5-1728b134b9ff"), "A focus is an object that funnels the magical energy of the spell. The spell gains the manipulate trait and requires you to either have a free hand to retrieve the focus listed in the spell or already be holding the focus in your hand. As part of Casting the Spell, you retrieve the focus (if necessary), manipulate it, and can put it away again if you so choose. Foci tend to be expensive, and you need to acquire them in advance to Cast the Spell.", "Focus", null },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), "A material component is a bit of physical matter consumed in the casting of the spell. The spell gains the manipulate trait and requires you to have a free hand to retrieve and manipulate a material component. That component is expended in the casting (even if the spell is disrupted). Except in extreme circumstances, you can assume all common components are included in a material component pouch.", "Material", null },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), "A somatic component is a specific hand movement or gesture that generates a magical nexus.The spell gains the manipulate trait and requires you to make gestures.You can use this component while holding something in your hand, but not if you are restrained or otherwise unable to gesture freely. Spells that require you to touch the target require a somatic component. You can do so while holding something as long as part of your hand is able to touch the target(even if it’s through a glove or gauntlet).", "Somatic", null }
                });

            migrationBuilder.InsertData(
                table: "SpellTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "A regular spell that has to be prepared or can be cast spontaneously, without any additional focus requirements, using a spell slot in the process.", "Spell" },
                    { new Guid("fbd536e4-6468-4ca5-84de-aa2e5a33776f"), "A cantrip is a special type of spell that’s weaker than other spells but can be used with greater freedom and flexibility. The title of a cantrip’s stat block says “Cantrip” instead of “Spell.” Casting a cantrip doesn’t use up your spell slots; you can cast a cantrip at will, any number of times per day. If you’re a prepared caster, you can prepare a specific number of cantrips each day. You can’t prepare a cantrip in a spell slot. A cantrip is always automatically heightened to half your level, rounded up. For a typical spellcaster, this means its level is equal to the highest level of spell slot you have.", "Cantrip" },
                    { new Guid("69863985-2984-4514-9299-588c6dd32cd7"), "Focus spells are a special type of spell attained directly from a branch of study, from a deity, or from another specific source. You can learn focus spells only through special class features or feats, rather than choosing them from a spell list. Furthermore, you cast focus spells using a special pool of Focus Points—you can’t prepare a focus spell in a spell slot or use your spell slots to cast focus spells; similarly, you can’t spend your Focus Points to cast spells that aren’t focus spells. Even some classes that don’t normally grant spellcasting, such as the champion and monk, can grant focus spells. Focus spells are automatically heightened to half your level rounded up, just like cantrips are. You can’t cast a focus spell if its minimum level is greater than half your level rounded up, even if you somehow gain access to it. Casting any of your focus spells costs you 1 Focus Point. You automatically gain a focus pool of 1 Focus Point the first time you gain an ability that gives you a focus spell. You replenish all the Focus Points in your pool during your daily preparations. You can also use the Refocus activity to pray, study, meditate, or otherwise reattune yourself to the source of your focus magic and regain a Focus Point. Some abilities allow you to increase the Focus Points in your pool beyond 1. Typically, these are feats that give you a new focus spell and increase the number of points in your pool by 1. Your focus pool can’t have a capacity beyond 3 Focus Points, even if feats that increase your pool would cause it to exceed this number.", "Focus" }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "Abbreviation", "Description", "KeyAbilityClassesId", "Name" },
                values: new object[,]
                {
                    { new Guid("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137"), "STR", "Strength measures your character’s physical power.  Strength is important if your character plans to engage in hand - to - hand combat.Your Strength modifier gets added to melee damage rolls and determines how much your character can carry.", null, "Strength" },
                    { new Guid("21b2cca1-66cd-48d1-a91b-085521659548"), "DEX", "Dexterity measures your character’s agility, balance, and reflexes. Dexterity is important if your character plans to make attacks with ranged weapons or use stealth to surprise foes. Your Dexterity modifier is also added to your character’s AC and Reflex saving throws.", null, "Dexterity" },
                    { new Guid("10e9f065-a160-47e5-97df-72df4ec5ea15"), "CON", "Constitution measures your character’s overall health and stamina. Constitution is an important statistic for all characters, especially those who fight in close combat.  Your Constitution modifier is added to your Hit Points and Fortitude saving throws.", null, "Constitution" },
                    { new Guid("37406a59-0dd9-4766-8713-33b13b7740fd"), "INT", "Intelligence measures how well your character can learn and reason. A high Intelligence allows your character to analyze situations and understand patterns, and it means they can become trained in additional skills and might be able to master additional languages.", null, "Intellect" },
                    { new Guid("e9e25044-7005-48c7-81bc-372c8a9f829a"), "WIS", "Wisdom measures your character’s common sense, awareness, and intuition. Your Wisdom modifier is added to your Perception and Will saving throws.", null, "Wisdom" },
                    { new Guid("f4206177-80d3-4c9c-8f79-357a608897fa"), "CHA", "Charisma measures your character’s personal magnetism and strength of personality. A high Charisma score helps you influence the thoughts and moods of others.", null, "Charisma" }
                });

            migrationBuilder.InsertData(
                table: "Traits",
                columns: new[] { "Id", "ActionsId", "Description", "FeatsId", "Name", "SpellsId" },
                values: new object[,]
                {
                    { new Guid("0cb3dbbc-941b-4e27-b46c-d0246dacc056"), null, "An effect with this trait applies one or more diseases. A disease is typically an affliction.", null, "Disease", null },
                    { new Guid("a23df7f5-acc6-4f87-9244-0fbbc77c70d2"), null, "Effects with this trait attempt to determine the presence or location of a person, object, or aura.", null, "Detection", null },
                    { new Guid("f1f5c47a-fec2-4983-8229-3c4e8b43f0b5"), null, "An effect with the death trait kills you immediately if it reduces you to 0 HP. Some death effects can bring you closer to death or slay you outright without reducing you to 0 HP.", null, "Death", null },
                    { new Guid("e5b98ff4-8503-461c-870d-7b8c8e4811fa"), null, "Chaotic effects often manipulate energy from chaos-aligned Outer Planes and are anathema to lawful divine servants or divine servants of lawful deities.", null, "Chaotic", null },
                    { new Guid("9da1e40e-f9b8-4381-9167-229fee66f4f7"), null, "A spell you can cast at will that is automatically heightened to half your level rounded up.", null, "Cantrip", null },
                    { new Guid("856db08f-edad-472b-b870-65a8f16252a5"), null, "An ability with this trait involves an attack. For each attack you make beyond the first on your turn, you take a multiple attack penalty.", null, "Attack", null },
                    { new Guid("c90d2554-1af6-45d7-9f20-f98aa0799887"), null, "Light effects overcome non-magical darkness in the area, and can counteract magical darkness. You must usually target darkness magic with your light magic directly to counteract the darkness, but some light spells automatically attempt to counteract darkness.", null, "Light", null },
                    { new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054"), null, "A type of feat that any character can select, regardless of ancestry and class, as long as they meet the prerequisites. You can select a feat with this trait when your class grants a general feat.", null, "General", null },
                    { new Guid("23655aa4-871f-416f-be14-1fc03bedef16"), null, "An effect with this trait is not inherently deadly. Damage from a nonlethal effect knocks a creature out rather than killing it. You can use a nonlethal weapon to make a lethal attack with a –2 circumstance penalty.", null, "Nonlethal", null },
                    { new Guid("39e2298b-bab0-49b7-8a0a-4ac1145611b0"), null, "An effect with this trait delivers a poison or deals poison damage. An item with this trait is poisonous and might cause an affliction.", null, "Poison", null },
                    { new Guid("1ee8c64b-ad34-4b3b-a01c-a1057eea01f6"), null, "This effect alters a creature's emotions. Effects with this trait always have the mental trait as well. Creatures with special training or that have mechanical or artificial intelligence are immune to emotion effects.", null, "Emotion", null },
                    { new Guid("aa2b017d-2e8c-460a-9069-6bf61b69dd72"), null, "Darkness effects extinguish non-magical light in the area, and can counteract less powerful magical light. You must usually target light magic with your darkness magic directly to counteract the light, but some darkness spells automatically attempt to counteract light.", null, "Darkness", null },
                    { new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498"), null, "A general feat with the skill trait improves your skills and their actions or gives you new actions for a skill. A feat with this trait can be selected when a class grants a skill feat or general feat. Archetype feats with the skill trait can be selected in place of a skill feat if you have that archetype’s dedication feat.", null, "Skill", null },
                    { new Guid("fc3cb057-dcb6-4508-915a-0abd25679211"), null, "Evil effects often manipulate energy from evil-aligned Outer Planes and are antithetical to good divine servants or divine servants of good deities.", null, "Evil", null },
                    { new Guid("33bf3198-48a1-4559-9a48-9881901f880b"), null, "Effects that slightly alter a creature’s form have the morph trait. Any Strikes specifically granted by a morph effect are magical. You can be affected by multiple morph spells at once, but if you morph the same body part more than once, the second morph effect attempts to counteract the first (in the same manner as two polymorph effects, described in that trait). Your morph effects might also end if you are polymorphed and the polymorph effect invalidates or overrides your morph effect. The GM determines which morph effects can be used together and which can’t.", null, "Morph", null },
                    { new Guid("06f2cf99-b089-4e34-b443-53028fdc2ae0"), null, "A healing effect restores a creature's body, typically by restoring Hit Points, but sometimes by removing diseases or other debilitating effects.", null, "Healing", null },
                    { new Guid("08bac763-e881-4a70-b253-916191ee9713"), null, "An action with this trait involves moving from one space to another.", null, "Move", null },
                    { new Guid("f7ad867e-49e3-40e3-ad95-bbf461be2087"), null, "Fear effects evoke the emotion of fear. Effects with this trait always have the mental and emotion traits as well.", null, "Fear", null },
                    { new Guid("ccae1335-3555-4e55-9fe4-d22f6b9bc162"), null, "An activity with this trait takes a day or more, and can be used only during downtime", null, "Downtime", null },
                    { new Guid("dee6c869-337c-4f4c-ba3c-3c3e77c19857"), null, "You must physically manipulate an item or make gestures to use an action with this trait. Creatures without a suitable appendage can’t perform actions with this trait. Manipulate actions often trigger reactions.", null, "Manipulate", null },
                    { new Guid("9979d44e-3a35-4eef-a767-d3c974b5fbf6"), null, "A fortune effect beneficially alters how you roll your dice. You can never have more than one fortune effect alter a single roll. If multiple fortune effects would apply, you have to pick which to use. If a fortune effect and a misfortune effect would apply to the same roll, the two cancel each other out, and you roll normally.", null, "Fortune", null },
                    { new Guid("340e83a5-5a6e-4a5f-8658-7aede58da5a9"), null, "Teleportation effects allow you to instantaneously move from one point in space to another. Teleportation does not usually trigger reactions based on movement.", null, "Teleportation", null },
                    { new Guid("be9994ab-79ef-4ec0-9761-492059b0083a"), null, "An ability with this trait can take a character completely out of the fight or even kill them, and it’s harder to use on a more powerful character. If a spell has the incapacitation trait, any creature of more than twice the spell’s level treats the result of their check to prevent being incapacitated by the spell as one degree of success better, or the result of any check the spellcaster made to incapacitate them as one degree of success worse. If any other effect has the incapacitation trait, a creature of higher level than the item, creature, or hazard generating the effect gains the same benefits.", null, "Incapacitation", null },
                    { new Guid("f91abbe0-0bec-4278-99d0-b12f044f8061"), null, "A scrying effect lets you see, hear, or otherwise get sensory information from a distance using a sensor or apparatus, rather than your own eyes and ears.", null, "Scrying", null },
                    { new Guid("7684fa81-e3a5-4224-8d57-bc61df53d54a"), null, "Effects with this trait determine what is likely to happen in the near future. Most predictions are divinations.", null, "Prediction", null },
                    { new Guid("2bc07fcc-2113-4b39-a257-17851f1f216d"), null, "Vegetable creatures have the plant trait. They are distinct from normal plants. Magical effects with this trait manipulate or conjure plants or plant matter in some way. Those that manipulate plants have no effect in an area with no plants.", null, "Plant", null },
                    { new Guid("1a83b706-d9c1-4b46-bcf3-3c9bb82219ee"), null, "These effects transform the target into a new form. A target can’t be under the effect of more than one polymorph effect at a time. If it comes under the effect of a second polymorph effect, the second polymorph effect attempts to counteract the first. If it succeeds, it takes effect, and if it fails, the spell has no effect on that target. Any Strikes specifically granted by a polymorph effect are magical. Unless otherwise stated, polymorph spells don’t allow the target to take on the appearance of a specific individual creature, but rather just a generic creature of a general type or ancestry. If you take on a battle form with a polymorph spell, the special statistics can be adjusted only by circumstance bonuses, status bonuses, and penalties. Unless otherwise noted, the battle form prevents you from casting spells, speaking, and using most manipulate actions that require hands. (If there’s doubt about whether you can use an action, the GM decides.) Your gear is absorbed into you; the constant abilities of your gear still function, but you can’t activate any items.", null, "Polymorph", null },
                    { new Guid("574e4077-83a5-4865-95a3-29a556f873ed"), null, "This poison is delivered by damaging the recipient.", null, "Injury", null },
                    { new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e"), null, "A mental effect can alter the target’s mind. It has no effect on an object or a mindless creature.", null, "Mental", null },
                    { new Guid("315bf80d-594e-46ca-944e-cb8287df46fa"), null, "An effect with this trait depends on language comprehension. A linguistic effect that targets a creature works only if the target understands the language you are using.", null, "Linguistic", null },
                    { new Guid("4f8453ab-e7f8-4d2f-95e7-e0e53a32cbde"), null, "Effects with this trait see things as they truly are.", null, "Revelation", null },
                    { new Guid("551070c6-e73a-4c0c-9a9c-f6425f38f5f0"), null, "This poison is delivered when breathed in.", null, "Inhaled", null },
                    { new Guid("44a18bec-0799-41a7-9b07-16113bb0623f"), null, "Auditory actions and effects rely on sound. An action with the auditory trait can be successfully performed only if the creature using the action can speak or otherwise produce the required sounds. A spell or effect with the auditory trait has its effect only if the target can hear it. This applies only to sound-based parts of the effect, as determined by the GM. This is different from a sonic effect, which still affects targets who can't hear it (such as deaf targets) as long as the effect itself makes sound.", null, "Auditory", null },
                    { new Guid("0b49fe13-7684-43b9-b5a5-81b8c038dc9c"), null, "This poison is delivered by contact with the skin.", null, "Contact", null },
                    { new Guid("c5e1a5e7-5d45-4826-b2ea-018b361770de"), null, "An action with this trait requires a degree of mental concentration and discipline.", null, "Concentrate", null },
                    { new Guid("7cb74b87-4e13-4d8c-afa5-da8cbe671bfc"), null, "Effects with the air trait either manipulate or conjure air. Those that manipulate air have no effect in a vacuum or an area without air. Creatures with this trait consist primarily of air or have a magical connection to that element. Planes with this trait consist mostly of open spaces and air with various degrees of turbulence, though they also contain rare islands of floating stone and other elements and energies.", null, "Air", null },
                    { new Guid("ae21e02b-11a1-4c53-96ec-5961beb2761d"), null, "Effects with the water trait either manipulate or conjure water. Those that manipulate water have no effect in an area without water. Creatures with this trait consist primarily of water or have a magical connection to the element. Planes with this trait are mostly liquid, perhaps with pockets of breathable air.", null, "Water", null },
                    { new Guid("d1aabc8c-b3fe-40eb-bfc2-ea72d3b7e0c0"), null, "Effects with the fire trait deal fire damage or either conjure or manipulate fire. Those that manipulate fire have no effect in an area without fire. Creatures with this trait consist primarily of fire or have a magical connection to that element. Planes with this trait are composed of flames that continually burn with no fuel source. Fire planes are extremely hostile to non-fire creatures.", null, "Fire", null },
                    { new Guid("689bc25d-de13-418c-8da2-a9280936359d"), null, "Effects with the earth trait either manipulate or conjure earth. Those that manipulate earth have no effect in an area without earth. Creatures with this trait consist primarily of earth or have a magical connection to that element. Planes with this trait are mostly solid, with caverns and other hollow pockets.", null, "Earth", null },
                    { new Guid("44a15dce-b0cf-4d6a-a4be-92d759fdbaa3"), null, "Effects with this trait deal acid damage. Creatures with this trait have a magical connection to acid.", null, "Acid", null },
                    { new Guid("36d65d85-b689-46da-86b6-4f0838f296e6"), null, "Effects with this trait deal cold damage. Creatures with this trait have a connection to magical cold.", null, "Cold", null },
                    { new Guid("dc6ca4d1-85f2-4be9-bc39-9a48b943b392"), null, "Effects with this trait deal electricity damage. A creature with this trait has a magical connection to electricity.", null, "Electricity", null },
                    { new Guid("e55f102e-414e-4210-b1b3-97d8c26bab6a"), null, "Effects with this trait deal force damage or create objects made of pure magical force.", null, "Force", null },
                    { new Guid("30ed464b-6bf4-4a80-8c42-8bb95ecb751c"), null, "Effects with this trait heal undead creatures with negative energy, deal negative damage to living creatures, or manipulate negative energy. Planes with this trait are vast, empty reaches that suck the life from the living. Creatures with this trait are natives of the Negative Energy Plane. They can survive the basic environmental effects of the Negative Energy Plane.", null, "Negative", null },
                    { new Guid("ece55c2d-2715-4e67-aa1e-736c019e89a6"), null, "Effects with this trait heal living creatures with positive energy, deal positive energy damage to undead, or manipulate positive energy. Planes with this trait are awash with life energy of such intensity that it can harm living creatures. Creatures with this trait are natives of the Positive Energy Plane. They can survive the basic environmental effects of the Positive Energy Plane.", null, "Positive", null },
                    { new Guid("812b4b93-b467-438f-9561-ef020545755f"), null, "An effect with the sonic trait functions only if it makes sound, meaning it has no effect in an area of silence or in a vacuum. This is different from an auditory spell, which is effective only if the target can hear it. A sonic effect might deal sonic damage. A creature with this trait has a magical connection to powerful sound.", null, "Sonic", null },
                    { new Guid("a0e52203-1c57-4a58-bff2-7e262b56181f"), null, "This magic comes from the arcane tradition, which is built on logic and rationality. Anything with this trait is magical.", null, "Arcane", null },
                    { new Guid("561c7c89-44d2-492e-b12f-352af45b6a6b"), null, "This magic comes from the divine tradition, drawing power from deities or similar sources. Anything with this trait is magical.", null, "Divine", null },
                    { new Guid("0e3307ce-952d-4d93-bcac-95bbf495ee85"), null, "This magic comes from the occult tradition, calling upon bizarre and ephemeral mysteries. Anything with this trait is magical.", null, "Occult", null },
                    { new Guid("3de4876d-2336-4d5e-bbbb-5b4e83ea6d49"), null, "This magic comes from the primal tradition, connecting to the natural world and instinct. Anything with this trait is magical.", null, "Primal", null },
                    { new Guid("5b33384c-0c98-4238-8257-8b911933308e"), null, "Anything that doesn't list another rarity trait (uncommon, rare, or unique) automatically has the common trait. This rarity indicates that an ability, item, or spell is available to all players who meet the prerequisites for it. A creature of this rarity is generally known and can be summoned with the appropriate summon spell.", null, "Common", null },
                    { new Guid("d748ac0d-6af3-4475-af4e-a72455960fe0"), null, "A verbal component is a vocalization of words of power. You must speak them in a strong voice, so it’s hard to conceal that you’re Casting a Spell. The spell gains the concentrate trait. You must be able to speak to provide this component.", null, "Verbal", null },
                    { new Guid("e2bb08cb-cf59-4e29-8738-52c751405fb0"), null, "A visual effect can affect only creatures that can see it. This applies only to visible parts of the effect, as determined by the GM.", null, "Visual", null },
                    { new Guid("a6217da0-ad2a-43a0-88d4-ac85f1d68591"), null, "An olfactory effect can affect only creatures that can smell it. This applies only to olfactory parts of the effect, as determined by the GM.", null, "Olfactory", null },
                    { new Guid("d751d93f-cff9-448f-8ab0-9a3c07eacbef"), null, "Effects and magic items with this trait are associated with the transmutation school of magic, typically changing something’s form.", null, "Transmutation", null },
                    { new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b"), null, "Effects and magic items with this trait are associated with the necromancy school of magic, typically involving forces of life and death.", null, "Necromancy", null },
                    { new Guid("7f9fe1cb-c607-44c3-8f1a-b26d508cfce6"), null, "Effects and magic items with this trait are associated with the illusion school of magic, typically involving false sensory stimuli.", null, "Illusion", null },
                    { new Guid("3078e40b-db78-4f39-9ffc-304e6a1993cf"), null, "This poison is delivered when drunk or eaten.", null, "Ingested", null },
                    { new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49"), null, "Effects and magic items with this trait are associated with the evocation school of magic, typically involving energy and elemental forces.", null, "Evocation", null },
                    { new Guid("5bce1594-6c07-460f-b306-0db1fa30833b"), null, "The divination school of magic typically involves obtaining or transferring information, or predicting events.", null, "Divination", null },
                    { new Guid("6f187720-6664-44c6-8e09-2053ed1054d6"), null, "Effects and magic items with this trait are associated with the conjuration school of magic, typically involving summoning, creation, teleportation, or moving things from place to place.", null, "Conjuration", null },
                    { new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980"), null, "Effects and magic items with this trait are associated with the abjuration school of magic, typically involving protection or wards.", null, "Abjuration", null },
                    { new Guid("68d3b3ab-d2ed-4691-8609-7403c843c77f"), null, "A rules element with this trait is one-of-a-kind. The DC of Recall Knowledge checks related to creatures with this trait is increased by 10.", null, "Unique", null },
                    { new Guid("f2810f2b-6f8a-4fb1-b00f-a9d307f97eff"), null, "This rarity indicates that a rules element is very difficult to find in the game world. A rare feat, spell, item or the like is available to players only if the GM decides to include it in the game, typically through discovery during play. Creatures with this trait are rare. They typically can’t be summoned. The DC of Recall Knowledge checks related to these creatures is increased by 5.", null, "Rare", null },
                    { new Guid("0c06a5b8-24e7-486b-bb98-91caef377013"), null, "Something of uncommon rarity requires special training or comes from a particular culture or part of the world. Some character choices give access to uncommon options, and the GM can choose to allow access for anyone. Less is known about uncommon creatures than common creatures. They typically can’t be summoned. The DC of Recall Knowledge checks related to these creature is increased by 2.", null, "Uncommon", null },
                    { new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a"), null, "Effects and magic items with this trait are associated with the enchantment school of magic, typically involving mind control, emotion alteration, and other mental effects.", null, "Enchantment", null },
                    { new Guid("5f7b92e7-09d2-4717-8588-56b45c08a111"), null, "The GM rolls the check for this ability in secret.", null, "Secret", null }
                });

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "ActionTypeId", "Name", "Requirements", "RollableEffectId", "TraitsId", "Trigger" },
                values: new object[,]
                {
                    { new Guid("4163f1f7-245b-4989-b4a9-8638d75f2cdc"), new Guid("4716abe4-50c3-447d-bb27-2b268667b3c2"), "Delay", null, null, null, "Your turn begins." },
                    { new Guid("185abe1a-6c43-4884-bb8a-4f596e75442f"), new Guid("668ed964-cf7f-43df-b4b3-6a89c28551aa"), "Aid", "The ally is willing to accept your aid, and you have prepared to help.", new Guid("5c94d039-e421-42b3-af86-d33a8f266410"), null, "An ally is about to use an action that requires a skill check or attack roll." },
                    { new Guid("3367ce7a-8cc0-11eb-8dcd-0242ac130003"), new Guid("668ed964-cf7f-43df-b4b3-6a89c28551aa"), "Arrest Fall", "You have a fly speed.", new Guid("3d116422-8cc0-11eb-8dcd-0242ac130003"), null, "You fall." },
                    { new Guid("c2bcb0d1-7feb-4f52-8046-d630a6c8f09f"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Escape", null, new Guid("42f02449-6552-40db-adea-e635cb50c071"), null, null },
                    { new Guid("90d27bd9-31ed-46f4-a174-467e165ed1b9"), new Guid("668ed964-cf7f-43df-b4b3-6a89c28551aa"), "Grab Edge", "Your hands are not tied behind your back or otherwise restrained.", new Guid("f5c01f9a-15de-47c0-8f65-470f0c4442dd"), null, "You fall from or past an edge or handhold." },
                    { new Guid("f715d730-9ad4-4922-b893-cda88fe25ea4"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Sense Motive", null, new Guid("e83cff43-911b-41f0-a5d3-e67bed0ca36b"), null, null },
                    { new Guid("577e96ba-5bf3-46e7-9f4b-eb5b71546bfd"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Stride", null, new Guid("9dab564c-885e-492a-a52e-af745342c53d"), null, null },
                    { new Guid("56d03917-ff05-4b95-9455-4cb2ccbc9a60"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "Ready", null, null, null, null },
                    { new Guid("55bca308-af52-4da5-a1e4-a6c1059c5321"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Take Cover", "You are benefiting from cover, are near a feature that allows you to take cover, or are prone.", null, null, null },
                    { new Guid("1e0c25df-54a1-41f0-8f21-2f6cdc08f59a"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Step", "Your Speed is at least 10 feet.", null, null, null },
                    { new Guid("4deb6d4d-0808-4755-897e-412a0d6e1f21"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Stand", null, null, null, null },
                    { new Guid("ada1f776-2e98-4e7d-96e1-2166837fab6b"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Seek", null, new Guid("c6c59505-6b03-46fe-b154-1c303d7176e4"), null, null },
                    { new Guid("ab48c6d8-a194-4595-8358-c751fdc934d8"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Mount", "You are adjacent to a creature that is at least one size larger than you and is willing to be your mount.", null, null, null },
                    { new Guid("99ab25a7-a541-4074-ae20-fb25b87520cd"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Leap", null, null, null, null },
                    { new Guid("b66bad20-3677-47eb-9344-c78e538adcd3"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Interact", null, null, null, null },
                    { new Guid("31fb2827-6ed7-455e-b135-9f4893b298fb"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Fly", "You have a fly speed.", null, null, null },
                    { new Guid("e5d48006-5153-4ebf-a71e-401cc0bc3d4a"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Drop Prone", null, null, null, null },
                    { new Guid("5f770553-dac1-4377-8416-1a2a2e8f43be"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Crawl", "You are prone and your Speed is at least 10 feet.", null, null, null },
                    { new Guid("eb1f9f32-3d35-479a-a3e2-bf965e32fc3d"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Burrow", "You have a burrow speed.", null, null, null },
                    { new Guid("4384a058-8cc0-11eb-8dcd-0242ac130003"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Avert Gaze", null, null, null, null },
                    { new Guid("ed94ef79-c37c-4591-a520-557916925352"), new Guid("4716abe4-50c3-447d-bb27-2b268667b3c2"), "Release", null, null, null, null },
                    { new Guid("187ebb2b-c829-4d40-81dd-414a48ea766e"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), "Point Out", "A creature is undetected by one or more of your allies but isn’t undetected by you.", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "AdvancedWeaponProficiencyId", "BaseHealth", "ClassDcProficiencyId", "Description", "DuringCombatEncounters", "DuringSocialEncounters", "FortitudeProficiencyId", "HeavyArmorProficiencyId", "InDowntime", "KeyAbilitiesId", "LightArmorProficiencyId", "MartialWeaponProficiencyId", "MediumArmorProficiencyId", "Name", "PerceptionProficiencyId", "PredefinedMagicTraditionId", "ReflexProficiencyId", "SimpleWeaponProficiencyId", "SpellAttackProficiencyId", "SpellDcProficiencyId", "UnarmedWeaponProficiencyId", "UnarmoredProficiencyId", "WhileExploring", "WillProficiencyId" },
                values: new object[,]
                {
                    { new Guid("3f3362c2-09a1-47da-8945-cea25e313f80"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 10, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You are an emissary of a deity, a devoted servant who has taken up a weighty mantle, and you adhere to a code that holds you apart from those around you. While champions exist for every alignment, as a champion of good, you provide certainty and hope to the innocent. You have powerful defenses that you share freely with your allies and innocent bystanders, as well as holy power you use to end the threat of evil. Your devotion even attracts the attention of holy spirits who aid you on your journey.", "You confront enemies in hand-to-hand combat while carefully positioning yourself to protect your allies.", "You are a voice of hope, striving to reach a peaceful solution that strengthens bonds and yields good results for all.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You spend much of your time in solemn prayer and contemplation, rigorous training, charity work, and fulfilling the tenets of your code, but that doesn’t mean there isn’t time to take up a craft or hobby.", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "Champion", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You overcome barriers both physical and spiritual, providing inspiration to your allies through your actions and—when your fellow adventurers ask for it—providing moral and ethical guidance.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("73f7051c-8eff-4337-a87c-183deb7a998c"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 8, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "The power of nature is impossible to resist. It can bring ruin to the stoutest fortress in minutes, reducing even the mightiest works to rubble, burning them to ash, burying them beneath an avalanche of snow, or drowning them beneath the waves. It can provide endless bounty and breathtaking splendor to those who respect it— and an agonizing death to those who take it too lightly. You are one of those who hear nature’s call. You stand in awe of the majesty of its power and give yourself over to its service.", "You call upon the forces of nature to defeat your enemies and protect your allies. You cast spells that draw upon primal magic to protect yourself and your friends, heal their wounds, or summon deadly animals to fight at your side. Depending on your bond to nature, you might call upon powerful elemental magic or change shape into a terrifying beast.", "You represent balance and a reasoned approach to problems, looking for solutions that not only are best for the natural world, but also allow the creatures within it to live in harmony and peace.You often propose compromises that allow both sides to gain what they truly need, even if they can’t have all that they desire.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You might craft magic items or potions. Alternatively, your tie to nature might lead you to tend a wilderness area, befriending beasts and healing the wounds caused by  civilization.You might even teach sustainable farming and animal husbandry techniquesthat allow others to subsist off the land without harming the natural balance.", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "Druid", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "Your nature skills are invaluable. You track down enemies, navigate the wilderness, and use spells to detect magical auras around you.You might even ask wild animals to lend their extraordinary senses and scouting abilities to your group.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("9cace213-82ff-4751-a438-8afd87d433e4"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), 10, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "Fighting for honor, greed, loyalty, or simply the thrill of battle, you are an undisputed master of weaponry and combat techniques. You combine your actions through clever combinations of opening moves, finishing strikes, and counterattacks whenever your foes are unwise enough to drop their guard. Whether you are a knight, mercenary, sharpshooter, or blade master, you have honed your martial skills into an art form and perform devastating critical attacks on your enemies.", "You strike with unmatched accuracy and use specialized combat techniques. A melee fighter stands between allies and enemies, attacking foes who try to get past. A ranged fighter delivers precise shots from a distance.", "You can be an intimidating presence. This can be useful when negotiating with enemies, but is sometimes a liability in more genteel interactions.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You might perform manual labor or craft and repair armaments. If you know techniques you no longer favor, you might train yourself in new ones. If you’ve established your reputation, you might build an organization or a stronghold of your own.", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "Fighter", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You keep up your defenses in preparation for combat, and keep an eye out for hidden threats. You also overcome physical challenges in your way, breaking down doors, lifting obstacles, climbing adeptly, and leaping across pits.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8") },
                    { new Guid("2483fb2b-b7cc-4eab-9c4e-0118477e46ed"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 8, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You seek to uncover the truth, doggedly pursuing leads to reveal the plots of devious villains, discover ancient secrets, or unravel other mysteries. Your analytical mind quickly formulates solutions to complicated problems and your honed senses identify even the most obscure clues. Wielding knowledge as a weapon, you study the creatures and dangers you encounter to exploit their weaknesses.", "Your keen insights regarding your foes make you more dangerous than your physical strength would suggest. After spending a moment to study your enemies, your perceptiveness allows you to act quickly, striking them where it hurts most. You often assist tougher members of your party, wisely protecting yourself while providing vital aid.", "Few can stand up against your scrutiny. You might not be the most charming, but you see things for what they really are and develop an understanding of a social situation rapidly. Every conversation is an investigation, after all, and you never know what you might uncover!", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You study up on subjects new and old, make new allies you can share information with, and pursue hobbies that keep your active mind satisfied. You might make a bit of coin on the side working as a private detective or consulting with the local constabulary.", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Investigator", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null, null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You look for clues in your environment. You often prove yourself to be a valuable ally by serving as a party scout, analyzing the intricacies of puzzles or mysterious phenomena, and pursuing leads that could reveal beneficial information.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 10, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "The strength of your fist flows from your mind and spirit. You seek perfection—honing your body into a flawless instrument and your mind into an orderly bastion of wisdom.You’re a fierce combatant renowned for martial arts skills and combat stances that grant you unique fighting moves.While the challenge of mastering many fighting styles drives you to great heights, you also enjoy meditating on philosophical questions and discovering new ways to obtain peace and enlightenment.", "You speed into the fray, dodging or leaping past obstacles with acrobatic maneuvers. You strike opponents in a rapid flurry of attacks, using your bare fists or wielding specialized weapons that you mastered during your monastic training. Stances let you change up your combat style for different situations, and ki abilities allow you to perform mystic feats like healing yourself and soaring through the air.", "Your perceptiveness lets you see through falsehoods, and your philosophical trainingprovides insight into any situation.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You diligently exercise, eat healthy foods, meditate, and study various philosophies. You might also take up a craft that you strive to perfect.", null, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Monk", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null, null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You climb up walls, dodge traps, overcome obstacles, and leap over pits. You usually stay toward the outside of the group to protect more vulnerable members, and you’re well suited to looking for danger or moving stealthily.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("bc25beea-18e8-4417-8ada-a0f58bc79585"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 8, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Your conduit to divine power eschews the traditional channels of prayer and servitude—you instead glean divine truths that extend beyond any single deity. You understand the great mysteries of the universe embodied in overarching concepts that transcend good and evil or chaos and law, whether because you perceive the common ground across multiple deities or circumvent their power entirely. You explore one of these mysteries and draw upon its power to cast miraculous spells, but that power comes with a terrible price: a curse that grows stronger the more you draw upon it. Your abilities are a double-edged sword, which you might uphold as an instrument of the divine or view as a curse from the gods.", "You draw upon your mystery to empower yourself in combat, balancing miraculous effects with the increasing severity of your curse as conflicting divine demands overtax your physical body. You cast spells to aid your allies and devastate your foes, or depending on your mystery, you might wade into battle yourself.", "You rely upon the insights drawn from your mystery. You might leverage your curse to intimidate people or hide its effects to better blend in.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You might seek to learn more about your mystery and the divine wellsprings that fuel your power. Associating with others interested in the subject of your mystery can make it easier to live with your curse. You could associate with an organized religion or even start your own faithful following devoted to your mystery.", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Oracle", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You recenter yourself to bring the terrible metaphysical conflicts causing your curse back under control so you can draw upon your mystery’s power again later. You remain aware of supernatural forces acting around you, perhaps peeking into the future to gain insights.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("de966e73-2c40-40b4-956f-57e326f7ce8e"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 6, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You command powerful magic, not through study or devotion to any ideal, but as a vessel or agent for a mysterious, otherworldly patron that even you don’t entirely understand. This entity might be a covert divinity, a powerful fey, a manifestation of natural energies, an ancient spirit, or any other mighty supernatural being—but its nature is likely as much a mystery to you as it is to anyone else. Through a special familiar, your patron grants you versatile spells and powerful hexes to use as you see fit, though you’re never certain if these gifts will end up serving your patron’s larger plan.", "You cast spells to change the course of battle. You use magical hexes to hamper enemies and aid allies, while leveraging more powerful spells to control the battlefield, heal, or harm, aided by your extraordinary familiar, brewed potions, and magical items.", "You provide knowledge on numerous topics, including a variety of magical matters, and you might call upon your patron’s magic to charm or deceive others.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You brew potions, craft other magical items, or hunt for new spells for your familiar to learn. You might try to learn more about your patron, their aims, or your own powers, and you might seek out the company of other witches for collaboration or community.", null, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Witch", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You remain alert for magical traps and treasures, employing a clever array of spells to overcome obstacles that stand in your way. Your familiar might aid you through its own considerable set of exceptional abilities.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("4087e406-d324-45af-b9b9-9adf0283a17c"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 8, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You are skilled and opportunistic . Using your sharp wits and quick reactions, you take advantage of your opponents’ missteps and strike where it hurts most. You play a dangerous game, seeking thrills and testing your skills, and likely don’t care much for any laws that happen to get in your way. While the path of every rogue is unique and riddled with danger, the one thing you all share in common is the breadth and depth of your skills.", "You move about stealthily so you can catch foes unawares. You’re a precision instrument, more useful against a tough boss or distant spellcaster than againstrank - and - file soldiers.", "Your skills give you multiple tools to influence your opposition. Pulling cons and ferreting out information are second nature to you.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You might pick pockets or trade in illegal goods. You can also become part of a thieves’ guild, or even found one of your own.", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Rogue", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null, null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You sneak to get the drop on foes and scout for danger or traps. You’re a great asset, since you can disable traps, solve puzzles, and anticipate dangers.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("05d42777-0744-4a72-85ad-d27186c96deb"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 6, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You didn’t choose to become a spellcaster—you were born one. There’s magic in your blood, whether a divinity touched one of your ancestors, a forebear communed with a primal creature, or a powerful occult ritual influenced your line. Self-reflection and study allow you to refine your inherent magical skills and unlock new, more powerful abilities. The power in your blood carries a risk, however, and you constantly face the choice of whether you’ll rise to become a master spellcaster or fall into destruction.", "You use spells to injure your enemies, influence their minds, and hamper their movements. You might be too vulnerable to get into melee combat, or your bloodline might give you abilities that help you hold your own in a brawl. While your magic is powerful, to conserve your best spells—or when you’ve used them all up—you also rely on cantrips.", "Your natural charisma makes you good at interacting with people.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You craft magic items or scribe scrolls. Your bloodline might drive you to research your ancestry or associate with affiliated people or creatures.", null, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Sorcerer", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You detect the magic around you, finding treasures and warning your adventuring group of magical traps. When the group encounters mysteries or problems related to your bloodline, you try to solve them.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("deb62736-af71-4600-bd4b-59e55961b74d"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 10, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "Many warriors rely on brute force, weighty armor, or cumbersome weapons. For you, battle is a dance where you move among foes with style and grace. You dart among combatants with flair and land powerful finishing moves with a flick of the wrist and a flash of the blade, all while countering attacks with elegant ripostes that keep enemies off balance. Harassing and thwarting your foes lets you charm fate and cheat death time and again with aplomb and plenty of flair.", "You show off to gain panache, leveraging your flair to build up to powerful finishing moves. You stay nimble, moving into the best position to perform your maneuvers while dodging enemy blows and responding with swift ripostes. Depending on your swashbuckler’s style, you might dance among your foes; slip past their defenses; or beguile, distract, or frighten them.", "You are equally likely to charm or intimidate others—or both. You might be an adept socialite, or you might create distractions for others who do the talking.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You might carouse at the tavern, repair and maintain your armaments, or train to learn new techniques. To maintain your impressive reputation, you might build an organization in your name or establish a following of admirers.", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Swashbuckler", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null, null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You keep a careful eye on your surroundings and other people, always prepared to leap into action with bravado and flair. You interact with the environment in bold, sweeping strokes rather than skulking to avoid detection.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("0e53c45a-9ab8-4d4a-bb5b-51af257c56bc"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 6, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You are an eternal student of the arcane secrets of the universe, using your mastery of magic to cast powerful and devastating spells. You treat magic like a science, cross-referencing the latest texts on practical spellcraft with ancient esoteric tomes to discover and understand how magic works. Yet magical theory is vast, and there’s no way you can study it all. You either specialize in one of the eight schools of magic, gaining deeper understanding of the nuances of those spells above all others, or favor a broader approach that emphasizes the way all magic comes together at the expense of depth.", "You likely try to stay out of the fray, carefully judging when to use your spells. You save your most powerful magic to incapacitate threatening foes and use your cantrips when only weaker foes remain. When enemies pull out tricks like invisibility or flight, you answer with spells like glitterdust or earth bind, leveling the field for your allies.", "You provide a well of knowledge about arcane matters and solve arguments with logic.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You learn new spells, craft magic items, or scribe scrolls for your party, and seek out new and exciting formulas in addition to spells. You might even forge scholarly connections and establish a school or guild of your own.", null, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Wizard", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You locate magical auras and determine the arcane significance of magical writing or phenomena you uncover. When you run across an unusual obstacle to further exploration, you probably have a scroll that will make it easier to overcome.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("9c08f598-a180-4a59-984a-a26a67607054"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 8, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You are a master of artistry, a scholar of hidden secrets, and a captivating persuader. Using powerful performances, you influence minds and elevate souls to new levels of heroics. You might use your powers to become a charismatic leader, or perhaps you might instead be a counselor, manipulator, scholar, scoundrel, or virtuoso. While your versatility leads some to consider you a beguiling ne’erdo- well and a jack-of-all-trades, it’s dangerous to dismiss you as a master of none.", "You use magical performances to alter the odds in favor of your allies. You confidently alternate between attacks, healing, and helpful spells as needed.", "You persuade, prevaricate, and threaten with ease.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You can earn money and prestige with your performances, gaining a name for yourself and acquiring patrons. Eventually, tales of your talents and triumphs might attract other bards to study your techniques in a bardic college.", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Bard", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You’re a font of knowledge, folktales, legends, and lore that provide a deeper context and helpful reconnaissance for the group’s adventure. Your spells and performances inspire your allies to greater discovery and success.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("ceb15fca-8288-456e-9769-98cce79bb104"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 10, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "Some rangers believe civilization wears down the soul, but still needs to be protected from wild creatures.Others say nature needs to be protected from the greedy, who wish to tame its beauty and plunder its treasures.You could champion either goal, or both. You might be a scout, tracker, or hunter of fugitives or beasts, haunting the edge of civilization or exploring the wilds.You know how to live off the land and are skilled at spotting and taking down both opportune prey and hated enemies.", "You can single out particular foes to hunt, making you better at defeating them. You target and brutalize your chosen foe with either a bow or melee weapons, while supporting your allies with your skills.", "When you speak, it’s with the voice of practical experience, especially involving wilderness exploration.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You craft weapons and train animals in preparation for your next venture. If you prefer to get outside, you might go on hunts or scout nearby areas to better understand your environment.", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "Ranger", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null, null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You guide your allies through the wilderness or follow tracks. You keep an eye out for trouble, constantly alert for danger even when it’s not overt.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8") },
                    { new Guid("a171edb5-59c0-4468-b710-a6b9df2f4497"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 12, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "Rage consumes you in battle. You delight in wreaking havoc and using powerful weapons to carve through your enemies, relying on astonishing durability without needing complicated techniques or rigid training. Your rages draw upon a vicious instinct, which you might associate with an animal, a spirit, or some part of yourself. To many barbarians, brute force is a hammer and every problem looks like a nail, whereas others try to hold back the storm of emotions inside them and release their rage only when it matters most.", "You summon your rage and rush to the front lines to smash your way through. Offense is your best defense—you’ll need to drop foes before they can exploit your relatively low defenses.", "You use intimidation to get what you need, especially when gentler persuasion can’t get the job done.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You might head to a tavern to carouse, build up the fearsome legend of your mighty deeds, or recruit followers to become a warlord in your own right.", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "Barbarian", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null, null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You look out for danger, ready to rush headfirst into battle in an instant. You climb the challenging rock wall and drop a rope for others to follow, and you wade into the risky currents to reach the hidden switch beneath the water’s surface. If something needs breaking, you’re up to the task!", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("f7cb4156-4ec7-4c78-bd28-4db83a0f5ade"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 8, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Deities work their will upon the world in infinite ways, and you serve as one of their most stalwart mortal servants. Blessed with divine magic, you live the ideals of your faith, adorn yourself with the symbols of your church, and train diligently to wield your deity’s favored weapon. Your spells might protect and heal your allies, or they might punish foes and enemies of your faith, as your deity wills. Yours is a life of devotion, spreading the teachings of your faith through both word and deed.", "If you’re a warpriest, you balance between casting spells and attacking with weapons, typically the favored weapon of your deity. If you’re a cloistered cleric, you primarily cast spells. Most of your spells can boost, protect, or heal your allies. Depending on your deity, you get extra spells to heal your allies or harm your enemies.", "You might make diplomatic overtures or deliver impressive speeches. Because you’re wise, you also pick up on falsehoods others tell.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You might perform services at a temple, travel to spread the word of your deity, research scripture, celebrate holy days, or even found a new temple.", null, new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "Cleric", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You detect nearby magic and interpret any religious writing you come across. You might also concentrate on a protective spell for your allies in case of attack.After a battle or hazard, you might heal anyone who was hurt.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") },
                    { new Guid("df6b0137-7082-470f-939f-5d241ef7d651"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), 8, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "There’s no sight more beautiful to you than a strange brew bubbling in a beaker, and you consume your ingenious elixirs with abandon. You’re fascinated by uncovering the secrets of science and the natural world, and you’re constantly experimenting in your lab or on the go with inventive concoctions for every eventuality. You are fearless in the face of risk, hurling explosive or toxic creations at your foes. Your unique path toward greatness is lined with alchemical brews that push your mind and body to their limits.", "You lob bombs at your foes, harry your enemies, and support the rest of your party with potent elixirs. At higher levels, your mutagens warp your body into a resilient and powerful weapon.", "You provide knowledge and experience about alchemical items and related secrets, such as poisons and diseases.", new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), "You experiment in an alchemical lab, brewing elixirs, making bombs, and furthering your alchemical knowledge.", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b5a58093-b365-4b88-8f0e-05317473522b"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "Alchemist", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null, null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), "You keep an eye out for trouble with your bombs at the ready, while giving advice on all things alchemical and mysterious.", new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8") }
                });

            migrationBuilder.InsertData(
                table: "Deities",
                columns: new[] { "Id", "AlignmentId", "CategoryId", "Description", "DivineFontsId", "DomainsId", "Name" },
                values: new object[,]
                {
                    { new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1"), new Guid("54f32060-3da3-4edf-b6dc-3839b8b7415d"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "The Midnight Lord embodies and glorifies pain, shadows, and mutilation, and he is one of the most twisted and malevolent gods on the face of Golarion. Once known as Dou-Bral, he crafted the immense Star Towers that still help keep Rovagug pinned in his prison at Golarion’s heart, lending his own skill and ability to the great deific alliance to bind that evil entity. Yet a divine argument between him and his sister Shelyn resulted in the god departing for parts unknown. Zon-Kuthon traveled beyond the edges of the multiverse and stared into the face of the incomprehensible things that dwell there. No one knows what he found in that place, but he returned—changed, but claiming to be strengthened by what he had endured. Likewise, the nation of Nidal on Golarion, which is bound to him, is a nation of survivors, founded by those few strong enough to do what they must so their people could survive the terrible aftermath of Earthfall and the Age of Darkness that followed.", null, null, "Zon-Kuthon" },
                    { new Guid("eda61d79-9877-483f-b660-bc282d270bb6"), new Guid("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "Abadar is worshipped as the god of cities, law, merchants, and wealth. Abadar’s cathedral-banks are found in many cities and places where order thrives or is gaining a foothold. Aristocrats, city guards, merchants, and those working in legal practice or who have the well-being of their community on their mind are common worshippers of the god of cities, along with dwarves in general. Abadaran priests living in cities often serve as judges, lawyers, and clerks, while those who live on the frontier work as roving magistrates, acting as judge, jury, and executioners in the name of order.", null, null, "Abadar" },
                    { new Guid("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), new Guid("54f32060-3da3-4edf-b6dc-3839b8b7415d"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "Asmodeus is the First, the Dark Prince, the lord of darkness and law, and the ruler of the plane of Hell. If Asmodeus’s own scriptures are to believed—and they are corroborated by certain other accounts, like the angel-penned Book of the Damned—he is one of the oldest beings of the multiverse. These texts claim that in time before time, in a world not yet created, Asmodeus and his brother Ihys were among the first gods in existence. During these unnamed ages, the two gods quarreled over the fate of the souls of their creations, and Asmodeus slew his brother. Confident that Ihys’s act of granting mortals free will was folly, Asmodeus made his own convictions known: that existence is best served by absolute order and discipline. These claims contradict other popular creation myths, and both theologians and immortal agents of the gods doubt Asmodeus’s claims to varying degrees, but while there is no evidence to prove them, they are also difficult to refute.", null, null, "Asmodeus" },
                    { new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f"), new Guid("2ad80bbd-a735-4431-9e3a-f784e053b756"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "As symbolized by the three daggers of her religious symbol, Calistria has three aspects: lust, revenge, and trickery. Silver-tongued and charming, she is a master of weaving insults into compliments and laying intricate groundwork for retribution at its finest. She is a goddess of vengeance, but it would be a mistake to assume that means she pursues justice. Calistria is fickle, shifting her loyalties and interests as her whims take her—though she never forgets a slight, and any who think she has forgiven will surely find it is only a matter of time before they are targeted by a long-term plot of revenge to lay them thoroughly low.", null, null, "Calistria" },
                    { new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), new Guid("add12009-9c8a-4287-b02b-7e5b9459bf44"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "The night didn’t know beauty until Desna came into existence. While the other gods toiled away to create the world, she set her sights on the heavens, placing each star in the sky. After surveying her artistry, she hung the brightest star high in the north and made it her home. Her first gift to mortals was this beacon of hope, a twinkling sign in the dark sky that they could turn to when lost or unsure of themselves. Desna provides safe passage through the darkness to all, should they choose to follow.", null, null, "Desna" },
                    { new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81"), new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "Unlike many other good deities, Erastil does not send his followers out into the world to fight and crush evil. Eschewing crusades and other ventures that take his followers away from their homes, Erastil watches over those who devote their lives to family and community. He is primarily an agricultural deity, specifically focusing on those aspects of nature that either can be tamed or are of use to his followers. His domain encompasses the plants and animals that farmers, hunters, and ranchers deal with in their everyday lives. While he is a protective deity, Erastil steps in only when quiet, pastoral lives are threatened. He desires his followers to live their lives in peace, with no risk of being conscripted into armies, devoured by monsters, or destroyed by magic.", null, null, "Erastil" },
                    { new Guid("21794a2c-45f8-404a-9ecb-8897571f6c15"), new Guid("2ad80bbd-a735-4431-9e3a-f784e053b756"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "The clash of steel, the cry of victory, the gasping denial of death: these are the sound of prayers to Our Lord in Iron, for to follow Gorum is to fight. Gorum does not care the reason for battle—a village’s desperate stand against raiders is no less worthwhile to him than a crusader army marching against demons in the Sarkoris Scar—nor does he choose sides in such clashes. Good or evil, law or chaos, the reason for the fight is irrelevant. It is the thrill of battle that finds his favor, the crucible of struggle in which victory is there for the taking.", null, null, "Gorum" },
                    { new Guid("196494f4-f104-45ad-8216-2c8bf68d3943"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "A timeless entity birthed from the first wind to stir the vast oceans, Gozreh wanders the world in the air and the seas. Sailors drop boxes of cargo as offerings to avoid a fatal storm, hoping to please the Wind and the Waves, even though they know that such pleas are far more likely to go unnoticed as they are to draw their deity’s attention. The deity’s temperament is fickle and their fury swift, hurling bolts of lightning and dragging to the crushing depths those who dare befoul the natural world. Gozreh is the sea that encapsulates the land and the wind that moves its surface, the birds that traverse the sky and the clouds that shield them.", null, null, "Gozreh" },
                    { new Guid("3d200ca3-0e4a-4a64-a8a1-0ad34870590c"), new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "Iomedae, the youngest among the prominent deities of the Inner Sea region, had already proven herself worthy of divinity before her ascension. Born in Cheliax, she followed the path of the sword and fought evil, eventually becoming a paladin of Aroden’s herald Arazni. She became a legend among the Shining Crusade, leading the Knights of Ozem in a series of victories over the Whispering Tyrant. Iomedae became the third known mortal to pass the Test of the Starstone when she ascended to divinity in 3832 AR. As Arazni had been slain during the Shining Crusade, Aroden elevated the newly ascended goddess to be his new herald. When Aroden himself died, Iomedae inherited most of his worshippers and became a major deity of honor and justice.", null, null, "Iomedae" },
                    { new Guid("980a89b8-bd72-4434-a744-10cdc645cee6"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "Irori exemplifies the concepts of self-perfection. His dogma states that he was a mortal who gained godhood through achieving a physical and mental state that surpassed mortal limitations. His followers seek to emulate their god’s divine state by perfecting themselves using the words of the Unbinding of Fetters, Irori’s sacred text. The illuminated pages of the tome detail numerous physical, spiritual, and mental exercises, as well as methods of learning and remembering.", null, null, "Irori" },
                    { new Guid("ac4c804a-c975-40f5-bdd2-7dcb97e9502d"), new Guid("add12009-9c8a-4287-b02b-7e5b9459bf44"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "Once a mortal human, Cayden Cailean is now one the few deities known as the Ascended. In his mortal years, Cayden was a sellsword of no small fame, known for his boisterous manner, skill with a blade, and fearless resolve. During a particularly rowdy night of drinking, a series of escalating dares led the wandering mercenary to attempt the Test of the Starstone. He emerged from the Starstone Cathedral 3 days later, laughing, a fully realized god. Divine responsibility did little to change Cayden’s attitude from what it was in his mortal life. He continues to crave adventure, drink, and pleasurable company while abhorring bullies, tyrants, and cowards.", null, null, "Cayden Cailean" },
                    { new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "To some, magic is a powerful weapon. To others, it’s a malleable tool. And to a few, it’s a source of purpose. With an understanding of spellcasting, creatures can cause fire to erupt from their hands, call otherworldly beings to aid them, bewitch the senses, and even bring the dead back to life. The ability to reshape reality to better suit one’s needs and desires is a powerful call that most only dream of being able to answer, and few are ever able to truly master such might. One such master was Nethys, who was revered as a god-king in ancient Osirion. Having sought to unlock all of the secrets and potential held within the planes and beyond, Nethys shattered his own mind from the sheer overload of knowledge to which he was exposed. Witnessing all of creation, the secrets of the universe, and the vast expanse of what has been seen and will be seen rent his mind in the same moment he elevated to the status of a god. Nethys gained unlimited power and the skill to utilize it, but at the cost of his core self and mental security. This resulted in a split soul, two sides warring within the same body. One seeks to destroy the world, to purge it through fire and ruin, and to conquer all that exists. The other attempts to protect the world, to elevate and educate, and to release it from its limits.", null, null, "Nethys" },
                    { new Guid("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), new Guid("25f9299a-9a7c-40bc-b8bd-58588d19381b"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "For those who revel in the corruption of the pure or who find themselves spurned and neglected by a world that despises their differences, Lamashtu offers respite among her grotesque brood. The Mother of Monsters readily accepts mortals into her fold and has made it her goal to twist mortal life toward her abhorrent ideals. Her intervention is widely known to inflict corruptions and terrible nightmares. Ostracized individuals who share her ideals will find this intervention a boon, while others treat similar events as horrible curses.", null, null, "Lamashtu" },
                    { new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), new Guid("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "The chosen of Urgathoa do not dread the flaws of mortal flesh, such as aging, disease, or even death, for so long as they indulge in excess above all else, their goddess offers eternal freedom from such fickle constraints. Urgathoa herself was once a mortal woman who challenged and rejected the tenets of deities whose followers expected mindless conformity, temperance, and restraint. Why would the gods craft Golarion into a near-endless buffet abundant with pleasures of the body and mind if the living weren’t destined to feast from it? Urgathoa so loved satiating her life’s appetites that in death, she spat in the face of Pharasma’s judgment, murdered the psychopomp assigned to aid her transition to the afterlife, and tore herself from the Boneyard with a feat of will that not only returned her to the Material Plane but also transformed her into the first divine undead creature.", null, null, "Urgathoa" },
                    { new Guid("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0"), new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "The head of the dwarven pantheon is the most visible of the dwarven deities, to the extent that Torag is the only dwarven deity most non-dwarves know of. While the other dwarven gods represent specific areas of dwarven life and culture, thus forming an expansive and comprehensive dwarven pantheon, Torag’s areas of concern are those most central to dwarven society. In his own family, Torag models the values of community and protection that have cemented deep-rooted relationships among dwarven clans. His focus on strategy and tactical acumen centers on protection, reflected in dwarves’ impenetrable fortresses and conservative military tactics, including their willingness to use offensive maneuvers as a form of defense. He also represents the forge: the creation of fine works from raw materials, practice and mastery of a craft, and pride in one’s work. His purview extends even to those activities that feed the forge and dwarven artisanship, such as mining the earth for raw ore and gemstones. Torag’s oversight over these core concepts has secured his place at the head of the dwarven pantheon for ages. It was Torag who sent the dwarves on their legendary Quest for Sky during the Age of Darkness, and his worship was long-established even then. Indeed, among dwarves, Torag is often called the Father of Creation.", null, null, "Torag" },
                    { new Guid("c624bf0e-d22c-4e01-8691-041083462102"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "Sarenrae is one of the most popular deities on Golarion by virtue of her association with the life-giving sun and her perpetual offer to help anyone be their best, even when they have made mistakes. Most people thank her for her kind work to channel the sun’s power for everyone’s safety and livelihood, and thank her clergy for granting her healing power to all who need it. Mortals look to the Dawnflower as an example of boundless love, exquisite kindness, and true patience. They pray to her to heal the sick, lift up the downtrodden, and illuminate darkness of circumstance as well as darkness of spirit. Her followers aspire to emulate her through generosity, nurturing, truthfulness, and selfless courage. They oppose evil everywhere with words first, and when necessary, with scimitar and flame.", null, null, "Sarenrae" },
                    { new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), new Guid("25f9299a-9a7c-40bc-b8bd-58588d19381b"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "Rovagug has no single holy scripture. He has little use for one, for his sole commandment is to destroy, and his followers need no instruction in how to accomplish that. The figurative and literal monsters who worship Rovagug share their myths and legends in secret shrines and hidden caves, calling him the Rough Beast, the Imprisoned King, the Tide of Fangs, the Unmaker, and the Worldbreaker. They tell each other that each life they snuff out, each piece of art they destroy, each work of labor they bring tumbling down puts a crack in the prison that holds their god. Each of their little efforts of destruction adds up and will one day free him, setting him loose to bring about the end of all things.", null, null, "Rovagug" },
                    { new Guid("f5f38a92-1302-4d45-adf8-38452dde188b"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "Shelyn watches over existence with a kind and loving eye, encouraging mortals to make the best of their lives by spreading love, art, and beauty as best they can. Even the crudest artistic awakenings are worthy of praise in the goddess’s eyes, as they represent an individual’s expression of life’s trials and triumphs. She believes every creature is worthy of love and capable of creating art in their own way. Shelyn’s religion does not require chastity, fidelity, or a particular relationship structure, as the passion of early romance is a facet of love just as important and valid as the comfortable trust between a long-married couple. However, she does make the distinction between courtship and pure carnal desire, and she prefers that trysts blossom into more meaningful relationships along the way.", null, null, "Shelyn" },
                    { new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606"), new Guid("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "Norgorber is the most mysterious of the Ascended, the group of mortals who assumed godhood after passing the Test of the Starstone. Unlike Iomedae’s and Cayden Cailean’s mortal existences, Norgorber’s life before his ascension is a mystery; the god himself has shrouded details of his mortal life in secrecy. This is no surprise to those familiar with Norgorber—he is the master of all secrets, a calculating manipulator who cleverly and ruthlessly wields the power of hidden knowledge to achieve his own ends. Only his most trusted worshippers know enough about his goals to assist in the god’s plans, and even those worshippers often have their memories modified after their parts in Norgorber’s schemes are complete.", null, null, "Norgorber" },
                    { new Guid("01777837-1255-4d6a-9301-96dc48fffee4"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), "No record of history, and not even other gods, can recall a time before Pharasma. Her throne lies within a vast, gothic cathedral located on the infinite Spire at the center of the planes. From here, she looks both forward and backward in time, observing the births, lives, and deaths of every soul, as she serves as the final arbiter of a soul’s destination after death. Psychopomp servants of Pharasma guide and safeguard newly dead souls along the River of Souls to her realm, where she judges each soul and ensures it is sent to the proper plane for its afterlife, according to its alignment and mortal deeds. Although she can see all possible fates and knows the fate of each individual, free will and choice can alter a soul’s final destination, and she places great weight on the individual’s actions and personal choices. Therefore, Pharasma withholds her final judgment until a soul stands before her. Her prophecies are cryptic, and their full meanings are rarely revealed until the foretold events occur.", null, null, "Pharasma" }
                });

            migrationBuilder.InsertData(
                table: "Feats",
                columns: new[] { "Id", "ActionTypeId", "CanBeLearnedMoreThanOnce", "FeatTypeId", "FrequencyId", "Level", "Name", "RollableEffectId", "Special", "TraitsId", "Trigger" },
                values: new object[,]
                {
                    { new Guid("b5a95cad-67ab-4716-b582-4a11d8b863d1"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), true, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Skill Training", null, "You can select this feat multiple times, choosing a new skill to become trained in each time.", null, null },
                    { new Guid("d466988f-8d00-4230-ab88-5c963abbecd1"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Slippery Secrets", null, null, null, null },
                    { new Guid("ad4fe73a-0518-46c1-bfee-130d1b2053ab"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Read Lips", null, null, null, null },
                    { new Guid("2b952cb7-5972-4866-a8d3-92410b2ed759"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Snare Crafting", null, null, null, null },
                    { new Guid("7aded813-2325-4a4d-aea7-077680584823"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Sign Language", null, null, null, null },
                    { new Guid("b1c71e21-bea7-453b-b23a-13ecc1b3675b"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Specialty Crafting", null, null, null, null },
                    { new Guid("3bb4c8cd-9368-43dd-92b2-99174568570a"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Shameless Request", null, null, null, null },
                    { new Guid("2107ba8d-4766-4434-b23e-fe90d9837b02"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Robust Recovery", null, null, null, null },
                    { new Guid("8ee83a83-4763-4423-87ff-c12ef752a494"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Ride", null, null, null, null },
                    { new Guid("73d6b44a-a2a6-4a70-be2c-2dd59c09657a"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Rapid Mantel", null, null, null, null },
                    { new Guid("8a71ca0e-0c73-4fdd-bde7-431f3237bca6"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Quick Squeeze", null, null, null, null },
                    { new Guid("f3cdc428-01a4-4687-8d48-8de530cbd154"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Quick Unlock", null, null, null, null },
                    { new Guid("eda136b0-c9e5-4b60-abd3-cc534c043a00"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Quick Swim", null, null, null, null },
                    { new Guid("48c371fb-6e9c-4d4f-965d-d56694b52100"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Quick Repair", null, null, null, null },
                    { new Guid("8df39189-1886-4523-95b0-5980cad573f4"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Quick Recognition", null, null, null, null },
                    { new Guid("7ba0d3ef-7d44-42e4-8e2d-0b8bce8c9d16"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Steady Balance", null, null, null, null },
                    { new Guid("7e3b8e25-d2ad-400e-9b03-a4993d0e5f8b"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Quick Identification", null, null, null, null },
                    { new Guid("064690bd-cd97-47a5-9e4c-fb8672bb6225"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Quick Disguise", null, null, null, null },
                    { new Guid("89a41605-0006-4a7b-a101-f73d32f75a04"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Quick Coercion", null, null, null, null },
                    { new Guid("2a59396f-bf2a-4075-8207-3c906b7624ff"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Quick Climb", null, null, null, null },
                    { new Guid("f725b35e-73bc-45b9-b5ee-6dfb225147b4"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Quiet Allies", null, null, null, null },
                    { new Guid("7de0d323-fc78-4154-a4d0-91e8af5ef631"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Streetwise", null, null, null, null },
                    { new Guid("30763d23-d261-4295-b636-f94bca378bec"), new Guid("668ed964-cf7f-43df-b4b3-6a89c28551aa"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Recognize Spell", new Guid("ab1082ab-df6b-4a9d-880f-7ab186891b2f"), null, null, "A creature within line of sight casts a spell that you don’t have prepared or in your spell repertoire, or a trap or similar object casts such a spell. You must be aware of the casting." },
                    { new Guid("2818e8e6-4d55-4f83-ad45-6decff2673c1"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Subtle Theft", null, null, null, null },
                    { new Guid("24bfd707-04bb-4464-a3ad-e1dd040c0377"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Powerful Leap", null, null, null, null },
                    { new Guid("045ae2b1-ef9d-44a3-898d-8feb0832b94c"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Scare to Death", new Guid("a2a1dedd-eaa8-49bd-9189-7ce92039987e"), null, null, null },
                    { new Guid("d1d5b37b-2fcd-4699-892f-5c81cc437323"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Train Animal", new Guid("e2d96fa8-70a4-45cf-b7a1-010a8790b583"), null, null, null },
                    { new Guid("219b84b9-cb31-44df-b37e-6bf4916e5dfb"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Trick Magic Item", new Guid("14481cdc-273c-4a73-9c45-58d2db7309f4"), null, null, null },
                    { new Guid("8b9edbcc-05ce-4df7-bc51-910ff6be643d"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), true, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Weapon Proficiency", null, "You can select this feat more than once. Each time you do, you become trained in additional weapons as appropriate, following the above progression.", null, null },
                    { new Guid("52456558-ce51-4f42-8ff2-fd4dbb72c25d"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Wary Disarmament", null, null, null, null },
                    { new Guid("b5d31ebb-d361-4780-93c5-324bfd3c39b8"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Ward Medic", null, null, null, null },
                    { new Guid("76a68ae1-d7e0-4b2a-af54-4978b06db5cb"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Wall Jump", null, null, null, null },
                    { new Guid("8ee11526-08b4-451e-8424-83704f0d1a70"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Virtuosic Performer", null, null, null, null },
                    { new Guid("ec332db6-b06a-4a93-9935-756953f7a857"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Student of the Canon", null, null, null, null },
                    { new Guid("9648e97f-800c-492f-9277-93a17174bab1"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 3, "Untrained Improvisation", null, null, null, null },
                    { new Guid("ce1dc7c1-c529-42a2-a2f5-f6ca99df1804"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Unified Theory", null, null, null, null },
                    { new Guid("dfb5e49e-df3e-443e-bfbf-d41e042306ed"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Underwater Marauder", null, null, null, null },
                    { new Guid("5fec7506-9390-4455-83ed-fc3666ca4fa2"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Toughness", null, null, null, null },
                    { new Guid("fee17526-90f5-401c-bdec-d084f40852a7"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Titan Wrestler", null, null, null, null },
                    { new Guid("064e540b-673f-4abb-bacc-fda48911b21a"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Terrified Retreat", null, null, null, null },
                    { new Guid("288c9224-1ffe-4acc-8343-ba9a40e76c38"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), true, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Terrain Stalker", null, "You can select this feat multiple times. Each time, choose a different type of terrain.", null, null },
                    { new Guid("17232376-8797-4f5b-bee0-2614d6938d5a"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), true, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Trained Expertise", null, "You can select this feat more than once, choosing a different type of terrain each time.", null, null },
                    { new Guid("3539bdbe-8e7f-45c0-a094-649d85d3adca"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Swift Sneak", null, null, null, null },
                    { new Guid("67a42abf-7456-4bca-a74b-ef8d2fdc4459"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Survey Wildlife", null, null, null, null },
                    { new Guid("eb5ca078-b3f2-4e84-8df4-526ced138637"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Unmistabable Lore", null, null, null, null },
                    { new Guid("9415b689-43b4-4177-b861-32cab298b5fe"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Planar Survival", null, null, null, null },
                    { new Guid("7586b528-bef3-41be-b1f0-ea1fcb958c88"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Quick Jump", null, null, null, null },
                    { new Guid("f552a716-9e47-457c-a9ec-51fa8cd3a85d"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Oddity Identification", null, null, null, null },
                    { new Guid("d76bcd62-20d9-4fce-9fc1-735ec21a0cb2"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Fascinating Performance", null, null, null, null },
                    { new Guid("fa30f639-b913-4050-b7bc-a8e9991178f1"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Experienced Smuggler", null, null, null, null },
                    { new Guid("0e715099-8cfd-449b-a6b0-37467f68accc"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Experienced Professional", null, null, null, null },
                    { new Guid("dbd06473-8700-438f-b4e1-35474b87171c"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Expeditious Search", null, null, null, null },
                    { new Guid("b8193a38-a31c-45f2-a715-2542f09b97ca"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Adopted Ancestry", null, null, null, null },
                    { new Guid("57442d19-cae2-465c-9d3d-2e77ecde2a50"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Alchemical Crafting", null, null, null, null },
                    { new Guid("1d6f005c-1b19-4072-8609-62af32b427e2"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 3, "Ancestral Paragon", null, null, null, null },
                    { new Guid("a6def9d1-3dd5-4d2f-8e75-1773753119d9"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Arcane Sense", null, null, null, null },
                    { new Guid("384659b6-1c1c-4612-9727-2d8406c2a328"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), true, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Armor Proficiency", null, "You can select this feat more than once. Each time, you become trained in the next type of armor above.", null, null },
                    { new Guid("e4c0f632-f086-40f7-81c4-2d54f1bcb5b9"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), true, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Assurance", null, "You can select this feat multiple times. Each time, choose a different skill and gain the benefits for that skill.", null, null },
                    { new Guid("ca8d59e8-f938-4ffb-9890-9bed87134d5b"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), true, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Automatic Knowledge", null, "You can select this feat multiple times, choosing a different skill each time. You can use Automatic Knowledge with any skills you have chosen, but you can still use Automatic Knowledge only once per round.", null, null },
                    { new Guid("6684d89b-1994-4fa9-8b6b-c5123b642e86"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Bargain Hunter", null, null, null, null },
                    { new Guid("5ac7371e-af01-460e-a188-198481c67505"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Battle Cry", null, null, null, null },
                    { new Guid("6db67ca1-3fef-4705-9ad3-4d0e121e943b"), new Guid("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Battle Medicine", null, null, null, null },
                    { new Guid("1acd1549-a4de-477d-a3f4-e862c04c8a7a"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Bizarre Magic", null, null, null, null },
                    { new Guid("0422a543-ec8f-4c04-9e15-5b4fd5c1f065"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Bonded Animal", null, null, null, null },
                    { new Guid("a3395df1-fc95-4989-833c-c0d7465ecd1c"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Breath Control", null, null, null, null },
                    { new Guid("fffc0274-b5cd-428f-8144-a7d8b01f5986"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Dubious Knowledge", null, null, null, null },
                    { new Guid("17f35e0f-3778-4143-b516-d08faf79bc68"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Divine Guidance", null, null, null, null },
                    { new Guid("15ccc079-da12-4678-8b48-f626e51418df"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Diehard", null, null, null, null },
                    { new Guid("2fbc54de-6f02-49d5-a01c-6adfd732a81e"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Craft Anything", null, null, null, null },
                    { new Guid("5c26de36-847d-4a16-8871-0a2016fdfacc"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Courtly Graces", null, null, null, null },
                    { new Guid("059f1e6a-f8cd-4be2-8024-ddc21dd7cd60"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Continual Recovery", null, null, null, null },
                    { new Guid("68a98dbf-4a45-4217-a94f-2d0969915d96"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Fast Recovery", null, null, null, null },
                    { new Guid("a38f19f2-3b2d-4907-8425-d71dc351e8df"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Connections", null, null, null, null },
                    { new Guid("269b8813-ba84-42c6-9b73-11de579797bb"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Combat Climber", null, null, null, null },
                    { new Guid("9ab4e3c9-f592-4c0d-ac6e-adb33651feca"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Cloud Jump", null, null, null, null },
                    { new Guid("d1f81e6f-f97f-4bf3-8ddb-7db5ff7c351c"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Pickpocket", null, null, null, null },
                    { new Guid("43ae43aa-11d2-420f-bf17-6978f8a45a0f"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Charming Liar", null, null, null, null },
                    { new Guid("9c848549-edaa-49b9-aa64-fcea1ccbc966"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Cat Fall", null, null, null, null },
                    { new Guid("85740fcc-7aaf-494f-81d7-8360620977d1"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Canny Acumen", null, null, null, null },
                    { new Guid("38b0c4f7-2ad6-4c04-928d-dc53f2ff39b7"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Confabulator", null, null, null, null },
                    { new Guid("174c21f8-b29a-4141-9070-eca5ecfdee71"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Feather Step", null, null, null, null },
                    { new Guid("a64ac93e-e7c5-46d1-85ec-72d93d5dcf7a"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Experienced Tracker", null, null, null, null },
                    { new Guid("fccdaf8a-46b0-4a18-9a90-dbb228317b58"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Foil Senses", null, null, null, null },
                    { new Guid("37e3bc29-be7b-4112-92aa-0b7dddbc2da3"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Fleet", null, null, null, null },
                    { new Guid("12456924-12d6-4f6e-bde1-100892c683b5"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Legendary Performer", null, null, null, null },
                    { new Guid("171b6ae6-cda9-45a7-8c0a-64672e338e0b"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Legendary Professional", null, null, null, null },
                    { new Guid("ff4b4b20-73c2-4a67-a1a5-e504c8aa2dc6"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Legendary Sneak", null, null, null, null },
                    { new Guid("d264d400-645f-4e7e-8100-ae5b2caf9e0e"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Legendary Survivalist", null, null, null, null },
                    { new Guid("9ee79ba9-47ac-4cf5-906d-9e88190e8d22"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Legendary Thief", null, null, null, null },
                    { new Guid("c041f814-94c4-43a1-be45-3bcd2621f2bb"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Legendary Medic", null, null, null, null },
                    { new Guid("8bfbc2e3-87d6-480d-8fd7-baeb77e465cd"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Lenghty Diversion", null, null, null, null },
                    { new Guid("a90aba98-98fe-4a4d-86a6-93025e5d558a"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Magical Crafting", null, null, null, null },
                    { new Guid("2c8b47a4-eb56-491b-82fd-a3f894282025"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), true, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Additional Lore", null, "You can select this feat more than once. Each time you must select a new subcategory of Lore and you gain the additional skill increases to that subcategory for the listed levels.", null, null },
                    { new Guid("53bda5e8-f9d2-461f-9495-c9db35ab99c1"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Magical Shorthand", null, null, null, null },
                    { new Guid("8dc95af1-d049-457f-91f8-311ead81336d"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Multilingual", null, "You can select this feat multiple times. Each time, you learn additional languages.", null, null },
                    { new Guid("c7443dbf-2f52-48df-a53c-8dd6ad6732c0"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Natural Medicine", null, null, null, null },
                    { new Guid("df3e0135-e1de-4b1f-a580-19f521c5f328"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Nimble Crawl", null, null, null, null },
                    { new Guid("1332e046-d8ea-4a33-9a07-69308317891c"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Lie to Me", null, null, null, null },
                    { new Guid("3afb7bd6-f0c2-4187-9d47-f7a06d512fd3"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Legendary Linguist", null, null, null, null },
                    { new Guid("5803b272-2368-49ce-ba0b-8c97aa753885"), new Guid("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Legendary Negotiation", null, null, null, null },
                    { new Guid("37f7d759-3c83-491a-a516-b41b64cf57a7"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Lasting Coercion", null, null, null, null },
                    { new Guid("3f62ad52-d80b-4662-979c-6eb66a224801"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Foil Senses", null, null, null, null },
                    { new Guid("6f59e2f4-2100-436d-8cf8-266585faa937"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Glad-Hand", null, null, null, null },
                    { new Guid("ccdd4b23-9813-407e-a7a6-8bc2cdafbab5"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Group Coercion", null, null, null, null },
                    { new Guid("06f5008a-8b53-4c11-b0ec-2176e135d8b8"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 15, "Legendary Codebreaker", null, null, null, null },
                    { new Guid("18e0c385-d2ba-4646-989d-2e49d43d5f36"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Hefty Hauler", null, null, null, null },
                    { new Guid("43f75824-0d49-466f-aa58-e40046c4a6d4"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Hobnobber", null, null, null, null },
                    { new Guid("89921651-065e-48f8-98cb-c9b6cf6c71e9"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Impeccable Crafting", null, null, null, null },
                    { new Guid("738f86de-6f73-4ffa-a790-abd8feeb43c5"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Group Impression", null, null, null, null },
                    { new Guid("6f87700e-7194-47d6-a9b2-20e0e2e53482"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Impressive Performance", null, null, null, null },
                    { new Guid("9b475bb4-2086-4f81-b4ab-ef3f8f09f5db"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 11, "Incredible Investiture", null, null, null, null },
                    { new Guid("a1804dfb-e3e0-45aa-b735-2f37fed15779"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Intimidating Glare", null, null, null, null },
                    { new Guid("0f49189c-434c-4490-8cbe-5235e6274441"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 2, "Intimidating Prowess", null, null, null, null },
                    { new Guid("c8dd98a8-e102-4751-9606-88ed457bfdeb"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Inventor", null, null, null, null },
                    { new Guid("4f6b0041-df64-4d81-9ddd-baebcfdd28ed"), new Guid("4716abe4-50c3-447d-bb27-2b268667b3c2"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 7, "Kip Up", null, null, null, null },
                    { new Guid("3d690c93-0e1b-42c8-9d62-4e4219729dec"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), false, new Guid("58ef6c11-b8bd-411e-8222-6434fa491d11"), null, 1, "Impressive Initiative", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Heritages",
                columns: new[] { "Id", "Description", "Name", "RacesId", "RarityId" },
                values: new object[,]
                {
                    { new Guid("b54692a4-5791-4971-9590-17889ca0cbaa"), "One of your parents was an orc, or one or both were half-orcs. You have a green tinge to your skin and other indicators of orc heritage. You gain the orc trait, the half-orc trait, and low-light vision. In addition, you can select orc, half-orc, and human feats whenever you gain an ancestry feat.", "Half-Orc", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("c2c39377-feae-4142-a4c9-6d0e458d355c"), "You were born with a strange blessing: bereft of the typical halfling luck, you can instead manipulate the fortunes of others. You can never take the Halfling Luck feat, and you gain the Jinx action.", "Jinxed Halfling", null, new Guid("7eb0082a-50c0-44ef-a990-7aae6cb9cf27") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), "You descend from fiends or bear the mark of the fiendish realms, manifesting as some unusual feature that belies your heritage, such as horns or a tail. You gain the tiefling trait, in addition to the traits from your ancestry. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can choose from tiefling feats and feats from your ancestry whenever you gain an ancestry feat.", "Tiefling", null, new Guid("7eb0082a-50c0-44ef-a990-7aae6cb9cf27") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), "Thanks to an ancient bargain, your soul has been reborn as a duskwalker, a planar scion with a connection to psychopomps and the Boneyard. You gain the duskwalker trait in addition to the traits from your ancestry. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. Neither your body nor your spirit can ever become undead. You can choose from duskwalker feats and feats from your ancestry whenever you gain an ancestry feat.", "Duskwalker", null, new Guid("7eb0082a-50c0-44ef-a990-7aae6cb9cf27") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), "You are the scion of a vampire, half living and half undead, gifted with uncanny charm and grace, a bloodless pallor, and elongated incisors. You gain the dhampir trait, in addition to the traits from your ancestry. You have the negative healing ability, which means you are harmed by positive damage and healed by negative effects as if you were undead. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can choose from dhampir feats and feats from your ancestry whenever you gain an ancestry feat.", "Dhampir", null, new Guid("7eb0082a-50c0-44ef-a990-7aae6cb9cf27") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), "Your mother was a hag. Your heterochromatic eyes are the most obvious signifier of this parentage, but you likely also have a slighter build, paler skin, and darker hair than most members of your other parent’s ancestry. You gain the changeling trait. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can select from changeling feats and feats from your other parent’s ancestry whenever you gain an ancestry feat.", "Changeling", null, new Guid("7eb0082a-50c0-44ef-a990-7aae6cb9cf27") },
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), "You descend from celestials or were touched by the celestial realms, gaining an air of awe and grace, as well as features distinctive to your celestial forebears. You gain the aasimar trait, in addition to the traits from your ancestry. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can choose from aasimar feats and feats from your ancestry whenever you gain an ancestry feat.", "Aasimar", null, new Guid("7eb0082a-50c0-44ef-a990-7aae6cb9cf27") },
                    { new Guid("a3b12707-a7f5-41f0-9f49-f41d1839d5f7"), "Either one of your parents was an elf, or one or both were half-elves. You have pointed ears and other telltale signs of elf heritage. You gain the elf trait, the half-elf trait, and low-light vision. In addition, you can select elf, half-elf, and human feats whenever you gain an ancestry feat.", "Half-Elf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("d4c74254-f221-41a2-b2b9-2d8ad741cbc0"), "You see all colors as brighter, hear all sounds as richer, and especially smell all scents with incredible detail. You gain a special sense: imprecise scent with a range of 30 feet. This means you can use your sense of smell to determine the exact location of a creature. The GM will usually double the range if you're downwind from the creature or halve the range if you're upwind. In addition, you gain a + 2 circumstance bonus to Perception checks whenever you're trying to locate an undetected creature that is within the range of your scent.", "Sensate Gnome", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("03cbc90d-fbf1-488b-ab42-47a80884c75a"), "Humanity's versatility and ambition have fueled its ascendance to be the most common ancestry in most nations throughout the world. Select a general feat of your choice for which you meet the prerequisites (as with your ancestry feat, you can select this general feat at any point during character creation).", "Versatile Heritage", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("3cd57ab7-c57a-4287-82ce-e1473f75af48"), "You're adapted to life in the forest or the deep jungle, and you know how to climb trees and use foliage to your advantage. When Climbing trees, vines, and other foliage, you move at half your Speed on a success and at full Speed on a critical success (and you move at full Speed on a success if you have Quick Climb). This doesn't affect you if you're using a climb Speed. You can always use the Take Cover action when you are within forest terrain to gain cover, even if you're not next to an obstacle you can Take Cover behind.", "Whisper Elf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("f95169fa-400b-446e-8ba2-0dca02ada9bc"), "You have an inborn ability to detect and understand magical phenomena. You can cast the detect magic cantrip as an arcane innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. In addition, you gain a + 1 circumstance bonus to checks to Identify Magic and to Decipher Writing of a magical nature.These skill actions typically use the Arcana, Nature, Occultism, or Religion skill.", "Seer Elf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("4b699d38-c3fc-487c-a55b-f8d561897305"), "You live under the desert’s blazing heat, gaining incredible resilience to warm environments. You gain fire resistance equal to half your level (minimum 1), and environmental heat effects are one step less extreme for you (incredible heat becomes extreme, extreme heat becomes severe, and so on).", "Desert Elf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("3623e7a3-e6e0-49d6-bddf-86374cd4e5d3"), "You were born or spent many years in underground tunnels or caverns where light is scarce. You gain darkvision.", "Cavern Elf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("62d5db67-945b-4cea-971f-9a2fa5038f2d"), "You dwell deep in the frozen north and have gained incredible resilience against cold environments, granting you cold resistance equal to half your level (minimum 1). You treat environmental cold effects as if they were one step less extreme (incredible cold becomes extreme, extreme cold becomes severe, and so on).", "Arctic Elf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("c7209f66-ad64-4356-bf03-aeb4e94bbd6f"), "In your long life, you’ve dabbled in many paths and many styles. Choose a class other than your own. You gain the multiclass dedication feat for that class, even though you don’t meet its level prerequisite. You must still meet its other prerequisites to gain the feat.", "Ancient Elf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("03d1ff17-a448-47c9-b71f-5973a66e2563"), "The power of winter flows through you. This heritage is most common among the Jadwiga of Irrisen, due to their descent from Baba Yaga, and certain Erutaki touched by the spirits. You gain cold resistance equal to half your level (minimum 1), and you treat environmental cold effects as if they were one step less extreme (incredible cold becomes extreme, extreme cold becomes severe, and so on).", "Wintertouched Human", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("635245e9-3230-4dab-8b0b-fac29a761c37"), "Your blood runs hearty and strong, and you can shake off toxins. You gain poison resistance equal to half your level (minimum 1), and each of your successful saving throws against a poison affliction reduces its stage by 2, or by 1 for a virulent poison. Each critical success against an ongoing poison reduces its stage by 3, or by 2 for a virulent poison.", "Strong-Blooded Dwarf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("88f9765e-66ed-4780-bb53-c23c27b4f8ad"), "Growing up, you never tried to lie to get what you wanted, and even when necessary, lying makes you uncomfortable. The especially faithful might even have thought that you were blessed by the dwarven god of duty, Kols. You gain a +1 circumstance bonus to Perception checks to Sense Motive and to Perception DCs against attempts to Lie to you. Furthermore, you gain a +2 circumstance bonus to Diplomacy checks to convince others you speak the truth when you are telling the truth, and you take a –4 circumstance penalty to Lie and to your Deception DC against Sense Motive.", "Oathkeeper Dwarf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("541986ae-7349-44fd-8004-c2e606e4f140"), "You have a remarkable adaptation to hot environments from ancestors who inhabited blazing deserts or volcanic chambers beneath the earth. This grants you fire resistance equal to half your level (minimum 1), and you treat environmental heat effects as if they were one step less extreme (incredible heat becomes extreme, extreme heat becomes severe, and so on).", "Forge Dwarf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("801fba4a-dd78-4f76-beca-ff51faac7b7a"), "Whether through a connection to Torag’s forge, the azers of the Plane of Fire, or another source, you can exude a burst of energy. Mbe’ke and Taralu dwarves of the Mwangi Expanse believe this heritage is a gift from dragons or elemental spirits. Choose one of the following damage types: acid, cold, electricity, or fire. Once chosen, this can’t be changed. You gain the Energy Emanation activity.", "Elemental Heart Dwarf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("967429bb-5245-4a3c-8468-9177f9f1ff77"), "Your ancestors have been tomb guardians for generations, and the power they cultivated to ward off necromancy has passed on to you. If you roll a success on a saving throw against a necromancy effect, you get a critical success instead.", "Death Warden Dwarf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("e019e11d-e494-49d6-8861-5c61a4768b6a"), "You are a descendant of a famed crafter and have your own amazing talent. Other dwarves might consider this a blessing from your ancestors or from the Forgefather himself, depending on where you grew up. You become trained in Crafting (or another skill if you were already trained in Crafting) and gain the Specialty Crafting skill feat, but you can pick two different specialties instead of one.", "Anvil Dwarf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("4023db86-7064-4ad0-936e-e1f5c95e921b"), "Dwarven heroes of old could shrug off their enemies’ magic, and some of that resistance manifests in you. You gain the Call on Ancient Blood reaction.", "Ancient-Blooded Dwarf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("b9e766b7-d4e6-4f93-bc21-8020c2cc09bc"), "Your ancestors lived and worked among the great ancient stones of the mountains or the depths of the earth. This makes you solid as a rock when you plant your feet. You gain a +2 circumstance bonus to your Fortitude or Reflex DC against attempts to Shove or Trip you. This bonus also applies to saving throws against spells or effects that attempt to knock you prone. In addition, if any effect would force you to move 10 feet or more, you are moved only half the distance.", "Rock Dwarf", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("6820eb19-bb58-4d56-9fdf-ce57f72b75d6"), "The blood of the fey is so strong within you that you're truly one of them. You gain the fey trait, in addition to the gnome and humanoid traits. Choose one cantrip from the primal spell list. You can cast this spell as a primal innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. You can change this cantrip to a different one from the same list once per day by meditating to realign yourself with the First World; this is a 10-minute activity that has the concentrate trait.", "Fey-Touched Gnome", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("37a897ea-ac8a-407c-bf26-8443b948c8b3"), "The color of your hair and skin is mutable, possibly due to latent magic. You can slowly change the vibrancy and the exact color, and the coloration can be different across your body, allowing you to create patterns or other colorful designs. It takes a single action for minor localized shifts and up to an hour for dramatic shifts throughout your body. While you're asleep, the colors shift on their own in tune with your dreams, giving you an unusual coloration each morning. When you're in an area where your coloration is roughly similar to the environment (for instance, forest green in a forest), you can use the single action to make minor localized shifts designed to help you blend into your surroundings. This grants you a +2 circumstance bonus to Stealth checks until your surroundings shift in coloration or pattern.", "Chameleon Gnome", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("0bde2b22-b4ee-484d-9052-6c4b47488624"), "You have an incredibly strong connection to the positive energy that flows through the First World, making it harder to attack your life force with negative energy. You gain negative resistance equal to half your level (minimum 1). When you have the doomed condition, the condition affects you as if its value was 1 lower than it actually is (doomed 1 has no effect, doomed 2 causes you to die at dying 3, and so on).", "Vivacious Gnome", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("fdf36b32-00b2-457f-9aca-aa9378c0f92e"), "Your ingenuity allows you to train in a wide variety of skills. You become trained in one skill of your choice. At 5th level, you become an expert in the chosen skill.", "Skilled Heritage", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("0b36fe08-7970-45a3-a816-05d187ae1709"), "You hail from deep in a jungle or forest, and you’ve learned how to use your small size to wriggle through undergrowth, vines, and other obstacles. You ignore difficult terrain from trees, foliage, and undergrowth.", "Wildwood Halfling", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("a8c3e70e-6eb6-4a5e-85cd-755eccc7677e"), "Your ancestors performed many secret acts under the concealing cover of dusk, whether for good or ill, and over time they developed the ability to see in twilight beyond even the usual keen sight of halflings. You gain low-light vision.", "Twilight Halfling", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("cbaec7eb-4492-42a3-83ac-1e82a5658fb8"), "Your finely honed senses quickly clue you in to danger or trickery. You gain a +1 circumstance bonus to your Perception DC, though not to your Perception checks.", "Observant Halfling", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("dce19cbd-7be3-4fd6-939b-48712d5f6daa"), "Your ancestors have traveled from place to place for generations, never content to settle down. You gain two additional languages of your choice, chosen from among the common and uncommon languages available to you, and every time you take the Multilingual feat, you gain another new language.", "Nomadic Halfling", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("1109b6f8-33b0-4868-92f1-49e1ab8135d3"), "Whether from a connection to dark or shadowy fey, from the underground deep gnomes also known as svirfneblin, or another source, you can see in complete darkness. You gain darkvision.", "Umbral Gnome", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("4ce3660b-c78a-4eb5-b487-e234132f4f34"), "Your family line is known for keeping a level head and staving off fear when the chips were down, making them wise leaders and sometimes even heroes. When you roll a success on a saving throw against an emotion effect, you get a critical success instead.", "Gutsy Halfling", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("2edffa58-9514-4e51-82f8-e1b08e427aeb"), "Accustomed to a calm life in the hills, your people find rest and relaxation especially replenishing, particularly when indulging in creature comforts. When you regain Hit Points overnight, add your level to the Hit Points regained. When anyone uses the Medicine skill to Treat your Wounds, you can eat a snack to add your level to the Hit Points you regain from their treatment.", "Hillock Halfling", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("35e10760-e9f1-4570-89f6-7fd2c3ecee42"), "You have adapted particularly well to living in forested environments. As long as you are in a forest or jungle, you gain a +2 circumstance bonus to Stealth checks to Hide and Sneak, Survival checks to Subsist, and your Survival DC to Cover Tracks.", "Treedweller Goblin", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("4a851a94-b9dd-4afe-b74e-4c3ef1407d9f"), "You have a powerful tail, likely because you descend from a community of monkey goblins. You gain a +2 circumstance bonus to Athletics checks to Climb, you gain Combat Climber as a bonus feat, and you reduce the number of free hands required to Climb or Trip by one.", "Tailed Goblin", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("e6c22bc6-bb97-480b-85c3-6d1b2dd3980a"), "You are acclimated to living in frigid lands and have skin ranging from sky blue to navy in color, as well as blue fur. You gain cold resistance equal to half your level (minimum 1). You treat environmental cold effects as if they were one step less extreme (incredible cold becomes extreme, extreme cold becomes severe, and so on).", "Snow Goblin", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("14a46d8b-148c-4671-90ec-622b746f75e0"), "Your family's teeth are formidable weapons. You gain a jaws unarmed attack that deals 1d6 piercing damage. Your jaws are in the brawling group and have the finesse and unarmed traits.", "Razortooth Goblin", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("d1269abf-7396-4b72-8130-9a74f3253bfb"), "You can subsist on food that most folks would consider spoiled. You can keep yourself fed with poor meals in a settlement as long as garbage is readily available, without using the Subsist downtime activity. You can eat and drink things when you are sickened. You gain a + 2 circumstance bonus to saving throws against afflictions, against gaining the sickened condition, and to remove the sickened condition.When you roll a success on a Fortitude save affected by this bonus, you get a critical success instead.All these benefits apply only when the affliction or condition resulted from something you ingested.", "Irongut Goblin", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("b5615a58-0fc5-4b2d-87b7-b3f2e74e3a10"), "Your ancestors have always had a connection to fire and a thicker skin, which allows you to resist burning. You gain fire resistance equal to half your level (minimum 1). You can also recover from being on fire more easily. Your flat check to remove persistent fire damage is DC 10 instead of DC 15, which is reduced to DC 5 if another creature uses a particularly appropriate action to help.", "Charhide Goblin", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("f574f17b-2c71-4a9e-adba-a91a5f5f6e22"), "Some other source of magic has a greater hold on you than the primal magic of your fey lineage does. This connection might come from an occult plane or an ancient occult song; a deity, celestial, or fiend; magical effluent left behind by a mage war; or ancient rune magic. Choose arcane, divine, or occult.You gain one cantrip from that magical tradition's spell list. You can cast this spell as an innate spell at will, as a spell of your chosen tradition. A cantrip is heightened to a spell level equal to half your level rounded up. Whenever you gain a primal innate spell from a gnome ancestry feat, change its tradition from primal to your chosen tradition.", "Wellspring Gnome", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") },
                    { new Guid("634935e2-14bd-4de5-b1d9-fcff13093d94"), "You’re able to bounce back from injuries easily due to an exceptionally thick skull, cartilaginous bones, or some other mixed blessing. You gain 10 Hit Points from your ancestry instead of 6. When you fall, reduce the falling damage you take as though you had fallen half the distance.", "Unbreakable Goblin", null, new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807") }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "RacesId", "TypeId" },
                values: new object[,]
                {
                    { new Guid("0f1df7b2-68f8-41db-8800-2a72f8b41cad"), "Varisian", null, new Guid("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0") },
                    { new Guid("2e093e71-03bf-46bb-9c3e-29066e49c891"), "Sign Language", null, new Guid("705b76de-5a42-4e7b-aaf2-16feb7b232d0") },
                    { new Guid("70fb4b94-4ba8-4f1f-82ed-e160ce7eb99d"), "Vuldrani", null, new Guid("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0") },
                    { new Guid("a025c8bf-03d7-44cf-8571-444a80799ab6"), "Tien", null, new Guid("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0") },
                    { new Guid("efaeb70a-9ba1-4026-a1cb-51272efba480"), "Infernal", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("9074da30-a817-4a7d-a260-7fc10b02513a"), "Shoanti", null, new Guid("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0") },
                    { new Guid("6a5332d4-f0b7-4e9b-8016-ccb5d03e9d0f"), "Ysoki", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("b968b2e8-1dc2-4c33-b108-5c58c36d85ed"), "Amurrun", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("096204ff-a686-4f09-95f9-9353401cb37a"), "Terran", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("1b30c0fb-885d-4b6f-a03c-2dd4c1639aae"), "Shadowtongue", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("3b5d9eb0-04e7-48a0-a611-32475680a811"), "Necril", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("f4c44558-f01d-4b2e-a98d-5ed75f5a5c87"), "Ignan", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("6de09882-17f3-43f2-9c8d-81d78f75d988"), "Gnoll", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("a2a126c5-0922-4e2c-929d-98cc10603aab"), "Celestial", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("e3f3ba6c-0589-4c16-b625-093a1fa1edce"), "Auran", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("fe8f7dca-685b-4595-8d0c-ee72e0239d58"), "Aquan", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("6085b848-9283-494b-bf9d-999917f5d9d9"), "Aklo", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("7fba9655-f430-4ef1-acd7-996f398f4e60"), "Abyssal", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("8700ff4d-89af-4d17-add5-381f3d595682"), "Undercommon", null, new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac") },
                    { new Guid("ba4a2924-27ab-49a1-b700-310b1cfb0c22"), "Orcish", null, new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac") },
                    { new Guid("956c9a02-b3db-41d2-83f3-3c27fa43e510"), "Jotun", null, new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac") },
                    { new Guid("f05615ab-eba0-476d-8afd-1f628b90240b"), "Halfling", null, new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac") },
                    { new Guid("bbbe92c4-628e-4b49-a1fb-9845a0071980"), "Goblin", null, new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac") },
                    { new Guid("6582bcfc-19d6-4b4d-9c35-a25047433bb7"), "Gnomish", null, new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac") },
                    { new Guid("4fc0e030-aa67-4913-b738-16b82ac46354"), "Elven", null, new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac") },
                    { new Guid("59a55746-938a-459e-8ff3-ce201de0a452"), "Dwarven", null, new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac") },
                    { new Guid("4bf191b9-77f7-47d0-89d7-e22555aaee7f"), "Draconic", null, new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac") },
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), "Common", null, new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac") },
                    { new Guid("47f3cc11-d37c-4d58-908e-7d7f71d190ca"), "Skald", null, new Guid("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0") },
                    { new Guid("7c3e1ffc-a478-4009-986c-bf45770f5f10"), "Tengu", null, new Guid("ddd66834-fd35-4361-b798-c389e81b12a0") },
                    { new Guid("c86cab6c-8b52-43bd-b98c-9eaf7f63d5df"), "Druidic", null, new Guid("9e4b5cea-7c60-4396-aa80-307379d155ab") },
                    { new Guid("be3b5aa6-e2eb-49b8-8273-a3eb516dcfc7"), "Sylvan", null, new Guid("02fff45a-095f-4a5e-8c70-b5359692c1ac") },
                    { new Guid("5bc03f6e-2b88-40f0-abde-fb539995f28b"), "Kelish", null, new Guid("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0") },
                    { new Guid("981794a7-f756-4894-b903-2ed948b580be"), "Mwangi", null, new Guid("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0") },
                    { new Guid("00ff0a21-2e5d-4b6b-b6ba-ddeaf331c464"), "Osiriani", null, new Guid("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0") },
                    { new Guid("96b1db15-ad82-4a43-a5ad-a147d3611b4e"), "Hallit", null, new Guid("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0") }
                });

            migrationBuilder.InsertData(
                table: "Lores",
                columns: new[] { "Id", "Discriminator", "Name", "StatModifierId" },
                values: new object[,]
                {
                    { new Guid("9fd1286f-2ce0-4fe7-9152-565db6dc7b4a"), "Lore", "Theater", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("e8ca8373-046b-4a64-8d17-ddcdcf56f869"), "Lore", "Underworld", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("2b728d17-8d3c-42fc-aa53-08e5d73debd9"), "Lore", "Warfare", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("3cb1887c-28e5-4927-b40e-2b9b579126b2"), "Lore", "Fishing", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("ecd24e93-d6b6-46a4-8866-b4292df19c11"), "Lore", "Farming", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("f86f9546-665e-4a31-8f98-8162ea95add1"), "Lore", "Engineering", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("3355e2fe-2868-4d57-8e78-0a6f6e7f9cd6"), "Lore", "Circus", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("c523fba8-bdfc-4eae-bd83-3735c421fc6c"), "Lore", "Art", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("972635f0-889d-411b-8f29-abf1ade9da18"), "Lore", "Architecture", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("76dc8338-d86c-40a7-8a9c-15d64006bfb4"), "Lore", "Accounting", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("a20da31f-7ed2-41a3-99e2-2105144ae00c"), "Lore", "Academia", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("c5ef590a-1eb9-43a4-a1e6-1521d9d47614"), "Lore", "Tanning", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("1e08e096-27f7-4d62-a52a-642b87871d10"), "Lore", "Fortune Telling", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("15920edf-9202-476b-8ddb-5c0950c08adc"), "Lore", "Stabling", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("f1b92dd2-deef-4baa-b744-506ddb77f169"), "Lore", "Scouting", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("a01a140e-95a0-483e-b472-a193751f8149"), "Lore", "Genealogy", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("0d91d63d-082b-472e-bc07-a68d17c20f80"), "Lore", "Gladiatorial", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("67ef16b1-79f0-4078-870f-ea8f8c6f95c7"), "Lore", "Guild", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("2c700b95-816a-49a5-ac14-4d00798f1c66"), "Lore", "Heraldry", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("895ec4d4-9130-439b-84ca-1179973008fc"), "Lore", "Herbalism", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("4123ef14-b7b4-4260-ae75-67e62a136d92"), "Lore", "Hunting", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("f68a7c82-36e8-4c6f-801a-30f996f67465"), "Lore", "Scribing", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("9986bcde-469b-42d1-abda-135f68daa6cf"), "Lore", "Labor", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("f3e8b6c2-238f-4354-aa4f-f638398e851e"), "Lore", "Library", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("a017fa74-7dd3-4e49-b0ab-e56b53acb642"), "Lore", "Mercantile", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("194009eb-8f7e-4f2d-b273-116080106e16"), "Lore", "Midwifery", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("72e8509a-c5b4-46be-9988-607f9786626b"), "Lore", "Milling", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("0a92a9ed-a7b5-4b76-a011-d0c061786294"), "Lore", "Mining", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("efa5a63f-a6df-4e20-8834-eef62de65127"), "Lore", "Sailing", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("10fcb507-86b4-41f1-af02-72944da5eec4"), "Lore", "Legal", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("59c448b6-53f8-46d4-a547-d8a7ff86d334"), "Lore", "Games", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") }
                });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "AlignmentId", "CategoryId", "Description", "Name", "TraitsId" },
                values: new object[,]
                {
                    { new Guid("8e6d1e80-b710-4468-89d5-a97d4178fd14"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("906654b0-cf06-4b89-981b-07b50afa956d"), "Among the most obscure planes of existence, the Dimension of Time is virtually impossible to access by conventional methods of planar travel. Instead, travelers much perform complex and difficult rituals described within the pages of such monstrously rare tomes as the Necronomicon and the Book of Serpents, Ash, and Acorns: Shadows of What Was and Will Be. Compounding the plane’s obscurity, each traveler’s experience seems to be unique, and most who attempt the journey never return. Every manner of magic that interacts with the plane invariably draws the attention of creatures such as the hounds of Tindalos. The proper flow and continuity of time seems to self-correct for any attempted meddling, often with violence. Those few who have gained entry and returned describe the plane as a swirling storm of blurred images, the composite of millions of interwoven timelines around their own, with a single doorway allowing access to one’s own past.Travelers appear as transparent images of themselves, but the plane seems averse to any attempt to alter the past, no matter the means or the intention.Such attempts often end in the offending individual erased from existence or trapped within closed time loops to limit the damage they inflict upon the overall flow of time. Supposedly, like an eye in a storm, at the dimension’s heart is the legendary realm of Stethelos and its terrible occupant Tawil at’Umr.Tales of this realm speak only of a great city, a vast green meadow, and the rushing sound of an ocean emptying over an immense and terrible waterfall.", "Dimension of Time", null },
                    { new Guid("af0a9351-d4e7-492d-93c4-2b7ef86cfa85"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("3bbe8661-ea39-4b26-8723-eb04b151062f"), "The Material Plane is the prosaic universe and the home of mortal life. Innumerable galaxies play host to countless stars and their planets, each housing unique settings for any campaign, with Golarion as the classic example. Other worlds of note like Castrovel, Akiton, and Eox exist within Golarion’s own solar system, and then beyond this, orbiting other distant stars or in other galaxies still, worlds such as Androffa, Carcosa, and even Earth swirl within the Material Plane’s vast and silent void. Yet for all the profound wonder and diversity of life that the Material Plane houses, in the dark places between the stars, known as the Dark Tapestry, lurk the inimical gods known as the Outer Gods and Great Old Ones, the sinister collective known as the Dominion of the Black. The Material Plane serves as the destination for pre - incarnate souls, each mortal life born, living, and dying before sending its spirit toward the planes of the Outer Sphere for judgment.The Material Plane is likewise the focus of the gods, each of whom is invested in fostering their own particular portfolio among mortal worshippers and the material world at large.", "Material Plane", null },
                    { new Guid("e48dae17-e2ad-48fa-8cfb-756dea200ca5"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("a1485da2-c025-45cd-bc59-f08fe12b7d5b"), "The First World was a first draft of the Material Plane, crafted by divinities to test their metaphorical crafting materials and palettes of colors before setting it aside to create a second, final version of their work. A realm of extremes—savage, primal, and beautiful—with colors and sensations brighter and more intense than the mundane world created after it, the First World is populated by fey and the divine entities known as the Eldest. Mirroring mercurial fey whimsy, the First World’s laws of nature constantly and unpredictably change. Distance and time are wildly inconsistent, such that mortal travelers might spend an hour or a day within the First World, only to find a century or only a few seconds passed once they return to their own plane. The First World stands outside the cycle of souls, something the fey call the Great Abandonment, save for rare worshippers of the Eldest whose souls incarnate here as fey.However, the plane’s proximity to the Positive Energy Plane provides an environment bursting with all manner of strange life and a general absence of true death for its native fey unless they leave—as did gnomes.Natural gates in wild places of the mortal realm connect to the First World, which fey often use to visit the Material Plane or ensnare mortals for their own capricious desires.", "First World", null },
                    { new Guid("4d67dae9-fa19-4ce6-be98-e52a7ca93f09"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("a1485da2-c025-45cd-bc59-f08fe12b7d5b"), "The Ethereal Plane is a vast, misty realm overlapping each of the Inner Planes. Formed by the interacting tidal forces of creation and destruction from the Positive and Negative Energy Planes, this plane swirls with currents and eddies of fog, lit only by erratic pulses of soft green luminescence and dimly visible light of those planes it overlays, visible but ever intangible. While mortals most often use the Ethereal as a means of transit, moving by force of will in the absence of gravity to bypass barriers on their own plane, the Ethereal hosts dangers and wonders, things lost or abandoned in the mists, and things spun from local eddies in the ethereal protomatter. Predatory monsters, ether spiders, night hags and their goddess Alazhra, and all manner of incorporeal undead roam the Space Between Spaces. While travelers can easily become lost in the mists with little to guide them the plane does host some permanent structures drawing adventurers or dissuading them.One such location, the House of the Itinerant Soul, houses wayward or lost souls, offering visitors shelter and a way to avoid turning into undead while avoiding the pull of the River of Souls.The grand cathedral also serves as a focus for mortal planar travelers, given its safety and the presence of friendly spirits willing to serve as guides in the surrounding mists.", "Ethereal Plane", null },
                    { new Guid("2e98856d-d10d-46c9-8d7a-fe12e6581733"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("a1485da2-c025-45cd-bc59-f08fe12b7d5b"), "The Silver Sea surrounds the planes of the Inner Sphere, separating them from those of the Outer Sphere. The Astral Plane provides the backdrop against which the River of Souls flows from the Material Plane, ushering departed spirits toward final judgment. Far from an empty void, the Astral’s silver substance churns with currents and storms from the metaphysical heat of the Plane of Fire, and where it touches the chaos of the Maelstrom, the resulting eddies interact with the memories of the dead to produce fleeting simulacra and even demiplanes. The River of Souls draws the attention of soul - hunting daemons and opportunistic night hags like sharks drawn to the scent of blood.Led by psychopomps, a cross section of nearly every type of celestial and monitor in existence, along with some fiends, defends the proper flow of souls against such predators.Running opposite the River of Souls is the flow of raw, unaligned quintessence spun off from the so-called Antipode, channeled by aeons back toward the Positive Energy Plane. Travelers within the Astral find the plane untouched by the passage of time a property exploited by many mortals fearing old age. Time however, is not easily escaped, and upon exiting the Astral Plane, a creature finds this debt catching up to them, potentially aging to dust in moments.", "Astral Plane", null },
                    { new Guid("b1ed0a25-c679-4365-a45e-4d7fc057c1d9"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("c64c6e93-aa40-4010-8fbc-592c1f0e017a"), "The pastoral paradise of Nirvana is the realm of purest good, a plane that promises sanctuary to the weary and enlightenment and transcendence to those who seek it out. Filled with beautiful wilderness of all types in perfect harmony with its occupants, Nirvana’s wilds are home to angels and others. The plane’s petitioners, known as the cleansed, most often take the forms of glorified, sapient wild animals, though many eventually leave their carefree existence to aid others, ascending to assist the benevolent works of angels. Devoted to guiding and assisting mortals, angels are often charged with delivering important messages that reflect the will of benevolent deities Various divinities make their home amid Nirvana’s wilds, including a host of empyreal lords and, most prominently, Sarenrae and Shelyn.While the great cities of High Ninshabur and Llourith welcome visitors most mortals visiting Nirvana witness the plane’s beauty and supernatural feeling of peace but rarely encounter many of its residents, as the plane itself protectively hides much of its contents from any but the most selfless and pure of heart.The plane’s hinterlands hint at hidden mysteries, including legends that the plane shelters the vanished heroes of innumerable mortal worlds, peacefully sleeping until their peoples’ times of greatest need.", "Nirvana", null },
                    { new Guid("235e010f-bfb6-40f0-a65f-628f2ea721bf"), new Guid("2ad80bbd-a735-4431-9e3a-f784e053b756"), new Guid("c64c6e93-aa40-4010-8fbc-592c1f0e017a"), "The Maelstrom, infinite and ancient, spawned the other Outer Planes in cosmological prehistory and surrounds them like a vast metaphorical—and at times literal—ocean of raw, chaotic quintessence. Where the Maelstrom borders these other planes, its structure takes on their characteristics, albeit in an unpredictable, chaotic fashion. Beyond these so-called Borderlands, however, the Maelstrom reverts to its true nature, the Cerulean Void: a trackless, liquid infinity devoid of stability and permanence where serpentine proteans create and destroy with profound frivolity. The proteans are paradoxically organized into discrete choruses, each with its own philosophy and goals in service to the Maelstrom. Swirling with oddities and wild magic, bereft of laws and structure, the Maelstrom also serves as a conduit between the other Outer Planes utilized by armies of extraplanar beings, hordes of demons spilling forth from the Abyss, and the innumerable protean choruses seeking to return the rest of the planes to the true freedom of the chaos from which they emerged. Sufficiently powerful magic can stabilize the chaos for a time, allowing for the creation of demiplanes and stable islands. The massive planar trade city of Galisemni is most prominent among these, drifting through the chaos.", "Maelstrom", null },
                    { new Guid("cdd0a36f-c298-41e6-9252-d3cbc81f5bd6"), new Guid("54f32060-3da3-4edf-b6dc-3839b8b7415d"), new Guid("c64c6e93-aa40-4010-8fbc-592c1f0e017a"), "Hell is the realm of devils, the multiversal seat of tyranny and malignant law, and the divine domain of Asmodeus, the Prince of Darkness. Here every act is authorized, calculated, recorded, and set like perfectly ordered clockwork within a vast machine driven on methodical suffering and greased with pain and purification. The nine inverted layers of Hell violently oppose the surrounding fabric of the Maelstrom, each layer shaped to reflect the nature of its ruling archdevil. Avernus's volcanic wastes, ruled by Barbatos, are the marshaling place of Hell's armies, and where newly damned souls are shackled and shuffled off to their assigned torment. Dispater's layer of Dis is a great iron city: brutal, beautiful, and terrible. The layer of Erebus comprises both the sewers of Dis and the vaults and treasuries of Hell, ruled by Mammon, a great genius loci embodied by the very wealth locked within Hell's coffers. Ruled by Belial, the layer of Phlegethon hosts Hell's forges, while Geryon's watery realm of Stygia houses Hell's libraries. Moloch's smoldering, ash-draped forest realm of Malebolge is the training site of the infernal armies, and Baalzebul's frozen layer of Cocytus torments the imprisoned, starving damned. Mephistopheles rules the layer of Caina, a realm of cages and torture suspended above a pit of hungry darkness, while at the very bottom of Hell's infinite pit, Asmodeus rules unquestioned from his throne in Nessus.", "Hell", null },
                    { new Guid("84410831-a91b-4556-96a0-7eeba0653279"), new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), new Guid("c64c6e93-aa40-4010-8fbc-592c1f0e017a"), "The great mountain of Heaven is the realm of structured benevolence made manifest. Organized into seven tiers, the mountain’s solid appearance is actually malleable, making way for a vast assemblage of varied environments to accommodate both its own celestials and the souls who migrate there. Devoted to defending the innocent and crusading against the wicked, Heaven’s archons marshal into vast armies, commanded by their own empyreal lords. Angels collaborate with the archon legions but typically act in more direct service to Heaven’s resident deities, with Iomedae, Erastil, and Torag the most prominent among them. Petitioners known as the elect manifest at the mountain’s base, and their subsequent climb up the seemingly endless, unreachable heights is both a literal and figurative journey.Progress is about personal growth and spiritual purification as the petitioners grow more and more attuned to the plane.Likewise, progress from one layer to the next is often impossible without permission from the archons or spiritual alignment with Heaven itself.Most visitors arrive at the city of Heaven’s Shore, a place open to both traders and to pilgrims of good intent.Access beyond its heavily guarded walls is difficult, to say nothing of scaling the mountain.At its pinnacle is the Garden, Heaven’s ultimate layer.Unattended and empty, the Garden is a beautiful, transcendent mystery even to its resident deities, and the source of the plane’s call of self - perfection to its petitioners.", "Heaven", null },
                    { new Guid("cc26757e-a07a-4213-84a3-36b300a2306a"), new Guid("add12009-9c8a-4287-b02b-7e5b9459bf44"), new Guid("c64c6e93-aa40-4010-8fbc-592c1f0e017a"), "Verdant, wild, and unrestrained by law, where passion and creation are fostered and rewarded, the plane of Elysium is a place of wild, idealized natural beauty. The so-called Promised Land and its inhabitants represent a wide variety of freely given benevolence, often willing to directly aid visitors but more often serving as inspirations and muses to foster positive change and self-realized success. Elysium’s petitioners, known as the chosen, appear as idealized versions of their mortal selves, each pursuing their own self-determined actions and finding their own unique paths to join the ranks of the plane’s celestials. Azatas—the plane’s primary denizens—organize into fleeting, competitive courts, each rewarding heroism and creativity above all else.Elysium hosts a number of resident deities, including Calistria and the elven pantheon, Cayden Cailean, Desna, Gorum, and various empyreal lords.Visitors from across the planes are drawn to Elysium’s Wandering City of Emerald Song, a mobile, impermanent, and ever-changing city of lillend azatas organized by their princess, Anduarine the Muse, filled with art, craft, revelry, song, and trade.", "Elysium", null },
                    { new Guid("7c34baea-48a6-4a49-8b15-8781a5c1ab47"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("c64c6e93-aa40-4010-8fbc-592c1f0e017a"), "The Boneyard spans an impossibly tall and ever-growing spire of gleaming quintessence that rises up into the silver void of the Astral Plane. As the destination of the River of Souls, the Boneyard is where the souls of the mortal dead arrive for judgment and for Pharasma and her psychopomp servitors to direct them to their respective afterlives. Pharasma’s domain is separated into eight courts, each corresponding to one of the other planes of the Outer Sphere and collecting the souls due to that plane. Not every soul goes unchallenged, and proxies of gods and planes argue and debate over souls, with final arbitration conducted by Pharasma herself. While Pharasma rules absolutely within the Boneyard, she is not the only divinity there.The demigod psychopomp ushers dwell within the plane in service to her, and the deity Achaekek dwells below at the spire’s root.Looming high above as a skull - faced moon waits Groetus, the god of the end times, his orbit slowly decaying in minuscule iterations supposedly counting down to the last days of the cosmos. Pharasma’s courts and the surrounding Graveyard of Souls are not the only features atop the spire.Beyond the graveyard, the Spirelands manifest environments much like those of the varied Material Plane worlds, filled with the souls of neutral petitioners who have nowhere else to go as they are unclaimed by any gods and unaligned with any particular ethos.", "Boneyard", null },
                    { new Guid("e57522d4-5e50-44c7-bbcb-1c4d0d81baeb"), new Guid("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), new Guid("c64c6e93-aa40-4010-8fbc-592c1f0e017a"), "Axis is a realm of pure, absolute law, unhindered by the moral concerns of good or evil. The plane takes the form of a vast, gleaming, perfectly structured city. Built at the base of Pharasma’s Spire, the Perfect City is a bulwark against the chaos of the Maelstrom and Abyss, with vast mechanical armies of inevitables marching forth to explore, define, and pacify an imperfect, unruly universe. Axis is also home to axiomites: beings composed of living mathematics and equations who helped create the first inevitables. Axiomites continue to work on the maintenance of the inevitables, but increasingly turn their attentions to the planar city of Axis itself; as with any city, Axis requires non-stop maintenance and improvement in order to resist the march of time. Axis’s natives are far from the only inhabitants of their cosmopolitan realm.Devils and archons often visit along with petitioners, mortal travelers, and smaller numbers of most every other kind of extraplanar being.Abadar and other lawful deities make their homes here.The empty, former domain of Aroden languishes here, while below the streets lies Norgorber’s domain, a labyrinthine undercity.", "Axis", null },
                    { new Guid("10be56f4-5519-4cb6-8038-83dda6b0d00a"), new Guid("25f9299a-9a7c-40bc-b8bd-58588d19381b"), new Guid("c64c6e93-aa40-4010-8fbc-592c1f0e017a"), "Like a corrosive rot in the roots of the Outer Sphere, or an antithetical, rival reality run aground into the Maelstrom at the dawn of time, the Abyss is a place of horror and destruction fed by mortal sin. Each of its innumerable regions is a unique iteration of chaos and evil, each with its own terrible and twisted environment, with one driving maxim: the strong survive, while the weak suffer and are destroyed. Ruled by demons, and before them by the alien, nightmarish qlippoth, the Abyss and its native beings seek only to ravage and destroy. While demons routinely rampage out into other planes when the Abyss manifests a great planar rift, the denizens of the Abyss are fractured and self-destructive. Demon lords such as Dagon, Pazuzu, and Zura, and even gods including the ascended demon lord Lamashtu, the Mother of Monsters, fight for dominion over the Abyss as much or more than they threaten the other planes. Though dangerous, not every realm of the Abyss is immediately hostile to the prepared traveler. Shamira’s city of Alushinyrra in the Midnight Isles and Abraxas’s library-city of Diovengia in the realm of Pleroma are each welcoming in their own dark ways. Even those who survive a journey through the Abyss, however, inevitably must resist being deeply corrupted by the experience.", "Abyss", null },
                    { new Guid("429fa72a-4a20-40ce-97b1-b4008807472b"), new Guid("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), new Guid("c64c6e93-aa40-4010-8fbc-592c1f0e017a"), "A perpetual eclipse looms above the bleak wastelands of Abaddon, shedding an eerie half-light over a landscape of toxic, disease-ridden swamps, volcanic wastes, fog-shrouded forests, and the glittering, memory-devouring ribbon of the River Styx. An unnatural silence blankets the plane, cut only by the wails of petitioners falling from the sky like screaming, falling stars, or those already condemned upon the ground, desperate to find safety that doesn't exist. Daemons, the physical embodiments of death and oblivion, roam unchecked, owing allegiance only to the Four Horsemen of the Apocalypse: Death, Famine, Pestilence, and War. In the courts of the Horsemen and the neutral grounds of trade cities such as Awaiting-Consumption, the soul trade serves daemonic hunger and industrialized oblivion. Night hags and other creatures ply the trade or make their way along the margins of daemonic society, eager to avoid consumption themselves by the plane's nihilistic masters. Urgathoa and Zyphus claim divine domains here, their petitioners granted freedom from predation. Yet something far worse glares down upon these gods and the Horseman alike. Abaddon's perpetual eclipse may be nothing less than the lidded, comatose eye of the Bound Prince, the First Horseman, betrayed and cast down by the Four, forgotten by the cosmos at large, but far too powerful for them to destroy—waiting, watching, and hungering.", "Abaddon", null },
                    { new Guid("b31acddd-b42e-4014-95cf-0e9ca41c73d3"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("3bbe8661-ea39-4b26-8723-eb04b151062f"), "Known as Creation’s Forge, the Positive Energy Plane is at once the source of life-sustaining positive energy, the origin of all pre-incarnate mortal souls, and paradoxically the most innately hostile of all of the planes. While positive energy is deadly to undead and beneficial to living beings, such is the intensity of the plane that unmitigated exposure ultimately incinerates any extraplanar beings without sufficient magical protection. The most apt comparison for the plane’s interior is that of the heart of a burning star, and indeed the stars of the Material Plane each house natural portals to the Positive Energy Plane within their glowing, potent cores to foster the movement of pre-incarnate souls in their first steps in the great cycle of life and death.Brilliant and blinding, the plane’s interior is sparsely populated, and the resident phoenix - kin jyoti are intensely xenophobic.Dwelling in glimmering, radiant crystalline cities such as Arudrellisiir, they view themselves as gardeners and guardians of souls spawned from their realm’s burning quintessence.Intensely distrustful of gods and their servitors, jyoti can nonetheless be bargained with, and they have frequently taken into their custodianship any number of artifacts and imprisoned beings considered too dangerous to house on any other plane.", "Positive Energy Plane", null },
                    { new Guid("08350a3e-6f60-4b40-b5f0-8ec05e70204e"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("906654b0-cf06-4b89-981b-07b50afa956d"), "Created and sustained by the collective dreams of sleeping mortals, the Dreamlands (also called the Dimension of Dreams) overlays the Ethereal Plane. When a creature dreams, regardless of the location of their physical body, they interact directly with the Dreamlands. Sleeping creatures cast themselves into the plane in idealized avatars known as lucid bodies, and their dreamscapes are immune to outside entry by standard magic such as plane shift, requiring obscure, more specialized spells to access. The dreamers of each mortal world generate a cluster of dreamscapes, like drifting bubbles atop a deeper ocean of permanent dreams formed from the collective mass of slumbering desires, dreams of especially powerful dreamers, and the dreams of ancient, obscure entities—including the gods of the Elder Mythos. While most dreamscapes are safe, travelers in the deep, permanent Dreamlands face living, animate dreams and the predation of night hags from the Ethereal Plane, as well as stranger beings spawned within the core itself. Some scholars postulate a distinct region within the dimension for nightmares, much as the more stable inner portions of the dimension exist separately from the transient, ever - forming and evaporating mortal dreamscapes at its edges.Others conflate this nightmare region with the demiplane of Leng, while still others dismiss this notion but speculate that Leng is somehow accessible to dreamers who intentionally seek it out.", "Dreamlands", null },
                    { new Guid("3e4b22a2-a4bd-42cc-b27f-a381758a4c11"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("a1485da2-c025-45cd-bc59-f08fe12b7d5b"), "A murky, distorted, and imperfect mirror of the Material Plane, the Shadow Plane overlaps the Material Plane and serves as a buffer or conduit between it and the Negative Energy Plane. The Shadow Plane exists in a state of perpetually dim half-light, the landscape containing similar features to the overlapping Material Plane, but in warped or twisted fashions. Cities on the Material Plane might exist on the Shadow Plane, sometimes in ruins and sometimes as terrible, frightening replicas. The darkness also holds points of beauty and relative safety, such as the great city of Shadow Absalom. The bleak doppelganger of Golarion’s own Absalom hosts cross-planar trade facilitated by a permanent, one-way portal out of the gloom. The Shadow Plane is populated by dark, altered versions of creatures from the Material Plane, many of them immigrants that have adapted to the shadow after being trapped in the realm for generations.The shadow natives known as kayals—also known as fetchlings—were originally humans before thousands of years of exposure to the Shadow Plane and breeding with strange beings forever altered them.Velstracs, who long ago fled from Hell, have since adopted the Shadow Plane as their home, spreading their horrific message of perfection through mutilation in service to their victim and patron, the god Zon - Kuthon.In contrast, d’ziriaks originated within the Shadow Plane itself, as have the fearsome umbral dragons ruling self - crafted fiefdoms within the shadows.Greatest of these is Argrinyxia, who rules over Shadow Absalom.", "Shadow Plane", null },
                    { new Guid("1a0e31c5-8271-458c-a941-d1a9a5a60d51"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("3bbe8661-ea39-4b26-8723-eb04b151062f"), "The vast void of the Negative Energy Plane is a merciless, lightless expanse of manifest destruction and nothingness. Sapping and consuming the life force of any living creature exposed to its energies, it corrodes and disintegrates material objects to rubble, then dust, and then nothing at all. Yet the Void contains its own form of anti-life. At their densest concentration, the plane’s energies aggregate into bizarre, black crystalline snowflake structures, and these irregularities spontaneously generate the plane’s resident sceaduinars. Dwelling in beautiful, deadly cities drifting in the vacuous darkness, these so-called void raptors are incapable of true creation and blame this flaw on some ancient betrayal by their rivals on the Positive Energy Plane. Sceaduinars react violently not only toward creatures sustained by positive energy, but also toward undead, whom they view as unnatural parasites unworthy of their plane’s energies. The black depths also swarm with undead, creatures doomed to a mockery of life by the interaction of their souls with the plane’s entropic energy.Yet for all the horrors posed by the plane’s environment, inhabitants, and its undead victims, its depths nevertheless hide rare refuges for planar travelers. Malikar’s Keep offers shelter, for a price, to those willing to bargain with its titular lich master, while elsewhere the depths hide entire lost worlds such as Fallen Duromak, and deadly mysteries like the planet-sized, undead - entrapping glass sphere, Eternity’s Doorstep.", "Negative Energy Plane", null },
                    { new Guid("b191ffc0-7a9a-4285-b758-7542bef75a85"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("3bbe8661-ea39-4b26-8723-eb04b151062f"), "The Plane of Air, innermost of the Elemental Planes, is a vast realm of wind, storms, and skies. Illuminated by great artificial globes of flame and distant starlight from the material universe, the plane is populated by air elementals, dragons, mephits, and a great empire of djinn. Though mostly clouds and empty skies, the plane is not entirely bereft of solid ground, including rock and ice created by the residents or dragged into their realm from the distant Plane of Earth or neighboring Plane of Water, and bizarre, drifting spheres of brass and iron. While the former are aggressively fought over, most housing the cities of the vast djinn empire, the latter are almost entirely abandoned and shunned by the plane’s inhabitants, who believe them cursed, entrapping forgotten, ancient enemies who once ravaged the plane. The djinn rule from their shining capital city of Armun Kelisk, built atop a series of seven floating islands.Their vast trade network crisscrosses the skies and ventures to other planes, kept aloft by natural and magical flight, including great airships that allow visitors to quickly and safely traverse the skies.The djinn are welcoming and gracious hosts to extraplanar travelers and adventurers, a perspective not shared by Hshurha the Duchess of All Winds, the evil elemental lord of air.", "Plane of Air", null },
                    { new Guid("71064085-85ef-4986-b34c-c270b398749a"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("3bbe8661-ea39-4b26-8723-eb04b151062f"), "A great and rocky shell situated between the Plane of Fire and Plane of Water, the Eternal Delve hosts a unique and varied ecology of creatures at home in its rocky depths. Far from an endless, solid expanse, the Plane of Earth is riddled with great caverns and cave systems, excavated artificial vaults, vast crystalline geodes, and underground oceans and springs of magma where it borders its neighboring planes. Housing untold riches in gemstones and veins of precious metals, the Plane of Earth is an attractive setting for planar travelers seeking wealth and willing to risk danger and the wrath of elementals, shaitans, and other inhabitants who resent the plunder of their home. While elementals have little organized society, the shaitan genies’ Peerless Empire rules much of the plane from its capital, the Opaline Vault—a rainbow - lit city within a 30 - mile - wide geode cavern.The shaitans have long been at war with the efreet in the neighboring Plane of Fire, and while the earth genies are less prone to slavery than their rivals, the shaitans brook little dissent, and their rule can be harsh.They are downright welcoming, however, compared to Ayrzul the Fossilized King, the evil elemental lord of earth who rules a great expanse of rock from his radiation-poisoned domain, the Blistering Labyrinth.", "Plane of Earth", null },
                    { new Guid("d1670c72-3c58-4e8a-8c36-6dd1d944383d"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("3bbe8661-ea39-4b26-8723-eb04b151062f"), "Like a great, gleaming ball of flame situated at the heart of the Astral Plane, the Plane of Fire is the outermost plane of the Inner Sphere. A perpetual ocean of fire with skies of smoke, storms of raining cinders, and lakes and rivers of magma flowing along its border with the Elemental Plane of Earth, the plane is incredibly hostile to those unprepared for its natural hazards. Yet it houses one of the most well-known and traversed cities in all the planes: the City of Brass, capital of the Dominion of Flame. Floating above a sea of fire upon a great hemisphere of magical brass, the City of Brass is a monument both to efreet cosmopolitan grandeur and tyranny, the latter embodied by the grand sultana of the efreet. Outside of the mercantile districts and the palaces and temples of the fire genies, the city houses a vast enslaved underclass of salamanders and others, including creatures from other planes. The efreeti domain is not absolute, and elsewhere in the plane are nations of fire mephits and the remains of an ancient azer empire.While they don’t form any cohesive, organized nations, the plane’s fire elementals are ruled over by the plane’s most powerful entity, Ymeri the Queen of the Inferno, the evil elemental lord of fire whose reign has gone unquestioned since the imprisonment of her good - aligned rival Atreia eons ago.", "Plane of Fire", null },
                    { new Guid("f4048c73-6fb0-496c-9e7b-dff087bea6ef"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("3bbe8661-ea39-4b26-8723-eb04b151062f"), "Beyond the skies of the Plane of Air, the clouds grow darker and condense into the vast, spherical, liquid shell of the Plane of Water. Its nearly limitless stretches of saline, fresh, and brackish seas teem with all manner of oceanic life, lit by light from the border with the Plane of Air and descending into black, benthic depths where it borders the Plane of Earth. While the plane is perfectly amenable to water-breathing creatures, air-breathing travelers must provide their own supply of air or magical means to breathe. Bubbles of breathable atmosphere are relatively rare and securely guarded, anchored over places of trade and commerce with outsiders, such as the great city of Vialesk, founded by immigrant undines. The plane’s oceans, dotted by vast forests of kelp, magical currents, and strange phenomena, play host to empires of merfolk, predatory and expansionist sea devils, and the holdings of the plane’s great brine dragons. While marids once claimed nearly absolute dominion over the plane of their origin, their empire long ago fell into deterioration and disunity.Their ravaged cities sank into the depths, and their present - day holdings remain a shadow of their former grandeur.Kelizandri the Brackish Emperor, the evil elemental lord of water and cause of their ruin, rules the dark, saline depths, feasting on all rivals and hoarding the vast, stolen wealth of the fallen marid cities.Unlike other subjective gravity planes, on the Plane of Water, a creature moves based on its swim Speed and must use actions to Swim if it doesn’t have one.", "Plane of Water", null }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "BaseHealth", "BaseSpeed", "Description", "HeritagesId", "LanguagesId", "Name", "RaceTraitsId", "RarityId", "SizeId" },
                values: new object[,]
                {
                    { new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551"), 6, 25, "The convoluted histories other people cling to don’t interest goblins. These small folk live in the moment, and they prefer tall tales over factual records. The wars of a few decades ago might as well be from the ancient past. Misunderstood by other people, goblins are happy how they are. Goblin virtues are about being present, creative, and honest. They strive to lead fulfilled lives, rather than worrying about how their journeys will end. To tell stories, not nitpick the facts. To be small, but dream big.", null, null, "Goblin", null, new Guid("52091c82-7a39-4a66-919e-ac268375b792"), new Guid("0a06e806-0314-455c-8af8-c81ecc1e0dd2") },
                    { new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548"), 6, 25, "Long ago, early gnome ancestors emigrated from the First World, realm of the fey. While it’s unclear why the first gnomes wandered to Golarion, this lineage manifests in modern gnomes as bizarre reasoning, eccentricity, obsessive tendencies, and what some see as naivete. These qualities are further reflected in their physical characteristics, such as spindly limbs, brightly colored hair, and childlike and extremely expressive facial features that further reflect their otherworldly origins.", null, null, "Gnome", null, new Guid("52091c82-7a39-4a66-919e-ac268375b792"), new Guid("0a06e806-0314-455c-8af8-c81ecc1e0dd2") },
                    { new Guid("7fc53559-4776-482c-910c-be3bd84d2de4"), 8, 25, "As unpredictable and varied as any of Golarion’s peoples, humans have exceptional drive and the capacity to endure and expand. Though many civilizations thrived before humanity rose to prominence, humans have built some of the greatest and the most terrible societies throughout the course of history, and today they are the most populous people in the realms around the Inner Sea.", null, null, "Human", null, new Guid("52091c82-7a39-4a66-919e-ac268375b792"), new Guid("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") },
                    { new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576"), 10, 20, "Dwarves have a well-earned reputation as a stoic and stern people, ensconced within citadels and cities carved from solid rock. While some see them as dour and humorless crafters of stone and metal, dwarves and those who have spent time among them understand their unbridled zeal for their work, caring far more about quality than quantity. To a stranger, they can seem untrusting and clannish, but to their friends and family, they are warm and caring, their halls filled with the sounds of laughter and hammers hitting anvils.", null, null, "Dwarf", null, new Guid("52091c82-7a39-4a66-919e-ac268375b792"), new Guid("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") },
                    { new Guid("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce"), 6, 25, "Tengus are a gregarious and resourceful people that have spread far and wide from their ancestral home in Tian Xia, collecting and combining whatever innovations and traditions they happen across with those from their own long history.", null, null, "Tengu", null, new Guid("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), new Guid("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") },
                    { new Guid("903f97e5-6972-4ad2-9377-447b7d6758a3"), 10, 25, "Orcs are forged in the fires of violence and conflict, often from the moment they are born. As they live lives that are frequently cut brutally short, orcs revel in testing their strength against worthy foes, whether by challenging a higher-ranking member of their community for dominance or raiding a neighboring settlement. Many orcs seek glory as soon as they can walk and carry a blade or club, taming wild beasts or hunting deadly monsters.", null, null, "Orc", null, new Guid("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), new Guid("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") },
                    { new Guid("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5"), 8, 25, "Curious and gregarious wanderers, catfolk combine features of felines and humanoids in both appearance and temperament. They enjoy learning new things, collecting new tales and trinkets, and ensuring their loved ones are safe and happy. Catfolk view themselves as chosen guardians of natural places in the world and are often recklessly brave, even in the face of overwhelming opposition.", null, null, "Catfolk", null, new Guid("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), new Guid("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") },
                    { new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff"), 6, 25, "Claiming no place as their own, halflings control few settlements larger than villages. Instead, they frequently live among humans within the walls of larger cities, carving out small communities alongside taller folk. Many halflings lead perfectly fulfilling lives in the shadows of their larger neighbors, while others prefer a nomadic existence, traveling the world and taking advantage of opportunities and adventures as they come.", null, null, "Halfling", null, new Guid("52091c82-7a39-4a66-919e-ac268375b792"), new Guid("0a06e806-0314-455c-8af8-c81ecc1e0dd2") },
                    { new Guid("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf"), 6, 25, "Every kobold knows that their slight frame belies true, mighty draconic power. They are ingenious crafters and devoted allies within their warrens, but those who trespass into their territory find them to be inspired skirmishers, especially when they have the backing of a draconic sorcerer or true dragon overlord. However, these reptilian opportunists prove happy to cooperate with other humanoids when it’s to their benefit, combining caution and cunning to make their fortunes in the wider world.", null, null, "Kobold", null, new Guid("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), new Guid("0a06e806-0314-455c-8af8-c81ecc1e0dd2") },
                    { new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4"), 6, 30, "As an ancient people, elves have seen great change and have the perspective that can come only from watching the arc of history. After leaving the world in ancient times, they returned to a changed land, and they still struggle to reclaim their ancestral homes, most notably from terrible demons that have invaded parts of their lands. To some, the elves are objects of awe—graceful and beautiful, with immense talent and knowledge. Among themselves, however, the elves place far more importance on personal freedom than on living up to these ideals.", null, null, "Elf", null, new Guid("52091c82-7a39-4a66-919e-ac268375b792"), new Guid("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") },
                    { new Guid("a8430e0c-d52e-477c-a058-bc970a2113ea"), 6, 25, "Ysoki—as ratfolk call themselves—are a clever, adaptable, and fastidious ancestry who happily crowd their large families into the smallest of living spaces.", null, null, "Ratfolk", null, new Guid("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), new Guid("0a06e806-0314-455c-8af8-c81ecc1e0dd2") }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "HasArmorCheckPenalty", "HasRecallKnowledgeAction", "Name", "StatModifierId" },
                values: new object[,]
                {
                    { new Guid("252ee579-951c-414e-bb69-7d2dfc324280"), "You are skilled at avoiding detection, allowing you to slip past foes, hide, or conceal an item.", true, false, "Stealth", new Guid("21b2cca1-66cd-48d1-a91b-085521659548") },
                    { new Guid("ca854fef-a519-472f-badd-f677cd8871fc"), "You are trained in a particular set of skills favored by thieves and miscreants.", true, false, "Thievery", new Guid("21b2cca1-66cd-48d1-a91b-085521659548") },
                    { new Guid("3707c645-9e77-4eb7-bf63-f4d65f471f25"), "You know about the natural world, and you command and train animals and magical beasts. Even if you’re untrained in Nature, you can use it to Recall Knowledge (page 238).", false, true, "Nature", new Guid("e9e25044-7005-48c7-81bc-372c8a9f829a") },
                    { new Guid("bef3fdab-348a-4024-9095-1ab69ded3fed"), "You can use this skill to create and repair items. Even if you’re untrained, you can Recall Knowledge (page 238).", false, true, "Crafting", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("feb60159-48a5-4164-b2e2-54b1f0a52a26"), "You know a great deal about ancient philosophies, esoteric lore, obscure mysticism, and supernatural creatures. Even if you’re untrained in Occultism, you can use it to Recall Knowledge (page 238).", false, true, "Occultism", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("641be10d-b069-45e9-b890-7f1254cd042c"), "You understand the people and systems that make civilization run, and you know the historical events that make societies what they are today. Further, you can use that knowledge to navigate the complex physical, societal, and economic workings of settlements. Even if you’re untrained in Society, you can use it for the following general skill actions (page 234).", false, true, "Society", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("b64e4795-0efe-4cf5-82e3-f4219c041137"), "You can patch up wounds and help people recover from diseases and poisons. Even if you’re untrained in Medicine, you can use it to Recall Knowledge (page 238).", false, true, "Medicine", new Guid("e9e25044-7005-48c7-81bc-372c8a9f829a") },
                    { new Guid("6a672190-7918-4fbd-a2d7-2d69f9d2a794"), "The secrets of deities, dogma, faith, and the realms of divine creatures both sublime and sinister are open to you. You also understand how magic works, though your training imparts a religious slant to that knowledge. Even if you’re untrained in Religion, you can use it to Recall Knowledge (page 238).", false, true, "Religion", new Guid("e9e25044-7005-48c7-81bc-372c8a9f829a") },
                    { new Guid("d8fd543c-7284-451d-8882-583970e9d917"), "You are adept at living in the wilderness, foraging for food and building shelter, and with training you discover the secrets of tracking and hiding your trail. Even if you’re untrained, you can still use Survival to Subsist (page 240).", false, false, "Survival", new Guid("e9e25044-7005-48c7-81bc-372c8a9f829a") },
                    { new Guid("eeb5a099-361f-41ab-aafd-7672f47bf9c3"), "Perception measures your ability to be aware of your environment. Every creature has Perception, which works with and is limited by a creature’s senses (described on page 464). Whenever you need to attempt a check based on your awareness, you’ll attempt a Perception check. Your Perception uses your Wisdom modifier, so you’ll use the following formula when attempting a Perception check.", false, false, "Perception", new Guid("e9e25044-7005-48c7-81bc-372c8a9f829a") },
                    { new Guid("2f33e759-98f4-4a19-a955-e2133197de04"), "You can trick and mislead others using disguises, lies, and other forms of subterfuge.", false, false, "Deception", new Guid("f4206177-80d3-4c9c-8f79-357a608897fa") },
                    { new Guid("13d2e35c-3829-4bab-85c1-de00ff96248a"), "Acrobatics measures your ability to perform tasks requiring coordination and grace. When you use the Escape basic action (page 470), you can use your Acrobatics modifier instead of your unarmed attack modifier.", true, false, "Acrobatics", new Guid("21b2cca1-66cd-48d1-a91b-085521659548") },
                    { new Guid("ab6c56d1-8f95-45db-b4a1-6bae20e30c47"), "You influence others through negotiation and flattery.", false, false, "Diplomacy", new Guid("f4206177-80d3-4c9c-8f79-357a608897fa") },
                    { new Guid("6f23369f-e91f-4472-a254-648ba3ed1850"), "Arcana measures how much you know about arcane magic and creatures. Even if you’re untrained, you can Recall Knowledge (page 238).", false, true, "Arcana", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708"), "Athletics allows you to perform deeds of physical prowess. When you use the Escape basic action (page 470), you can use your Athletics modifier instead of your unarmed attack modifier.", true, false, "Athletics", new Guid("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137") },
                    { new Guid("b41f214e-5d45-46fe-8495-263c3d117a86"), "You are skilled at a form of performance, using your talents to impress a crowd or make a living.", false, false, "Performance", new Guid("f4206177-80d3-4c9c-8f79-357a608897fa") },
                    { new Guid("a14f7dbb-8a76-4b6e-8e67-6adb4f1b39b2"), "You bend others to your will using threats.", false, false, "Intimidation", new Guid("f4206177-80d3-4c9c-8f79-357a608897fa") }
                });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "ActionTypeId", "Area", "CastTime", "ComponentsId", "Description", "Duration", "IsDismissable", "Level", "MagicSchoolId", "Name", "Range", "RollableEffectId", "SavingThrowStatId", "SpellTypeId", "Targets", "TraditionsId", "TraitsId" },
                values: new object[,]
                {
                    { new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1"), new Guid("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8"), null, null, null, "A magical flame springs up from the object, as bright as a torch. It doesn’t need oxygen, react to water, or generate heat.", null, false, 2, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Continual Flame", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 object.", null, null },
                    { new Guid("436d4b2a-846a-4ff1-ae57-63ecfe80f337"), new Guid("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8"), null, null, null, "Oily black tentacles rise up and attempt to capture creatures in the area. Make spell attack rolls against the Fortitude DC of each creature in the area. Any creature you succeed againstis grabbed by a tentacle and takes 3d6 bludgeoning damage.Whenever a creature ends its turn in the area, the tentacles attempt to grab that creature if they haven’t already, and they deal 1d6 bludgeoning damage to any creature already grabbed. The tentacles’ Escape DC is equal to your spell DC. A creature can attack a tentacle in an attempt to release its grip. Its AC is equal to your spell DC, and it is destroyed if it takes 12 or more damage. Even if destroyed, additional tentacles continue to grow in the area until the duration ends. You can Dismiss the spell.", "1 minute.", false, 5, new Guid("1c401dd4-21d6-477d-9ca1-1a6a9d1a8a0d"), "Black Tentacle", 120, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "20-foot burst adjecent to a flat surface.", null, null },
                    { new Guid("54176cd6-c3a3-43fd-8d47-9283811b03bb"), new Guid("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8"), null, null, null, "Blades of force form a churning wall. The wall is a straight line 20 feet high, 120 feet long, and 2 inches thick, and it provides cover. The wall deals 7d8 force damage to each creature that’s in the wall’s space when it is created, that attempts to pass through the wall, or that ends its turn inside the wall. A basic Reflex save reduces the damage. A creature that succeeds at this save when the wall is created is pushed to the nearest space on the side of its choice. Creatures trying to move through the wall fail to do so if they critically fail the save, ending their movement adjacent to the wall.", "1 minute.", false, 6, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Blade Barrier", 120, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("51df17bf-ef57-4eed-973c-55cf33285b61"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "5-foot emanation", null, null, "Blessings from beyond help your companions strike true. You and your allies gain a +1 status bonus to attack rolls while within the emanation. Once per turn, starting the turn after you cast bless, you can use a single action, which has the concentrate trait, to increase the emanation’s radius by 5 feet. Bless can counteract bane.", "1 minute.", false, 1, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Bless", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("3a320d74-73e9-40ab-a972-eb6b571f21fd"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You blind the target. The effect is determined by the target’s Fortitude save. The target then becomes temporarily immune for 1 minute.", null, false, 3, new Guid("fe316215-5436-422b-bd3f-c499d05b5b99"), "Blindness", 30, new Guid("2130dd1b-4239-4b15-9565-f962a6bf3cee"), new Guid("83f532a1-dad3-4dc8-b13d-77e69959444a"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("e130e307-ede2-4a68-9667-cfc482855d95"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You blink quickly between the Material Plane and the Ethereal Plane. You gain resistance 5 to all damage (except force). You can Sustain the Spell to vanish and reappear 10 feet away in a random direction determined by the GM; the movement doesn’t trigger reactions. At the end of your turn, you vanish and reappear as above.", "1 minute.", false, 3, new Guid("1c401dd4-21d6-477d-9ca1-1a6a9d1a8a0d"), "Blink", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("4f77cd26-f3f0-4e6a-8424-b01480daadc4"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "The target’s form appears blurry. It becomes concealed. As the nature of this effect still leaves the target’s location obvious, the target can’t use this concealment to Hide or Sneak.", "1 minute.", false, 2, new Guid("dd5fe60b-e821-4f80-86cb-ed5a9791d1e7"), "Blur", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("27b176c3-a4ac-425b-b7f1-9e6b7c25063f"), new Guid("668ed964-cf7f-43df-b4b3-6a89c28551aa"), null, null, null, "Your blessing revives a creature at the moment of its death. You prevent the target from dying and restore Hit Points to the target equal to 4d8 plus your spellcasting ability modifier. You can’t use breath of life if the triggering effect was disintegrate or a death effect.", null, false, 5, new Guid("fe316215-5436-422b-bd3f-c499d05b5b99"), "Breath of Life", 60, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "The triggering creature.", null, null },
                    { new Guid("ea3e3b79-80ab-4ef4-9dc7-6fb38561a935"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "15-foot cone.", null, null, "Gouts of flame rush from your hands. You deal 2d6 fire damage to creatures in the area.", null, false, 1, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Burning Hands", null, null, new Guid("5048e38a-a47c-4832-b37f-fd3818eced35"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("3a2a1f6e-f8d9-465d-94cc-1253a5c42062"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "10-foot burst.", null, null, "You forcibly calm creatures in the area, soothing them into a nonviolent state; each creature must attempt a Will save.", "1 minute.", false, 2, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Calm Emotions", 120, new Guid("ca435a76-e666-4d33-8087-ca973e4cd537"), new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "60-foot burst.", null, null, "You call upon the unimaginable power of world-ending cataclysms, ripping a small piece of each cataclysm and combining them together into one horrifically powerful attack. The following effects come down upon all creatures in the area. Treat the resistances of creatures in the area as if they were 10 lower for the purpose of determining the cataclysm’s damage.", null, false, 10, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Cataclysm", 1000, null, new Guid("5048e38a-a47c-4832-b37f-fd3818eced35"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("7ca414c2-6185-4817-b1d7-9692d7a4433a"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You discharge a powerful bolt of lightning at the target, dealing 8d12 electricity damage. The target must attempt a basic Reflex save. The electricity arcs to another creature within 30 feet of the first target, jumps to another creature within 30 feet of that target, and so on. You can end the chain at any point. You can’t target the same creature more than once, and you must have line of effect to all targets. Roll the damage only once, and apply it to each target (halving or doubling as appropriate for its saving throw outcome). The chain ends if any one of the targets critically succeeds at its save.", null, false, 6, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Chain Lightning", 500, null, new Guid("5048e38a-a47c-4832-b37f-fd3818eced35"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature, plus any number of additional creatures.", null, null },
                    { new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "To the target, your words are honey and your visage seems bathed in a dreamy haze. It must attempt a Will save, with a +4 circumstance bonus if you or your allies recently threatened it or used hostile actions against it. You can Dismiss the spell. If you use hostile actions against the target, the spell ends. When the spell ends, the target doesn’t necessarily realize it was charmed unless its friendship with you or the actions you convinced it to take clash with its expectations, meaning you could potentially convince the target to continue being your friend via mundane means.", null, false, 1, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Charm", 30, new Guid("ace65902-0a3b-4cec-acb6-6f8282687977"), new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300"), new Guid("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8"), null, null, null, "You create an opaque wall of light in a single vibrant color. The wall is straight and vertical, stretching 60 feet long and 30 feet high. If the wall would pass through a creature, the spell is lost. The wall sheds bright light for 20 feet on each side, and dim light for the next 20 feet. You can ignore the wall’s effects.", "10 minutes.", false, 5, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Chromatic Wall", 120, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("35ac23b0-0e3d-4aab-8217-116f931edcb7"), new Guid("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8"), "10-foor emanation centered on the touched creature.", null, null, "You ward a creature and those nearby against a specified alignment. Choose chaotic, evil, good, or lawful; this spell gains the opposing trait. Creatures in the area gain a +1 status bonus to AC against attacks by creatures of the chosen alignment and to saves against effects from such creatures. This bonus increases to +3 against effects from such creatures that directly control the target and attacks made by summoned creatures of the chosen alignment. Summoned creatures of the chosen alignment can’t willingly enter the area without succeeding at a Will save; repeated attempts use the first save result.", "1 minute.", false, 3, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Circle of Protection", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("484d98ad-91d1-4b2d-86d0-ec997a6f772b"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), null, new TimeSpan(0, 0, 1, 0, 0), null, "You create an invisible floating ear at a location within range (even if it’s outside your line of sight or line of effect). It can’t move, but you can hear through the ear as if using your normal auditory senses.", "10 minutes.", false, 3, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Clairaudience", 500, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("af9903ec-8e9e-4752-bae4-042aca73f91a"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), null, new TimeSpan(0, 0, 1, 0, 0), null, "You create an invisible floating eye at a location within range (even if it’s outside your line of sight or line of effect). The eye can’t move, but you can see in all directions from that point as if using your normal visual senses.", "10 minutes.", false, 4, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Clairvoyance", 500, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("2c2d2218-3a46-4075-899c-c4e9353aaec3"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "A cloak of swirling colors shrouds the target. Creatures are dazzled while adjacent to it, and attacking the target causes a brilliant flash of light. A creature that hits the target with a melee attack must attempt a Will save.", "1 minute.", false, 5, new Guid("dd5fe60b-e821-4f80-86cb-ed5a9791d1e7"), "Cloak of Colors", 30, new Guid("1396db52-7879-4bee-afcb-71cc424a3726"), null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("b59d7490-542e-4d17-9463-2e384faf2c0f"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "With a word of necromantic power, you seize control of the target. It gains the minion trait. If you or an ally uses any hostile actions against the target, the spell ends.", "1 day.", false, 3, new Guid("fe316215-5436-422b-bd3f-c499d05b5b99"), "Bind Undead", 30, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 mindless undead creature with a level no greater than bind undead's spell level.", null, null },
                    { new Guid("a0dc825d-78c6-4464-a62e-17d7001c258e"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You wrench the target’s soul away before it can pass on to the afterlife and imprison it in a black sapphire. While the soul is in the gem, the target can’t be returned to life through any means, even powerful magic such as wish. If the gem is destroyed or bind soul is counteracted on the gem, the soul is freed. The gem has AC 16 and Hardness 10. A gem can’t hold more than one soul, and any attempt wastes the spell.", null, false, 2, new Guid("fe316215-5436-422b-bd3f-c499d05b5b99"), "Bind Soul", 30, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature that died within the last minute.", null, null },
                    { new Guid("41fcd185-b9ba-41aa-96cf-1a8bcb65a64d"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "The target’s skin becomes covered in bark. The target gains resistance 2 to bludgeoning and piercing damage and weakness 3 to fire. After the target takes fire damage, it can Dismiss the spell as a free action triggered by taking the damage; doing so doesn’t reduce the fire damage the target was dealt.", "10 minutes.", false, 2, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Barksin", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 willing creature.", null, null },
                    { new Guid("3a8c5edf-e86c-431a-a25a-bb90d590eb35"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You send the target back to its home plane. The target must attempt a Will save. You can spend an extra action while Casting this Spell and add a material component to give the creature a –2 circumstance penalty to its save. The component must be a specially gathered object that is anathema to the creature, and not from a material component pouch. This spell fails if you aren’t on your home plane when you cast it.", null, false, 5, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Banishment", 30, new Guid("dd05b759-b382-42f9-bfef-e8600b2b28f9"), new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature that isn't on its home plane.", null, null },
                    { new Guid("328dda55-0bc8-461f-a3d3-686df512438c"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "Your touch afflicts the target with Abyssal plague, which siphons fragments of their soul away to empower the Abyss. The effect is based on the target’s Fortitude save.", null, false, 5, new Guid("fe316215-5436-422b-bd3f-c499d05b5b99"), "Abyssal Plague", 0, new Guid("0450af9d-7660-403b-8970-5515635a7779"), new Guid("83f532a1-dad3-4dc8-b13d-77e69959444a"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("9ff794c4-74a1-412e-9d44-06d64f1570b1"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You conjure an arrow of acid that keeps corroding the target after it hits. Make a spell attack against the target. On a hit, you deal 3d8 acid damage plus 1d6 persistent acid damage. On a critical hit, double the initial damage, but not the persistent damage.", null, false, 2, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Acid Arrow", 120, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You harness your mastery of primal forces to reshape your body into a Medium flying animal battle form. When you cast this spell, choose bat, bird, pterosaur, or wasp. You can decide the specific type of animal (such as an owl or eagle for bird), but this has no effect on the form’s Size or statistics. While in this form, you gain the animal trait. You can Dismiss the spell.", "1 minute.", true, 4, new Guid("ab0fac81-a9ed-410e-9886-99923111080a"), "Aerial Form", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("fbb8d7cc-6793-484c-80a8-4fafb137e01e"), new Guid("668ed964-cf7f-43df-b4b3-6a89c28551aa"), null, null, null, "A bubble of pure air appears around the target’s head, allowing it to breathe normally.The effect ends as soon as the target returns to an environment where it can breathe normally.", "1 minute.", false, 4, new Guid("1c401dd4-21d6-477d-9ca1-1a6a9d1a8a0d"), "Air Bubble", 60, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "The triggering creature.", null, null },
                    { new Guid("5c0b6313-4951-4dc4-9289-0ec20210643d"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "The target can walk on air as if it were solid ground. It can ascend and descend in this way at a maximum of a 45 - degree angle.", "5 minutes.", false, 4, new Guid("ab0fac81-a9ed-410e-9886-99923111080a"), "Air Walk", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), "20-foot burst", new TimeSpan(0, 0, 10, 0, 0), null, "You ward an area to alert you when creatures enter without your permission. When you cast alarm, select a password. Whenever a Small or larger corporeal creature enters the spell’s area without speaking the password, alarm sends your choice of a mental alert (in which case the spell gains the mental trait) or an audible alarm with the sound and volume of a hand bell (in which case the spell gains the auditory trait). Either option automatically awakens you, and the bell allows each creature in the area to attempt a DC 15 Perception check to wake up. A creature aware of the alarm must succeed at a Stealth check against the spell’s DC or trigger the spell when moving into the area.", "8 hours.", false, 1, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Alarm", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb"), new Guid("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8"), null, null, null, "You use your occult lore and the power of your mind to manipulate the spiritual multiverse", null, false, 10, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Alter Reality", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("dcadfb92-e8c7-47a4-a6cc-4de6eefb7c3c"), new Guid("668ed964-cf7f-43df-b4b3-6a89c28551aa"), null, null, null, "You punish a creature that transgresses against your deity, drawing upon the anguish you feel upon seeing one of your deity’s anathema committed. You can cast this spell only when a creature actively commits a unique act of anathema. For example, if creating undead were anathema to your deity, you could use anathematic reprisal on a necromancer who had just created undead in front of you, but not on an undead creature just for existing. You deal 4d6 mental damage to the target, but a basic Will save can reduce this damage. If it fails, it is also stupefied 1 for 1 round. The creature is then temporarily immune for 1 minute.", null, false, 4, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Anathematic Reprisal", 30, null, new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "The triggering creature.", null, null },
                    { new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You call upon primal energy to transform yourself into a Medium animal battle form. When you first cast this spell, choose ape, bear, bull, canine, cat, deer, frog, shark, or snake. You can decide the specific type of animal (such as lion or snow leopard for cat), but this has no effect on the form’s Size or statistics. While in this form, you gain the animal trait. You can Dismiss the spell.", "1 minute.", false, 2, new Guid("ab0fac81-a9ed-410e-9886-99923111080a"), "Animal Form", null, null, new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("5ca21ccd-2ccc-4900-99fe-40480d6103f2"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), null, new TimeSpan(0, 0, 1, 0, 0), null, "You offer food, and an ordinary Tiny animal within range approaches to eat it. You imprint the image, direction, and distance of an obvious place or landmark well known to you within the animal. You can also attach a small object or note up to light Bulk to it. The animal does its best to reach the destination; if it makes it there, it waits nearby and allows nonhostile creatures to approach and remove the attached object. The spell ends after the message is delivered or after 24 hours, whichever comes first. If there are no Tiny wild animals in range, the spell is lost.", "24 hours.", false, 2, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Animal Messenger", 120, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("9ebcaed3-689b-4886-939d-a8b0399180c5"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), null, new TimeSpan(0, 0, 1, 0, 0), null, "You tap into the target’s senses, allowing you to see, hear, and otherwise sense whatever it senses for the spell’s duration.If the target wishes to prevent you from doing so, it can attempt a Will save, negating the spell on a success, but most animals don’t bother to do so.While tapping into the target’s senses, you can’t use your own body’s senses, but you can change back and forth from your body’s senses to the target’s senses using a single action, which has the concentrate trait.", "1 hour.", false, 3, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Animal Vision", 120, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 animal.", null, null },
                    { new Guid("001dcfdb-d978-498b-a101-1d13c57b67f2"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You reinforce the target’s musculoskeletal system to bear more weight. The target can carry 3 more Bulk than normal before becoming encumbered and up to a maximum of 6 more Bulk.", "8 hours.", false, 1, new Guid("ab0fac81-a9ed-410e-9886-99923111080a"), "Ant Haul", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("3e91401a-203c-4d1e-9a76-0012e2617cd8"), new Guid("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8"), "10-foot emanation, which affects you.", null, null, "You repel all magic from the target area, preventing spells and other magic from functioning. Spells can’t penetrate the area, magic items cease to function within it, and no one inside can cast spells or use magic abilities. Likewise, spells— such as dispel magic—can’t affect the field itself unless they are of a higher level. Magic effects resume the moment they pass outside the field. For example, a ray fired from one side of the field could target a creature on the other side (as long as caster and target are both outside the field). A summoned creature winks out of existence but reappears if the field moves or ends. Invested magic items cease to function, but they remain invested and resume functioning when they exit the field; the ability boost from an apex item isn’t suppressed within the field. Spells of a higher level than the antimagic field overcome its effects, and can even be cast by a creature within the field. The field disrupts only magic, so a +3 longsword still functions as a longsword. Magically created creatures (such as golems) function normally within an antimagic field.", "1 minute.", false, 8, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Anti-Magic Field", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), null, new TimeSpan(0, 0, 10, 0, 0), null, "You gain a vague glimpse of the future. During the casting of this spell, ask about the results of a particular course of action.", null, false, 2, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Augury", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You transform into an avatar of your deity, assuming a Huge battle form.You must have space to expand or the spell is lost. You have hands in this battle form and can take manipulate actions.", "1 minute.", true, 10, new Guid("ab0fac81-a9ed-410e-9886-99923111080a"), "Avatar", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("79fbdd8a-c496-4974-af00-14c3640841ab"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You transform the target creature into a harmless animal appropriate to the area, with effects based on its Fortitude save.", "1 minute.", false, 6, new Guid("ab0fac81-a9ed-410e-9886-99923111080a"), "Baleful Polymorph", 30, new Guid("f5e8d362-20e3-4342-bd65-73ca29c1825b"), new Guid("83f532a1-dad3-4dc8-b13d-77e69959444a"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("9d06d9f1-deaf-4fd0-8963-9ca6f5a645fa"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "5-foot emanation.", null, null, "You fill the minds of your enemies with doubt. Enemies in the area must succeed at a Will save or take a –1 status penalty to attack rolls as long as they are in the area. Once per turn, starting the turn after you cast bane, you can use a single action, which has the concentrate trait, to increase the emanation’s radius by 5 feet and force enemies in the area that weren’t yet affected to attempt another saving throw. Bane can counteract bless.", "1 minute.", false, 1, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Bane", null, null, new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("1030f973-aee2-4c2f-8cc5-a98aa4594de4"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "20-foot burst", null, null, "You conjure a poisonous fog. This functions as obscuring mist (page 355), except the area moves 10 feet away from you each round. You deal 6d8 poison damage to each breathing creature that starts its turn in the spell’s area. You can Dismiss the spell.", "1 minute.", false, 5, new Guid("dd5fe60b-e821-4f80-86cb-ed5a9791d1e7"), "Cloudkill", 120, null, new Guid("83f532a1-dad3-4dc8-b13d-77e69959444a"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("94beacae-4765-499c-b93e-934fff8585a4"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), null, new TimeSpan(0, 0, 10, 0, 0), null, "You prepare a spell that will trigger later. While casting contingency, you also cast another spell of 4th level or lower with a casting time of no more than 3 actions. This companion spell must be one that can affect you. You must make any decisions for the spell when you cast contingency, such as choosing a damage type for resist energy. During the casting, choose a trigger under which the spell will be cast, using the same restrictions as for the trigger of a Ready action. Once contingency is cast, you can cause the companion spell to come into effect as a reaction with that trigger. It affects only you, even if it would affect more creatures. If you define complicated conditions, as determined by the GM, the trigger might fail. If you cast contingency again, the newer casting supersedes the older.", "24 hour.", false, 7, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Contingency", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("f3fa6c93-ee1d-4da1-982d-55c015c0eeaa"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "30-foot emanation", null, null, "You teleport the targets to new positions within the area. The creatures must each be able to fit in their new space, and their positions must be unoccupied, entirely within the area, and in your line of sight. Unwilling creatures can attempt a Will save.", null, false, 6, new Guid("1c401dd4-21d6-477d-9ca1-1a6a9d1a8a0d"), "Collective Transposition", null, new Guid("1220f4e1-8504-4702-9fcc-5318b162bb12"), null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "Up to 2 creatures.", null, null },
                    { new Guid("4d709d69-ddde-487c-94a3-c876b4e79969"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You shout a command that’s hard to ignore. You can command the target to approach you, run away (as if it had the fleeing condition), release what it’s holding, drop prone, or stand in place. It can’t Delay or take any reactions until it has obeyed your command. The effects depend on the target’s Will save.", "Until the end of the target’s next turn.", false, 1, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Command", 30, new Guid("45c9b2e8-2604-494e-a500-7f16a680eb4c"), new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("1e745c5e-5d8f-4abd-b66c-e0e582833257"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "60-foot burst", null, null, "You create a shimmering barrier that attempts to counteract teleportation effects and planar travel into or out of the area, including items that allow access to extradimensional spaces (such as a bag of holding). Dimensional lock tries to counteract any attempt to summon a creature into the area but doesn’t stop the creature from departing when the summoning ends.", "1 day.", false, 7, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Dimensional Lock", 120, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("c1546cbd-ec60-459f-b7f5-e29d51beb5f2"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You interfere with the target’s ability to teleport and travel between dimensions. Dimensional anchor attempts to counteract any teleportation effect, or any effect that would move the target to a different plane. The duration is determined by the target’s Will save.", "Varies.", false, 4, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Dimensional Anchor", 30, new Guid("7a397e05-ef94-4531-a4d8-24e4596d37c7"), new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature", null, null },
                    { new Guid("2ef1bfc9-3ca3-45b8-804a-ba9d948224de"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "30-foot emanation", null, null, "By tapping into trace divinatory auras, you detect the presence of scrying effects in the area. If detect scrying is higher level than a scrying effect, you gain a glimpse of the scrying creature and learn its approximate distance and direction.", "1 hour.", false, 4, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Detect Scrying", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("8e4669af-e67c-42a4-bd0f-9e117496cb6c"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You detect whether a creature is venomous or poisonous, or if an object is poison or has been poisoned. You do not ascertain whether the target is poisonous in multiple ways, nor do you learn the type or types of poison. Certain substances, like lead and alcohol, are poisons and so mask other poisons.", null, false, 1, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Detect Poison", 30, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 object or creature", null, null },
                    { new Guid("54d80001-c58b-4524-b23d-3962bb5f7ed4"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "30-foot emanation", null, null, "Your eyes glow as you sense aligned auras. Choose chaotic, evil, good, or lawful. You detect auras of that alignment. You receive no information beyond presence or absence. You can choose not to detect creatures or effects you’re aware have that alignment.", null, false, 1, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Detect Alignment", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("3c902d87-38ff-4aad-acb3-266811986252"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You shield a creature from the ravages of negative energy. It receives a +4 status bonus to saves against death and negative effects, gains negative resistance 10, and suppresses the effects of the doomed condition.", "10 minutes.", false, 5, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Death Ward", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 living creature touched.", null, null },
                    { new Guid("236cd0a3-a07b-4c9f-ba11-e3c113d91634"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You snuff the life out of a creature on the brink of death. The target must attempt a Will save. If this kills it, you gain 10 temporary HP and a +1 status bonus to attack and damage rolls for 10 minutes.", null, false, 2, new Guid("fe316215-5436-422b-bd3f-c499d05b5b99"), "Death Knell", 0, new Guid("1d97f155-61d4-4e3e-b56a-5db39776f857"), new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 living creature that has 0 HP.", null, null },
                    { new Guid("509c9a55-433c-4f99-8a7a-609d38f23ed1"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "The target loses hearing; it must attempt a Fortitude save. The target is then temporarily immune for 1 minute.", null, false, 2, new Guid("fe316215-5436-422b-bd3f-c499d05b5b99"), "Deafness", 30, new Guid("fa67be43-2108-4e4d-ab58-18edad117031"), new Guid("83f532a1-dad3-4dc8-b13d-77e69959444a"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("66172098-6cdb-4587-89bb-24fe1a8faf7c"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You grant yourself supernatural sight in areas of darkness. You gain darkvision.", "1 hour.", false, 2, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Darkvision", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e"), new Guid("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8"), "20-foot burst.", null, null, "You create a shroud of darkness that prevents light from penetrating or emanating within the area. Light does not enter the area and any non-magical light sources, such as a torch or lantern, do not emanate any light while inside the area, even if their light radius would extend beyond the darkness. This also suppresses magical light of your darkness spell’s level or lower. Light can’t pass through, so creatures in the area can’t see outside. From outside, it appears as a globe of pure darkness.", "1 minute.", false, 2, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Darkness", 120, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("2665ca32-131c-43cd-b30b-c763eb024a08"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "30-foot cone.", null, null, "You inflict despair on creatures in the area. The effects for each creature are determined by its Will save.", "1 or more rounds.", false, 5, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Crushing Despair", null, new Guid("48a3785a-a84b-4290-9316-b41d51744c0a"), new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("e4568cde-13d1-4684-81b2-180bc291198f"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You issue a divine mandate or proclaim a cause to the targets. It can be to attain an item, claim a patch of land, slay a creature, war with a group, or be entirely peaceful. Your cause can’t force the targets to harm one another or themselves. The targets become completely dedicated to that cause, depending on their levels. They choose their own actions, but they favor direct action over inaction or indirect action.", "4 minutes.", false, 9, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Crusade", 60, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "Up to 4 creatures.", null, null },
                    { new Guid("b7157338-c1de-4e79-a90c-e0f62abd709c"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You assault the target’s faith, riddling the creature with doubt and mental turmoil that deal 6d6 mental damage, or 6d8 mental damage if it can cast divine spells. The effects are determined by its Will save.", null, false, 3, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Crisis of Faith", 30, new Guid("6a073760-7f3c-41ea-adbc-276607b88ece"), new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("311b0146-7b80-4594-800f-b0046237d47f"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), null, new TimeSpan(0, 0, 1, 0, 0), null, "You conjure a temporary object from eldritch energy. It must be of vegetable matter (such as wood or paper) and 5 cubic feet or smaller. It can’t rely on intricate artistry or complex moving parts, never fulfills a cost or the like, and can’t be made of precious materials or materials with a rarity of uncommon or higher. It is obviously temporarily conjured, and thus can’t be sold or passed off as a genuine item.", "1 hour.", false, 4, new Guid("1c401dd4-21d6-477d-9ca1-1a6a9d1a8a0d"), "Creation", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("c5bd7524-e3f5-46b6-b1de-527896978d1c"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "As you cup your hands, water begins to flow forth from them. You create 2 gallons of water. If no one drinks it, it evaporates after 1 day.", null, false, 1, new Guid("1c401dd4-21d6-477d-9ca1-1a6a9d1a8a0d"), "Create Water", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("2d0fa5a4-eab0-4eca-85cb-23241e5ef814"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), null, new TimeSpan(0, 1, 0, 0, 0), null, "You create enough food to feed six Medium creatures for a day. This food is bland and unappealing, but it is nourishing. After 1 day, if no one has eaten the food, it decays and becomes inedible. Most Small creatures eat one-quarter as much as a Medium creature (one-sixteenth as much for most Tiny creatures), and most Large creatures eat 10 times as much (100 times as much for Huge creatures and so on).", null, false, 2, new Guid("1c401dd4-21d6-477d-9ca1-1a6a9d1a8a0d"), "Create Food", 30, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("b2cc63b2-466a-478a-b024-b785f2b722de"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "50 feet long by 50 feet wide", null, null, "By imposing your will upon the water, you can raise or lower the level of water in the chosen area by 10 feet. Water creatures in the area are subjected to the effects of slow.", null, false, 5, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Control Water", 500, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("73180f19-0c26-4f90-b377-8ae1d3df6525"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "Opening a door that bypasses normal space, you instantly transport yourself and any items you’re wearing and holding from your current space to a clear space within range you can see.If this would bring another creature with you—even if you’re carrying it in an extradimensional container—the spell is lost.", null, false, 4, new Guid("1c401dd4-21d6-477d-9ca1-1a6a9d1a8a0d"), "Dimension Door", 120, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("55780227-9986-4a2e-aa35-93a105314818"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You channel the primal forces of nature to transform into a Large animal battle form, specifically that of a powerful and terrifying dinosaur. You must have space to expand or the spell is lost. When you cast this spell, choose ankylosaurus, brontosaurus, deinonychus, stegosaurus, triceratops, or tyrannosaurus. You can decide the specific type of animal, but this has no effect on the form’s Size or statistics. While in this form, you gain the animal and dinosaur traits. You can Dismiss the spell.", "1 minute", false, 4, new Guid("ab0fac81-a9ed-410e-9886-99923111080a"), "Dinosaur Form", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("614267ca-482a-4435-bcea-127594ea342f"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You shroud a creature from others’ senses. The target becomes undetected, not just to sight but to all senses, allowing the target to count as invisible no matter what precise and imprecise senses an observer might have. It’s still possible for a creature to find the target by Seeking, looking for disturbed dust, hearing gaps in the sound spectrum, or finding some other way to discover the presence of an otherwise-undetectable creature", "10 minutes", false, 8, new Guid("dd5fe60b-e821-4f80-86cb-ed5a9791d1e7"), "Disappearance", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("d8cf6802-13fb-4518-a463-538b28bed2da"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), null, null, null, "Falsehoods ring in your ears like discordant notes. You gain a +4 status bonus to Perception checks when someone Lies.", "10 minutes", false, 4, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Discern Lies", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("6505b7e2-7c35-45ed-8fda-ff4bf3dd2822"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "The target can understand the meaning of a single language it is hearing or reading when you cast the spell. This doesn’t let it understand codes, language couched in metaphor, and the like (subject to GM discretion). If the target can hear multiple languages and knows that, it can choose which language to understand; otherwise, choose one of the languages randomly.", "1 hour.", false, 2, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Comprehend Language", 30, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("2a4b767b-27d0-4519-b1f7-c554837d0c73"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "60-foot cone.", null, null, "Icy cold rushes forth from your hands. You deal 12d6 cold damage to creatures in the area.", null, false, 5, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Cone of Cold", null, null, new Guid("5048e38a-a47c-4832-b37f-fd3818eced35"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("068fc3bd-e1ac-4069-8a29-13bd1a0b92f2"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You befuddle your target with strange impulses, causing it to act randomly. The effects are determined by the target’s Will save. You can Dismiss the spell.", "1 minute.", false, 4, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Confusion", 30, new Guid("c52f431c-b8b3-4c0b-946d-1491a8e5168f"), new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null },
                    { new Guid("eb816f67-17d1-439b-badb-2657b57f64e2"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You unleash a beam of divine energy. Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or if your deity is true neutral. Make a ranged spell attack roll against the target’s AC. On a hit, the target takes damage of the chosen alignment type equal to 1d4 + your spellcasting ability modifier (double damage on a critical hit). The spell gains the trait of the alignment you chose.", null, false, 1, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Divine Lance", 30, null, null, new Guid("fbd536e4-6468-4ca5-84de-aa2e5a33776f"), "1 creature", null, null },
                    { new Guid("db143e7b-8212-4350-a09f-09205811470e"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You lance the target with energy. You deal 1d6 positive damage plus your spellcasting ability modifier. The target must attempt a basic Fortitude save.", null, false, 1, new Guid("fe316215-5436-422b-bd3f-c499d05b5b99"), "Disrupt Undead", 30, new Guid("7c7d9f59-2899-4af7-9596-cf6a7711da5a"), new Guid("83f532a1-dad3-4dc8-b13d-77e69959444a"), new Guid("fbd536e4-6468-4ca5-84de-aa2e5a33776f"), "1 undead creature.", null, null },
                    { new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "30-foot emanation", null, null, "You send out a pulse that registers the presence of magic. You receive no information beyond the presence or absence of magic. You can choose to ignore magic you’re fully aware of, such as the magic items and ongoing spells of you and your allies.", null, false, 1, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Detect Magic", null, null, null, new Guid("fbd536e4-6468-4ca5-84de-aa2e5a33776f"), null, null, null },
                    { new Guid("2d8be059-3a79-4d4d-a7e8-31dee66680cc"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You cloud the target’s mind and daze it with a mental jolt. The jolt deals mental damage equal to your spellcasting ability modifier; the target must attempt a basic Will save. If the target critically fails the save, it is also stunned 1.", "1 round.", false, 1, new Guid("652580a1-b993-4326-9baa-460b5f6c9ba0"), "Daze", 50, null, new Guid("a71929b0-9dff-492a-9bf9-8f9cadda198c"), new Guid("fbd536e4-6468-4ca5-84de-aa2e5a33776f"), "1 creature.", null, null },
                    { new Guid("7b0f3283-1f79-4a64-a697-eb842bb776b2"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You create up to four floating lights, no two of which are more than 10 feet apart. Each sheds light like a torch. When you Sustain the Spell, you can move any number of lights up to 60 feet. Each light must remain within 120 feet of you and within 10 feet of all others, or it winks out.", "Sustained.", false, 1, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Dancing Lights", 120, null, null, new Guid("fbd536e4-6468-4ca5-84de-aa2e5a33776f"), null, null, null },
                    { new Guid("060ba321-f5b9-4ac8-907c-fec7bb740713"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "15-foot cone.", null, null, "Swirling colors affect viewers based on their Will saves.", null, false, 1, new Guid("dd5fe60b-e821-4f80-86cb-ed5a9791d1e7"), "Color Spray", null, new Guid("c5391ad6-09cd-42a9-ac94-74f04f4efc97"), null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "Siphoning negative energy into yourself, your hand radiates a pale darkness. Your touch weakens the living and disorients undead, possibly even causing them to flee. The effect depends on whether the target is living or undead.", null, false, 1, new Guid("fe316215-5436-422b-bd3f-c499d05b5b99"), "Chill Touch", 0, null, new Guid("83f532a1-dad3-4dc8-b13d-77e69959444a"), new Guid("fbd536e4-6468-4ca5-84de-aa2e5a33776f"), "1 living or undead creature.", null, null },
                    { new Guid("6e689573-2fdb-409f-abd2-a27135775498"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You accept otherworldly energies into your body; while you are still recognizably yourself, you gain the features of one of your deity’s servitors. Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose.", "1 minute", false, 7, new Guid("ab0fac81-a9ed-410e-9886-99923111080a"), "Divine Vessel", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("7ebf76e9-a8fb-49a1-956c-f97f784dcbb9"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "40-foot emanation.", null, null, "You utter a potent litany from your faith, a mandate that harms those who oppose your ideals. Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose. You deal 7d10 damage to creatures in the area; each creature must attempt a Fortitude save. Creatures with an alignment that matches the one you chose are unaffected by the spell. Those that neither match nor oppose it treat the result of their saving throw as one degree better and don’t suffer effects other than damage.", "Varies.", false, 7, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Divine Decree", 40, new Guid("1d9d9b1c-7036-46dd-9067-f132780d776c"), new Guid("83f532a1-dad3-4dc8-b13d-77e69959444a"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), null, null, null },
                    { new Guid("b6f25115-9358-44eb-bfc2-37b01c3863f4"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), "10-foot emanation.", null, null, "Divine power wards the targets, granting each a +1 status bonus to AC and saves while in the area.", "Sustained up to 1 minute.", false, 1, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Divine Aura", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "Allies in the area.", null, null },
                    { new Guid("9627d10b-e488-4299-9e1b-2c3a511ec007"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You infuse weapons with positive energy. Attacks with these weapons deal an extra 1d4 positive damage to undead.", "1 minute", false, 1, new Guid("fe316215-5436-422b-bd3f-c499d05b5b99"), "Disrupting Weapons", 0, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "Up to two weapons, each of which must be wielded by you or a willing ally, or else is unattended.", null, null },
                    { new Guid("5d1503f3-0176-4480-93b5-c4b4fef56dd3"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You unravel the magic behind a spell or effect. Attempt a counteract check against the target (page 458). If you successfully counteract a magic item, the item becomes a mundane item of its type for 10 minutes. This doesn’t change the item’s non-magical properties. If the target is an artifact or similar item, you automatically fail.", null, false, 2, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Dispel Magic", 120, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 spell effect or unattended magic item.", null, null },
                    { new Guid("05375af9-4bc5-4eab-8731-2fb74c2062d9"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "Crackling energy disjoins the target. You attempt to counteract it (page 458). If you succeed, it’s deactivated for 1 week. On a critical success, it’s destroyed. If it’s an artifact or similar item, you automatically fail.", null, false, 9, new Guid("76c4e166-abdb-471f-8fde-4c08a765ce2b"), "Disjunction", 120, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 magical item.", null, null },
                    { new Guid("8280e542-c9e9-41d9-b152-aff2f054d447"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You fire a green ray at your target. Make a spell attack. You deal 12d10 damage, and the target must attempt a basic Fortitude save. On a critical hit, treat the save result as one degree worse. A creature reduced to 0 HP is reduced to fine powder; its gear remains.", null, false, 6, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Disintegrate", 120, null, new Guid("83f532a1-dad3-4dc8-b13d-77e69959444a"), new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature or unattended object.", null, null },
                    { new Guid("31f6e676-dbee-4c8f-9f17-a842afab35e3"), new Guid("26ab8b82-ea91-4247-934b-618c724aca8b"), null, new TimeSpan(0, 0, 10, 0, 0), null, "You learn the name of the target’s exact location (including the building, community, and country) and plane of existence.", "1 minute", false, 4, new Guid("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), "Discern Location", null, null, null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature or object", null, null },
                    { new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You splash a glob of acid that splatters your target and nearby creatures. Make a spell attack. If you hit, you deal 1d6 acid damage plus 1 splash acid damage. On a critical success, the target also takes 1 persistent acid damage.", null, false, 1, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Acid Splash", 30, null, null, new Guid("fbd536e4-6468-4ca5-84de-aa2e5a33776f"), "1 creature.", null, null },
                    { new Guid("fc8ec088-6c8d-4d90-9293-9fc0720a3855"), new Guid("fe122850-b449-482d-8350-ac21e8985594"), null, null, null, "You shoot an utterly cold ray of darkness tinged with unholy energy. Make a ranged spell attack against the target. You deal 5d6 cold damage, plus 5d6 evil damage if the target is a celestial. If the ray passes through an area of magical light or targets a creature affected by magical light, chilling darkness attempts to counteract the light. If you need to determine whether the ray passes through an area of light, draw a line between yourself and the spell’s target.", null, false, 3, new Guid("438b96b3-ea22-4131-b938-ce7073c933b4"), "Chilling Darkness", 120, new Guid("c067daf9-15b6-4f2a-9bac-303584f7f85d"), null, new Guid("daeadc1d-bf76-442b-9b4c-8276fa9effac"), "1 creature.", null, null }
                });

            migrationBuilder.InsertData(
                table: "ActionDetailsBlock",
                columns: new[] { "Id", "ActionId", "Text" },
                values: new object[,]
                {
                    { new Guid("f2def960-90a3-4293-9649-24a380ce33e5"), new Guid("4163f1f7-245b-4989-b4a9-8638d75f2cdc"), "You wait for the right moment to act. The rest of your turn doesn’t happen yet. Instead, you’re removed from the initiative order. You can return to the initiative order as a free action triggered by the end of any other creature’s turn. This permanently changes your initiative to the new position. You can’t use reactions until you return to the initiative order. If you Delay an entire round without returning to the initiative order, the actions from the Delayed turn are lost, your initiative doesn’t change, and your next turn occurs at your original position in the initiative order." },
                    { new Guid("e9c5de9d-eef6-46d4-ae1b-0dee8958af0c"), new Guid("187ebb2b-c829-4d40-81dd-414a48ea766e"), "You indicate a creature that you can see to one or more allies, gesturing in a direction and describing the distance verbally. That creature is hidden to your allies, rather than undetected (page 466). This works only for allies who can see you and are in a position where they could potentially detect the target. If your allies can’t hear or understand you, they must succeed at a Perception check against the creature’s Stealth DC or they misunderstand and believe the target is in a different location." },
                    { new Guid("d04ec0db-0e06-4422-963e-1161dcbc2ba9"), new Guid("4deb6d4d-0808-4755-897e-412a0d6e1f21"), "You stand up from prone." },
                    { new Guid("1bf68b96-2ca3-4353-ab9a-657394acdadc"), new Guid("1e0c25df-54a1-41f0-8f21-2f6cdc08f59a"), "You carefully move 5 feet. Unlike most types of movement, Stepping doesn’t trigger reactions, such as Attacks of Opportunity, that can be triggered by move actions or upon leaving or entering a square." },
                    { new Guid("9aea3dfc-ee32-48c0-b420-1e9ffbd3d318"), new Guid("1e0c25df-54a1-41f0-8f21-2f6cdc08f59a"), "You can’t Step into difficult terrain (page 475), and you can’t Step using a Speed other than your land Speed." },
                    { new Guid("3fb46634-1f05-49e3-afbc-4cc2c1553980"), new Guid("55bca308-af52-4da5-a1e4-a6c1059c5321"), "You press yourself against a wall or duck behind an obstacle to take better advantage of cover (page 477). If you would have standard cover, you instead gain greater cover, which provides a +4 circumstance bonus to AC; to Reflex saves against area effects; and to Stealth checks to Hide, Sneak, or otherwise avoid detection. Otherwise, you gain the benefits of standard cover (a +2 circumstance bonus instead). This lasts until you move from your current space, use an attack action, become unconscious, or end this effect as a free action." },
                    { new Guid("1a320b87-a7f6-4d18-b4e2-3ea5dd7008a6"), new Guid("56d03917-ff05-4b95-9455-4cb2ccbc9a60"), "You prepare to use an action that will occur outside your turn. Choose a single action or free action you can use, and designate a trigger. Your turn then ends. If the trigger you designated occurs before the start of your next turn, you can use the chosen action as a reaction (provided you still meet the requirements to use it). You can’t Ready a free action that already has a trigger." },
                    { new Guid("23ce08c6-58c9-43a0-8028-aa462b266f98"), new Guid("56d03917-ff05-4b95-9455-4cb2ccbc9a60"), "If you have a multiple attack penalty and your readied action is an attack action, your readied attack takes the multiple attack penalty you had at the time you used Ready. This is one of the few times the multiple attack penalty applies when it’s not your turn." },
                    { new Guid("37cbf292-bc7b-46d3-909a-0bf344afe97b"), new Guid("ab48c6d8-a194-4595-8358-c751fdc934d8"), "You move onto the creature and ride it. If you’re already mounted, you can instead use this action to dismount, moving off the mount into a space adjacent to it." },
                    { new Guid("36548991-704d-4a82-a2c4-0622eb57f728"), new Guid("577e96ba-5bf3-46e7-9f4b-eb5b71546bfd"), "You attack with a weapon you’re wielding or with an unarmed attack, targeting one creature within your reach (for a melee attack) or within range (for a ranged attack). Roll the attack roll for the weapon or unarmed attack you are using, and compare the result to the target creature’s AC to determine the effect. See Attack Rolls on page 446 and Damage on page 450 for details on calculating your attack and damage rolls." },
                    { new Guid("d666a8f0-877c-4b2d-8bac-7c3cbe35b525"), new Guid("ada1f776-2e98-4e7d-96e1-2166837fab6b"), "The GM attempts a single secret Perception check for you and compares the result to the Stealth DCs of any undetected or hidden creatures in the area or the DC to detect each object in the area (as determined by the GM or by someone Concealing the Object). A creature you detect might remain hidden, rather than becoming observed, if you’re using an imprecise sense or if an effect (such as invisibility) prevents the subject from being observed." },
                    { new Guid("722290ac-d0fa-43f9-9406-291d071f0fc9"), new Guid("ada1f776-2e98-4e7d-96e1-2166837fab6b"), "If you’re using Seek to search for objects (including secret doors and hazards), you search up to a 10-foot square adjacent to you. The GM might determine you need to Seek as an activity, taking more actions or even minutes or hours if you’re searching a particularly cluttered area." },
                    { new Guid("e2a4876a-0d17-4bca-9874-8a0f708e39c3"), new Guid("ada1f776-2e98-4e7d-96e1-2166837fab6b"), "You scan an area for signs of creatures or objects. If you’re looking for creatures, choose an area you’re scanning. If precision is necessary, the GM can have you select a 30-foot cone or a 15-foot burst within line of sight. You might take a penalty if you choose an area that’s far away." },
                    { new Guid("135aadcd-6eaf-4401-909d-de2414c5ccbc"), new Guid("90d27bd9-31ed-46f4-a174-467e165ed1b9"), "When you fall off or past an edge or other handhold, you can try to grab it, potentially stopping your fall. You must succeed at a Reflex save, usually at the Climb DC. If you grab the edge or handhold, you can then Climb up using Athletics." },
                    { new Guid("cb5d193c-21b9-44a4-8370-766b898ceae9"), new Guid("185abe1a-6c43-4884-bb8a-4f596e75442f"), "You try to help your ally with a task. To use this reaction, you must first prepare to help, usually by using an action during your turn. You must explain to the GM exactly how you’re trying to help, and they determine whether you can Aid your ally." },
                    { new Guid("60fe2d98-ba32-435e-ac1c-1abb6e8a5691"), new Guid("185abe1a-6c43-4884-bb8a-4f596e75442f"), "When you use your Aid reaction, attempt a skill check or attack roll of a type decided by the GM. The typical DC is 20, but the GM might adjust this DC for particularly hard or easy tasks. The GM can add any relevant traits to your preparatory action or to your Aid reaction depending on the situation, or even allow you to Aid checks other than skill checks and attack rolls." },
                    { new Guid("386cc768-8cc0-11eb-8dcd-0242ac130003"), new Guid("3367ce7a-8cc0-11eb-8dcd-0242ac130003"), "You attempt an Acrobatics check to slow your fall. The DC is typically 15, but it might be higher due to air turbulence or other circumstances." },
                    { new Guid("65547cff-999a-493d-a6c1-4f56d3f0662a"), new Guid("f715d730-9ad4-4922-b893-cda88fe25ea4"), "You try to tell whether a creature’s behavior is abnormal. Choose one creature, and assess it for odd body language, signs of nervousness, and other indicators that it might be trying to deceive someone. The GM attempts a single secret Perception check for you and compares the result to the Deception DC of the creature, the DC of a spell affecting the creature’s mental state, or another appropriate DC determined by the GM. You typically can’t try to Sense the Motive of the same creature again until the situation changes significantly." },
                    { new Guid("6a431cbd-e07c-41e9-b824-179847fe0207"), new Guid("99ab25a7-a541-4074-ae20-fb25b87520cd"), "Jumping a greater distance requires using the Athletics skill." },
                    { new Guid("5055a0f7-a922-4b49-b57f-40938f30d803"), new Guid("c2bcb0d1-7feb-4f52-8046-d630a6c8f09f"), "You attempt to escape from being grabbed, immobilized, or restrained. Choose one creature, object, spell effect, hazard, or other impediment imposing any of those conditions on you. Attempt a check using your unarmed attack modifier against the DC of the effect. This is typically the Athletics DC of a creature grabbing you, the Thievery DC of a creature who tied you up, the spell DC for a spell effect, or the listed Escape DC of an object, hazard, or other impediment. You can attempt an Acrobatics or Athletics check instead of using your attack modifier if you choose (but this action still has the attack trait)." },
                    { new Guid("4014c48b-23f3-4382-81c7-3b9e7c1eec47"), new Guid("ed94ef79-c37c-4591-a520-557916925352"), "You release something you’re holding in your hand or hands. This might mean dropping an item, removing one hand from your weapon while continuing to hold it in another hand, releasing a rope suspending a chandelier, or performing a similar action. Unlike most manipulate actions, Release does not trigger reactions that can be triggered by actions with the manipulate trait (such as Attack of Opportunity)." },
                    { new Guid("2e208301-e15b-4adc-9929-d35835141a08"), new Guid("99ab25a7-a541-4074-ae20-fb25b87520cd"), "You take a careful, short jump. You can Leap up to 10 feet horizontally if your Speed is at least 15 feet, or up to 15 feet horizontally if your Speed is at least 30 feet. You land in the space where your Leap ends (meaning you can typically clear a 5-foot gap, or a 10-foot gap if your Speed is 30 feet or more)." },
                    { new Guid("c9a4cd10-fd21-4bb9-a356-a47d4837599a"), new Guid("4163f1f7-245b-4989-b4a9-8638d75f2cdc"), "When you Delay, any persistent damage or other negative effects that normally occur at the start or end of your turn occur immediately when you use the Delay action. Any beneficial effects that would end at any point during your turn also end. The GM might determine that other effects end when you Delay as well. Essentially, you can’t Delay to avoid negative consequences that would happen on your turn or to extend beneficial effects that would end on your turn." },
                    { new Guid("1345cbb1-4a0d-47e6-918f-f09fa0bd859b"), new Guid("4384a058-8cc0-11eb-8dcd-0242ac130003"), "You avert your gaze from danger. You gain a +2 circumstance bonus to saves against visual abilities that require you to look at a creature or object, such as a medusa’s petrifying gaze. Your gaze remains averted until the start of your next turn." },
                    { new Guid("ea4b9697-2a26-4b33-aa9d-f6908ab082e3"), new Guid("5f770553-dac1-4377-8416-1a2a2e8f43be"), "You move 5 feet by crawling and continue to stay prone." },
                    { new Guid("168a4329-2ae8-48a5-8fa6-a5508a9b1b86"), new Guid("ed94ef79-c37c-4591-a520-557916925352"), "If you want to prepare to Release something outside of your turn, use the Ready activity." },
                    { new Guid("d4aeb760-f7a2-4095-bc96-e2f70ab49b80"), new Guid("99ab25a7-a541-4074-ae20-fb25b87520cd"), "If you Leap vertically, you can move up to 3 feet vertically and 5 feet horizontally onto an elevated surface." },
                    { new Guid("3628f76a-d2f7-4391-9282-f7812e69ae26"), new Guid("b66bad20-3677-47eb-9344-c78e538adcd3"), "You use your hand or hands to manipulate an object or the terrain. You can grab an unattended or stored object, open a door, or produce some similar effect. You might have to attempt a skill check to determine if your Interact action was successful." },
                    { new Guid("609e4ef2-f376-48d0-8f70-620733c8b8d5"), new Guid("e5d48006-5153-4ebf-a71e-401cc0bc3d4a"), "You fall prone." },
                    { new Guid("015a016b-90ec-42b1-9e9b-28c230d06999"), new Guid("eb1f9f32-3d35-479a-a3e2-bf965e32fc3d"), "You dig your way through dirt, sand, or a similar loose material at a rate up to your burrow Speed. You can’t burrow through rock or other substances denser than dirt unless you have an ability that allows you to do so." },
                    { new Guid("a92602b3-303e-448f-91a1-8cf3dbce6c5a"), new Guid("31fb2827-6ed7-455e-b135-9f4893b298fb"), "You move through the air up to your fly Speed. Moving upward (straight up or diagonally) uses the rules for moving through difficult terrain. You can move straight down 10 feet for every 5 feet of movement you spend. If you Fly to the ground, you don’t take falling damage. You can use an action to Fly 0 feet to hover in place. If you’re airborne at the end of your turn and didn’t use a Fly action this round, you fall." }
                });

            migrationBuilder.InsertData(
                table: "ActionTrait",
                columns: new[] { "ActionsId", "TraitsId" },
                values: new object[,]
                {
                    { new Guid("c2bcb0d1-7feb-4f52-8046-d630a6c8f09f"), new Guid("856db08f-edad-472b-b870-65a8f16252a5") },
                    { new Guid("577e96ba-5bf3-46e7-9f4b-eb5b71546bfd"), new Guid("856db08f-edad-472b-b870-65a8f16252a5") },
                    { new Guid("f715d730-9ad4-4922-b893-cda88fe25ea4"), new Guid("5f7b92e7-09d2-4717-8588-56b45c08a111") },
                    { new Guid("ada1f776-2e98-4e7d-96e1-2166837fab6b"), new Guid("c5e1a5e7-5d45-4826-b2ea-018b361770de") },
                    { new Guid("5f770553-dac1-4377-8416-1a2a2e8f43be"), new Guid("08bac763-e881-4a70-b253-916191ee9713") },
                    { new Guid("f715d730-9ad4-4922-b893-cda88fe25ea4"), new Guid("c5e1a5e7-5d45-4826-b2ea-018b361770de") },
                    { new Guid("ab48c6d8-a194-4595-8358-c751fdc934d8"), new Guid("08bac763-e881-4a70-b253-916191ee9713") },
                    { new Guid("90d27bd9-31ed-46f4-a174-467e165ed1b9"), new Guid("dee6c869-337c-4f4c-ba3c-3c3e77c19857") },
                    { new Guid("56d03917-ff05-4b95-9455-4cb2ccbc9a60"), new Guid("c5e1a5e7-5d45-4826-b2ea-018b361770de") },
                    { new Guid("187ebb2b-c829-4d40-81dd-414a48ea766e"), new Guid("44a18bec-0799-41a7-9b07-16113bb0623f") },
                    { new Guid("187ebb2b-c829-4d40-81dd-414a48ea766e"), new Guid("dee6c869-337c-4f4c-ba3c-3c3e77c19857") },
                    { new Guid("187ebb2b-c829-4d40-81dd-414a48ea766e"), new Guid("e2bb08cb-cf59-4e29-8738-52c751405fb0") },
                    { new Guid("99ab25a7-a541-4074-ae20-fb25b87520cd"), new Guid("08bac763-e881-4a70-b253-916191ee9713") },
                    { new Guid("4deb6d4d-0808-4755-897e-412a0d6e1f21"), new Guid("08bac763-e881-4a70-b253-916191ee9713") },
                    { new Guid("1e0c25df-54a1-41f0-8f21-2f6cdc08f59a"), new Guid("08bac763-e881-4a70-b253-916191ee9713") },
                    { new Guid("b66bad20-3677-47eb-9344-c78e538adcd3"), new Guid("dee6c869-337c-4f4c-ba3c-3c3e77c19857") },
                    { new Guid("31fb2827-6ed7-455e-b135-9f4893b298fb"), new Guid("08bac763-e881-4a70-b253-916191ee9713") },
                    { new Guid("ada1f776-2e98-4e7d-96e1-2166837fab6b"), new Guid("5f7b92e7-09d2-4717-8588-56b45c08a111") },
                    { new Guid("eb1f9f32-3d35-479a-a3e2-bf965e32fc3d"), new Guid("08bac763-e881-4a70-b253-916191ee9713") },
                    { new Guid("e5d48006-5153-4ebf-a71e-401cc0bc3d4a"), new Guid("08bac763-e881-4a70-b253-916191ee9713") },
                    { new Guid("ed94ef79-c37c-4591-a520-557916925352"), new Guid("dee6c869-337c-4f4c-ba3c-3c3e77c19857") }
                });

            migrationBuilder.InsertData(
                table: "BaseFeatEffectBinding",
                columns: new[] { "Id", "Discriminator", "FeatId" },
                values: new object[,]
                {
                    { new Guid("967c98bc-088c-4fb7-9d44-ff7a6f90f506"), "FeatEffectBinding", new Guid("b8193a38-a31c-45f2-a715-2542f09b97ca") },
                    { new Guid("a7158664-5a5e-4ca9-af4d-fd6d5e183da5"), "FeatEffectBinding", new Guid("2c8b47a4-eb56-491b-82fd-a3f894282025") },
                    { new Guid("6634aaf1-a340-4b96-a815-8227dcffa9e5"), "FeatEffectBinding", new Guid("2c8b47a4-eb56-491b-82fd-a3f894282025") },
                    { new Guid("aab01fbb-7034-4f04-b135-dcaecd6e765a"), "FeatEffectBinding", new Guid("2c8b47a4-eb56-491b-82fd-a3f894282025") },
                    { new Guid("43501d01-6d1e-497d-9cf8-81c0a0266232"), "FeatEffectBinding", new Guid("2c8b47a4-eb56-491b-82fd-a3f894282025") }
                });

            migrationBuilder.InsertData(
                table: "BasePrerequisiteBinding",
                columns: new[] { "Id", "Discriminator", "FeatId" },
                values: new object[,]
                {
                    { new Guid("c8867d56-91ed-416e-9bc3-d2ef213bb3aa"), "FeatPrerequisiteBinding", new Guid("fccdaf8a-46b0-4a18-9a90-dbb228317b58") },
                    { new Guid("276c32c0-d4b4-468b-bd7d-3faa635a76b6"), "FeatPrerequisiteBinding", new Guid("174c21f8-b29a-4141-9070-eca5ecfdee71") },
                    { new Guid("0a89ce88-3517-439b-8149-414aa59fbd80"), "FeatPrerequisiteBinding", new Guid("6f59e2f4-2100-436d-8cf8-266585faa937") },
                    { new Guid("1ebd72e0-3e61-42ad-b3b7-8f68c2094de2"), "FeatPrerequisiteBinding", new Guid("ccdd4b23-9813-407e-a7a6-8bc2cdafbab5") },
                    { new Guid("c591078d-1a92-40eb-a7b9-611748799608"), "FeatPrerequisiteBinding", new Guid("738f86de-6f73-4ffa-a790-abd8feeb43c5") },
                    { new Guid("93adf76b-93db-4a21-96dd-18344ed3f4e6"), "FeatPrerequisiteBinding", new Guid("3f62ad52-d80b-4662-979c-6eb66a224801") },
                    { new Guid("99aa8f00-de7a-4968-9d1b-702c30912758"), "FeatPrerequisiteBinding", new Guid("0f49189c-434c-4490-8cbe-5235e6274441") },
                    { new Guid("af734054-75d9-4248-a87d-0b5952f90107"), "FeatPrerequisiteBinding", new Guid("43f75824-0d49-466f-aa58-e40046c4a6d4") },
                    { new Guid("04f0104f-5c14-447e-95b4-cfaaba3f4cbc"), "FeatPrerequisiteBinding", new Guid("89921651-065e-48f8-98cb-c9b6cf6c71e9") },
                    { new Guid("60c37f30-39dd-4fb1-9ecc-3ad80b2ab3ef"), "FeatPrerequisiteBinding", new Guid("89921651-065e-48f8-98cb-c9b6cf6c71e9") },
                    { new Guid("52cc51ea-a378-4653-90bd-6fde5569ae0b"), "FeatPrerequisiteBinding", new Guid("3d690c93-0e1b-42c8-9d62-4e4219729dec") },
                    { new Guid("ca730a60-9507-4f6a-8279-33e15fe8d7eb"), "FeatPrerequisiteBinding", new Guid("6f87700e-7194-47d6-a9b2-20e0e2e53482") },
                    { new Guid("11098127-44c6-4d82-9977-981fc20e637b"), "FeatPrerequisiteBinding", new Guid("9b475bb4-2086-4f81-b4ab-ef3f8f09f5db") },
                    { new Guid("a4c66b29-0433-4ac7-901a-0eca0b5e793c"), "FeatPrerequisiteBinding", new Guid("a1804dfb-e3e0-45aa-b735-2f37fed15779") },
                    { new Guid("09e0806b-4107-46a1-a5db-8a7afa301f4d"), "FeatPrerequisiteBinding", new Guid("68a98dbf-4a45-4217-a94f-2d0969915d96") },
                    { new Guid("acd168ad-b9c9-406e-963d-ae3a449af924"), "FeatPrerequisiteBinding", new Guid("0f49189c-434c-4490-8cbe-5235e6274441") },
                    { new Guid("6c7f9f03-7c92-4501-8328-dd54627898f6"), "FeatPrerequisiteBinding", new Guid("c8dd98a8-e102-4751-9606-88ed457bfdeb") },
                    { new Guid("76fe7bde-7fb7-4ddf-86c5-02e226fe18fa"), "FeatPrerequisiteBinding", new Guid("4f6b0041-df64-4d81-9ddd-baebcfdd28ed") },
                    { new Guid("eae50f6e-3de5-4ff9-94e9-f0d0dfe8df88"), "FeatPrerequisiteBinding", new Guid("18e0c385-d2ba-4646-989d-2e49d43d5f36") },
                    { new Guid("a9682158-d756-4503-a952-454d8396b2a2"), "FeatPrerequisiteBinding", new Guid("d76bcd62-20d9-4fce-9fc1-735ec21a0cb2") },
                    { new Guid("89f13323-62f1-4f79-ae26-dfb3dd7edeec"), "FeatPrerequisiteBinding", new Guid("38b0c4f7-2ad6-4c04-928d-dc53f2ff39b7") },
                    { new Guid("56e776af-2740-4dc6-b0ce-d1d31abcea9f"), "FeatPrerequisiteBinding", new Guid("fa30f639-b913-4050-b7bc-a8e9991178f1") },
                    { new Guid("8cbd0753-5757-4b8b-b134-4a9aa2196e79"), "FeatPrerequisiteBinding", new Guid("219b84b9-cb31-44df-b37e-6bf4916e5dfb") },
                    { new Guid("abe5405c-a349-4fb2-8a49-ac761cfe23da"), "FeatPrerequisiteBinding", new Guid("2c8b47a4-eb56-491b-82fd-a3f894282025") },
                    { new Guid("05b93357-0b9d-4e08-9a66-a2ede8b4181c"), "FeatPrerequisiteBinding", new Guid("57442d19-cae2-465c-9d3d-2e77ecde2a50") },
                    { new Guid("d117552a-f149-48fd-8ff1-425893fb7b00"), "FeatPrerequisiteBinding", new Guid("a6def9d1-3dd5-4d2f-8e75-1773753119d9") },
                    { new Guid("79c0f62e-189b-4c8f-b18c-349f2f4237eb"), "FeatPrerequisiteBinding", new Guid("e4c0f632-f086-40f7-81c4-2d54f1bcb5b9") },
                    { new Guid("67a960ad-7744-4ad9-a3b2-1f9445e52e69"), "FeatPrerequisiteBinding", new Guid("ca8d59e8-f938-4ffb-9890-9bed87134d5b") },
                    { new Guid("076dadf7-1f3a-450a-9a4b-360c571f6070"), "FeatPrerequisiteBinding", new Guid("6684d89b-1994-4fa9-8b6b-c5123b642e86") },
                    { new Guid("d1f28e19-88e4-4a8e-969a-581b93527bc7"), "FeatPrerequisiteBinding", new Guid("5ac7371e-af01-460e-a188-198481c67505") },
                    { new Guid("83a915d1-a69b-4a0e-b48f-ce0167b389f9"), "FeatPrerequisiteBinding", new Guid("6db67ca1-3fef-4705-9ad3-4d0e121e943b") },
                    { new Guid("eefa8738-3515-4eec-af4f-8ad520eff4a0"), "FeatPrerequisiteBinding", new Guid("1acd1549-a4de-477d-a3f4-e862c04c8a7a") },
                    { new Guid("add7f52e-652d-4950-83bf-fc78dcec4a4b"), "FeatPrerequisiteBinding", new Guid("0422a543-ec8f-4c04-9e15-5b4fd5c1f065") },
                    { new Guid("fc764cdf-3471-461a-b528-1fdacfc69ddd"), "FeatPrerequisiteBinding", new Guid("a64ac93e-e7c5-46d1-85ec-72d93d5dcf7a") },
                    { new Guid("9e791723-1f8e-480d-844f-0e0fe4aae005"), "FeatPrerequisiteBinding", new Guid("9c848549-edaa-49b9-aa64-fcea1ccbc966") },
                    { new Guid("638cc413-e502-4f9c-9183-da9958c38df9"), "FeatPrerequisiteBinding", new Guid("9ab4e3c9-f592-4c0d-ac6e-adb33651feca") },
                    { new Guid("b25cd8ca-09c2-421c-9fba-b012a04e9085"), "FeatPrerequisiteBinding", new Guid("269b8813-ba84-42c6-9b73-11de579797bb") },
                    { new Guid("c7af13d6-533f-4d31-b058-a16371e5f7fc"), "FeatPrerequisiteBinding", new Guid("a38f19f2-3b2d-4907-8425-d71dc351e8df") },
                    { new Guid("ee3c490c-28f3-410a-bce3-c7de7c756ff8"), "FeatPrerequisiteBinding", new Guid("a38f19f2-3b2d-4907-8425-d71dc351e8df") },
                    { new Guid("a1321519-14ba-4357-bae3-9bdb828a3e63"), "FeatPrerequisiteBinding", new Guid("059f1e6a-f8cd-4be2-8024-ddc21dd7cd60") },
                    { new Guid("948b49bd-4759-47e9-924c-f0655daf58bd"), "FeatPrerequisiteBinding", new Guid("5c26de36-847d-4a16-8871-0a2016fdfacc") },
                    { new Guid("701fc8e3-f113-4fcb-b2bb-1e98a70060bc"), "FeatPrerequisiteBinding", new Guid("2fbc54de-6f02-49d5-a01c-6adfd732a81e") },
                    { new Guid("bfeb1d14-08a6-4121-b836-2f4f76339d3e"), "FeatPrerequisiteBinding", new Guid("17f35e0f-3778-4143-b516-d08faf79bc68") },
                    { new Guid("a85e2c74-32bb-42f4-b3bd-dd42dd68fdc0"), "FeatPrerequisiteBinding", new Guid("fffc0274-b5cd-428f-8144-a7d8b01f5986") },
                    { new Guid("3e5994d8-c6c5-43fb-acb3-1654a1850197"), "FeatPrerequisiteBinding", new Guid("dbd06473-8700-438f-b4e1-35474b87171c") },
                    { new Guid("e412585e-1ba6-4f86-9c06-7f7ce9ae82f9"), "FeatPrerequisiteBinding", new Guid("0e715099-8cfd-449b-a6b0-37467f68accc") },
                    { new Guid("d248a540-3462-4092-810f-4bec985fc25d"), "FeatPrerequisiteBinding", new Guid("43ae43aa-11d2-420f-bf17-6978f8a45a0f") },
                    { new Guid("ad836b29-2ab7-4e76-8979-65e3f895a534"), "FeatPrerequisiteBinding", new Guid("06f5008a-8b53-4c11-b0ec-2176e135d8b8") },
                    { new Guid("8d68493f-4f66-4ebb-aa54-c5fed2ae86b6"), "FeatPrerequisiteBinding", new Guid("d264d400-645f-4e7e-8100-ae5b2caf9e0e") },
                    { new Guid("1abf8f92-6500-471f-8a76-0890564bd71b"), "FeatPrerequisiteBinding", new Guid("3afb7bd6-f0c2-4187-9d47-f7a06d512fd3") },
                    { new Guid("63790dc9-79b8-48b9-91c3-351c3498de27"), "FeatPrerequisiteBinding", new Guid("2107ba8d-4766-4434-b23e-fe90d9837b02") },
                    { new Guid("ca583e97-25e0-48a9-a63e-c2409c37f4f7"), "FeatPrerequisiteBinding", new Guid("3bb4c8cd-9368-43dd-92b2-99174568570a") },
                    { new Guid("83519dcb-ddc3-4a7f-b404-b6822034a00e"), "FeatPrerequisiteBinding", new Guid("7aded813-2325-4a4d-aea7-077680584823") },
                    { new Guid("ab0d488c-fa87-4289-93f6-91df2166f822"), "FeatPrerequisiteBinding", new Guid("b5a95cad-67ab-4716-b582-4a11d8b863d1") },
                    { new Guid("e63447fc-7fdf-4723-be38-734253bb6e15"), "FeatPrerequisiteBinding", new Guid("d466988f-8d00-4230-ab88-5c963abbecd1") },
                    { new Guid("331e4a38-698f-4066-bd28-e42f80b1368d"), "FeatPrerequisiteBinding", new Guid("2b952cb7-5972-4866-a8d3-92410b2ed759") },
                    { new Guid("68ff9988-9cbf-493c-ac08-d3ede1bef387"), "FeatPrerequisiteBinding", new Guid("b1c71e21-bea7-453b-b23a-13ecc1b3675b") },
                    { new Guid("bcd03bec-9864-4a38-a752-4e59acd26dc2"), "FeatPrerequisiteBinding", new Guid("7ba0d3ef-7d44-42e4-8e2d-0b8bce8c9d16") },
                    { new Guid("7417ee71-aa5a-4d7e-89f4-a7c2f1fbb3f0"), "FeatPrerequisiteBinding", new Guid("7de0d323-fc78-4154-a4d0-91e8af5ef631") },
                    { new Guid("c5fb8477-fe1c-40d6-b030-38bd9e545309"), "FeatPrerequisiteBinding", new Guid("ec332db6-b06a-4a93-9935-756953f7a857") },
                    { new Guid("58a9af14-93bc-4de1-b290-645b961952a1"), "FeatPrerequisiteBinding", new Guid("2818e8e6-4d55-4f83-ad45-6decff2673c1") },
                    { new Guid("4d47f7e7-0e9c-41d8-8922-c2cb2cdc19cf"), "FeatPrerequisiteBinding", new Guid("67a42abf-7456-4bca-a74b-ef8d2fdc4459") },
                    { new Guid("48f78d64-fa2b-465d-83bb-b7b3d82d7709"), "FeatPrerequisiteBinding", new Guid("3539bdbe-8e7f-45c0-a094-649d85d3adca") },
                    { new Guid("38a9dc61-555e-48fb-a398-f72fcb139a55"), "FeatPrerequisiteBinding", new Guid("17232376-8797-4f5b-bee0-2614d6938d5a") },
                    { new Guid("5931bcf3-afbb-4d12-80ad-f47dc14ac075"), "FeatPrerequisiteBinding", new Guid("288c9224-1ffe-4acc-8343-ba9a40e76c38") },
                    { new Guid("878125cb-4413-4304-826e-2a6f9f1e1351"), "FeatPrerequisiteBinding", new Guid("064e540b-673f-4abb-bacc-fda48911b21a") },
                    { new Guid("063735a0-a7f9-4165-aa97-74c04557ae1f"), "FeatPrerequisiteBinding", new Guid("fee17526-90f5-401c-bdec-d084f40852a7") },
                    { new Guid("52574087-b011-4c5b-9fcb-6e22f11c6091"), "FeatPrerequisiteBinding", new Guid("dfb5e49e-df3e-443e-bfbf-d41e042306ed") },
                    { new Guid("3bf369c3-0238-4948-9eee-6c951a87ae80"), "FeatPrerequisiteBinding", new Guid("ce1dc7c1-c529-42a2-a2f5-f6ca99df1804") },
                    { new Guid("121e5838-bd62-46a7-a282-3e096dd7d271"), "FeatPrerequisiteBinding", new Guid("eb5ca078-b3f2-4e84-8df4-526ced138637") },
                    { new Guid("747c834b-3909-4dd3-8396-8e1c6353f873"), "FeatPrerequisiteBinding", new Guid("8ee11526-08b4-451e-8424-83704f0d1a70") },
                    { new Guid("d0dafb67-0f82-4c67-866f-75ab3b88580f"), "FeatPrerequisiteBinding", new Guid("76a68ae1-d7e0-4b2a-af54-4978b06db5cb") },
                    { new Guid("c999f2ff-0c41-4fa7-99fb-29c166253148"), "FeatPrerequisiteBinding", new Guid("b5d31ebb-d361-4780-93c5-324bfd3c39b8") },
                    { new Guid("80ac8e37-d1bd-4a89-857a-fdc581aa0547"), "FeatPrerequisiteBinding", new Guid("52456558-ce51-4f42-8ff2-fd4dbb72c25d") },
                    { new Guid("8954ba73-8dcd-4563-8ee4-ce46f9f24726"), "FeatPrerequisiteBinding", new Guid("d1d5b37b-2fcd-4699-892f-5c81cc437323") },
                    { new Guid("53cb716d-9671-4fe1-9c80-96d7dad779ca"), "FeatPrerequisiteBinding", new Guid("045ae2b1-ef9d-44a3-898d-8feb0832b94c") },
                    { new Guid("60e48bf0-f1a9-4020-be4d-3bff9e62499b"), "FeatPrerequisiteBinding", new Guid("30763d23-d261-4295-b636-f94bca378bec") },
                    { new Guid("f43e37fd-33cb-451e-89c2-a9e45e351308"), "FeatPrerequisiteBinding", new Guid("ad4fe73a-0518-46c1-bfee-130d1b2053ab") },
                    { new Guid("55c2a3ac-ec97-4882-b7a1-af9650b2b4d8"), "FeatPrerequisiteBinding", new Guid("73d6b44a-a2a6-4a70-be2c-2dd59c09657a") },
                    { new Guid("b3ffd080-e43c-477d-8906-54ac33624cff"), "FeatPrerequisiteBinding", new Guid("f725b35e-73bc-45b9-b5ee-6dfb225147b4") },
                    { new Guid("7026b01b-cf60-4cf1-a4c7-e10bed0e58f1"), "FeatPrerequisiteBinding", new Guid("f3cdc428-01a4-4687-8d48-8de530cbd154") },
                    { new Guid("bd212e0a-63fd-42fc-a012-3d56ceb4d822"), "FeatPrerequisiteBinding", new Guid("c041f814-94c4-43a1-be45-3bcd2621f2bb") },
                    { new Guid("b2b79e69-4c97-4b1d-a48d-6fde4da02465"), "FeatPrerequisiteBinding", new Guid("5803b272-2368-49ce-ba0b-8c97aa753885") },
                    { new Guid("4e7be145-127f-4a7c-a9a2-d178e1465cec"), "FeatPrerequisiteBinding", new Guid("12456924-12d6-4f6e-bde1-100892c683b5") },
                    { new Guid("ccfe054b-4194-4ba2-8bba-4f98b1ed0e4f"), "FeatPrerequisiteBinding", new Guid("12456924-12d6-4f6e-bde1-100892c683b5") },
                    { new Guid("526aa978-d5c8-4482-a522-73605e128b2c"), "FeatPrerequisiteBinding", new Guid("171b6ae6-cda9-45a7-8c0a-64672e338e0b") },
                    { new Guid("9e063be7-70e3-495c-a14b-42ccfeb7ba35"), "FeatPrerequisiteBinding", new Guid("ff4b4b20-73c2-4a67-a1a5-e504c8aa2dc6") },
                    { new Guid("fe2db99c-0cb7-491a-bf8c-edcf43c84c46"), "FeatPrerequisiteBinding", new Guid("ff4b4b20-73c2-4a67-a1a5-e504c8aa2dc6") },
                    { new Guid("fbc70e79-8d3d-4b12-9fe2-f60f7a3fe5f3"), "FeatPrerequisiteBinding", new Guid("9ee79ba9-47ac-4cf5-906d-9e88190e8d22") },
                    { new Guid("493d56f0-7760-44fd-948c-20bad99cdf33"), "FeatPrerequisiteBinding", new Guid("9ee79ba9-47ac-4cf5-906d-9e88190e8d22") },
                    { new Guid("f2d84378-ac58-4aa1-a32c-5dd948594b61"), "FeatPrerequisiteBinding", new Guid("8bfbc2e3-87d6-480d-8fd7-baeb77e465cd") },
                    { new Guid("bf1b0a30-16b8-401c-bc11-83ddb3de79a8"), "FeatPrerequisiteBinding", new Guid("1332e046-d8ea-4a33-9a07-69308317891c") },
                    { new Guid("388aa336-39bb-4172-afcf-ace1e855ee81"), "FeatPrerequisiteBinding", new Guid("a90aba98-98fe-4a4d-86a6-93025e5d558a") },
                    { new Guid("7478eed3-36c1-4a1d-a247-21badb079eec"), "FeatPrerequisiteBinding", new Guid("53bda5e8-f9d2-461f-9495-c9db35ab99c1") },
                    { new Guid("b7c2609b-e269-4df4-8aeb-2abf5fe06560"), "FeatPrerequisiteBinding", new Guid("3afb7bd6-f0c2-4187-9d47-f7a06d512fd3") },
                    { new Guid("620a99f0-9377-498b-a4cb-590441e62b51"), "FeatPrerequisiteBinding", new Guid("8dc95af1-d049-457f-91f8-311ead81336d") },
                    { new Guid("61cadcf1-7ecf-43fc-b421-523f0afa57f8"), "FeatPrerequisiteBinding", new Guid("f552a716-9e47-457c-a9ec-51fa8cd3a85d") },
                    { new Guid("05e666ea-feb4-4bf6-8d68-098d8435c5ae"), "FeatPrerequisiteBinding", new Guid("d1f81e6f-f97f-4bf3-8ddb-7db5ff7c351c") },
                    { new Guid("a153e8ba-11f0-417b-ae6d-52be52035560"), "FeatPrerequisiteBinding", new Guid("9415b689-43b4-4177-b861-32cab298b5fe") },
                    { new Guid("080c34b7-ec47-4f28-a240-e4beb705265f"), "FeatPrerequisiteBinding", new Guid("24bfd707-04bb-4464-a3ad-e1dd040c0377") },
                    { new Guid("ab631681-034a-4ea2-a0fd-b847e16c7f1d"), "FeatPrerequisiteBinding", new Guid("2a59396f-bf2a-4075-8207-3c906b7624ff") },
                    { new Guid("801e0541-1712-48b6-9d6a-a91a32a677e6"), "FeatPrerequisiteBinding", new Guid("89a41605-0006-4a7b-a101-f73d32f75a04") },
                    { new Guid("f89492d8-f55d-445c-85a8-cd34e13549ee"), "FeatPrerequisiteBinding", new Guid("064690bd-cd97-47a5-9e4c-fb8672bb6225") },
                    { new Guid("e8a334d7-c372-4879-a05b-bb51803deb56"), "FeatPrerequisiteBinding", new Guid("7e3b8e25-d2ad-400e-9b03-a4993d0e5f8b") },
                    { new Guid("3d77f183-bb10-436d-b664-bf54056b35fd"), "FeatPrerequisiteBinding", new Guid("7586b528-bef3-41be-b1f0-ea1fcb958c88") },
                    { new Guid("769a8ff4-92c8-4d6c-952c-1ec417c687a0"), "FeatPrerequisiteBinding", new Guid("8df39189-1886-4523-95b0-5980cad573f4") },
                    { new Guid("850cf013-7103-4c37-8bb9-b1a66c3fb583"), "FeatPrerequisiteBinding", new Guid("48c371fb-6e9c-4d4f-965d-d56694b52100") },
                    { new Guid("ba0d0a02-d876-441f-9226-f270c0ed0fab"), "FeatPrerequisiteBinding", new Guid("8a71ca0e-0c73-4fdd-bde7-431f3237bca6") },
                    { new Guid("8c0101c8-da77-49a0-b727-b56b58eafbcc"), "FeatPrerequisiteBinding", new Guid("eda136b0-c9e5-4b60-abd3-cc534c043a00") },
                    { new Guid("56bb7cdd-e5b9-4468-b29c-62dc359e7ee3"), "FeatPrerequisiteBinding", new Guid("c7443dbf-2f52-48df-a53c-8dd6ad6732c0") },
                    { new Guid("8f8b340d-5aad-41ac-a4f7-160fa57e0dff"), "FeatPrerequisiteBinding", new Guid("df3e0135-e1de-4b1f-a580-19f521c5f328") },
                    { new Guid("4e970e30-b49a-4f75-922f-fc222288a0e6"), "FeatPrerequisiteBinding", new Guid("37f7d759-3c83-491a-a516-b41b64cf57a7") }
                });

            migrationBuilder.InsertData(
                table: "ClassCharacteristic",
                columns: new[] { "Id", "ClassId", "Text" },
                values: new object[,]
                {
                    { new Guid("62e621eb-b0ee-4622-914f-a70b8e84dbfc"), new Guid("73f7051c-8eff-4337-a87c-183deb7a998c"), "Assume you’re a recluse who avoids society and cities and prefers to live in the wild." },
                    { new Guid("17d41939-22da-493c-a121-452a8f5dba1c"), new Guid("2483fb2b-b7cc-4eab-9c4e-0118477e46ed"), "Find the cascades of information you spout forth extremely helpful, if difficult to fully comprehend." },
                    { new Guid("f4ce7778-674f-4ac4-9c81-69956c1872af"), new Guid("2483fb2b-b7cc-4eab-9c4e-0118477e46ed"), "Get a bit annoyed that you’re such a know-it-all." },
                    { new Guid("ed7d4d66-8b4b-48a5-ab82-417677f36b9d"), new Guid("2483fb2b-b7cc-4eab-9c4e-0118477e46ed"), "Rely on you to solve mysteries, puzzles, or other challenges requiring intellectual curiosity and reasoning." },
                    { new Guid("01a10cfa-4e2b-4668-bc1c-939754abd9b4"), new Guid("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91"), "Marvel at your feats of physical prowess." },
                    { new Guid("16536a58-583e-454b-a549-c2a2f6496c11"), new Guid("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91"), "Come to you for philosophical advice." },
                    { new Guid("b08d6ce0-c333-4a87-9e45-3c3815ad24b7"), new Guid("df6b0137-7082-470f-939f-5d241ef7d651"), "Assume that if you haven’t caused a catastrophe with your experimentations, you inevitably will." },
                    { new Guid("2ac61aa9-12df-4c66-a4ab-191cb396d316"), new Guid("df6b0137-7082-470f-939f-5d241ef7d651"), "Don’t understand your zeal for alchemy, creativity, and invention." },
                    { new Guid("fb491a4e-9c96-4e57-8c71-38c0069feb5a"), new Guid("bc25beea-18e8-4417-8ada-a0f58bc79585"), "Don’t realize your spellcasting draws upon divine power and instead believe you command stranger—and possibly evil—powers." },
                    { new Guid("2e58f436-410b-44a4-b763-ff3b5a0b87df"), new Guid("bc25beea-18e8-4417-8ada-a0f58bc79585"), "Assume you performed some terrible transgression to become cursed by the gods." },
                    { new Guid("1d2ddb19-c3f5-46c9-81ce-5307e7f66fb4"), new Guid("df6b0137-7082-470f-939f-5d241ef7d651"), "Think you’re some kind of sorcerer or an eccentric wizard and don’t understand that you don’t cast spells; spellcasters who clumsily dabble in alchemy only heighten this misconception." },
                    { new Guid("7a73ed7d-74c3-432b-89f1-a73282c8bead"), new Guid("bc25beea-18e8-4417-8ada-a0f58bc79585"), "Admire your determination and the sacrifices you make to perform wondrous acts." },
                    { new Guid("97b80324-7529-4d87-86b2-bed2f01577d4"), new Guid("ceb15fca-8288-456e-9769-98cce79bb104"), "Call upon you to protect them from the wilds or the encroachment of civilization." },
                    { new Guid("4979afa1-38b9-45c1-a9a8-c64fd66912a9"), new Guid("ceb15fca-8288-456e-9769-98cce79bb104"), "Expect you to be a quiet or taciturn loner." },
                    { new Guid("56e1268b-2f13-47e6-95ca-5755e37ca9e7"), new Guid("ceb15fca-8288-456e-9769-98cce79bb104"), "Think there is something dangerous and wild about you." },
                    { new Guid("4184690e-d9de-4daa-959f-cd13811949a1"), new Guid("4087e406-d324-45af-b9b9-9adf0283a17c"), "Find you charming or fascinating, even if they think they know better than to trust you." },
                    { new Guid("5a54de41-6cf6-4bb4-a971-06f01270cf9e"), new Guid("4087e406-d324-45af-b9b9-9adf0283a17c"), "Come to you when they need someone who is willing to take risks or use questionable methods." },
                    { new Guid("8f67f4eb-f9d6-4c17-915f-950eb88ccccd"), new Guid("4087e406-d324-45af-b9b9-9adf0283a17c"), "Suspect you’re motivated primarily by greed." },
                    { new Guid("9266174a-c40c-4aa9-a834-44c58fde1056"), new Guid("05d42777-0744-4a72-85ad-d27186c96deb"), "Marvel at your ability to create magic from thin air and view your abilities with equal parts admiration and mistrust." },
                    { new Guid("3844b3a3-6ece-44f4-aa24-3da8c2a50ce1"), new Guid("05d42777-0744-4a72-85ad-d27186c96deb"), "Consider you less dedicated than studious wizards, devoted clerics, and other practitioners of magic, since power comes to you naturally." },
                    { new Guid("417aafb9-414d-44cd-834f-a41bd953f331"), new Guid("05d42777-0744-4a72-85ad-d27186c96deb"), "Assume you’re as unpredictable as the magic you bring forth, even if your personality proves otherwise." },
                    { new Guid("1c6d2032-af7f-4685-8eae-868aa5711e2e"), new Guid("deb62736-af71-4600-bd4b-59e55961b74d"), "Admire your theatrics, bravado, and skill with a blade." },
                    { new Guid("0b8205e3-3820-4e28-b3e1-e4ead143b5ce"), new Guid("deb62736-af71-4600-bd4b-59e55961b74d"), "Find you arrogant unless they know you well enough to appreciate your style." },
                    { new Guid("29f951f9-21c2-4063-bbaf-4c2b227cf204"), new Guid("deb62736-af71-4600-bd4b-59e55961b74d"), "Underestimate how much of a threat you pose until they face the end of your deadly blade." },
                    { new Guid("4fb1e29a-92c0-4d15-8963-fb39b9a39887"), new Guid("de966e73-2c40-40b4-956f-57e326f7ce8e"), "Consider you to be incredibly powerful and potentially dangerous." },
                    { new Guid("e0930221-ec07-49cd-b8a9-fa2392eeefb9"), new Guid("0e53c45a-9ab8-4d4a-bb5b-51af257c56bc"), "Assume you can easily solve all their problems, from dangerous weather to poor crop yields, and ask you for spells that can help them get whatever they desire." },
                    { new Guid("74db8994-017c-46d9-9e2c-fa40c541c477"), new Guid("0e53c45a-9ab8-4d4a-bb5b-51af257c56bc"), "Fear what your magic can do to their minds, bodies, and souls, and ask that you avoid casting spells in polite company, as few can identify whether one of your spells is harmless or malevolent until it’s too late." },
                    { new Guid("09921c78-f5c8-4fe2-a8bb-7f5ae4d33ec3"), new Guid("de966e73-2c40-40b4-956f-57e326f7ce8e"), "Fear what your magic can do to their minds, bodies, and souls, and ask that you avoid casting spells in polite company, as few can identify whether one of your spells is harmless or malevolent until it’s too late." },
                    { new Guid("8c20d58a-927d-4ea5-83c9-be47682cb32b"), new Guid("de966e73-2c40-40b4-956f-57e326f7ce8e"), "Assume you can easily solve all their problems, from dangerous weather to poor crop yields, and ask you for spells that can help them get whatever they desire." },
                    { new Guid("05ba17eb-b08a-4cf0-a4b8-2d98799f24ef"), new Guid("0e53c45a-9ab8-4d4a-bb5b-51af257c56bc"), "Consider you to be incredibly powerful and potentially dangerous." },
                    { new Guid("47d4e38b-f03a-4127-a673-243af7a327dc"), new Guid("a171edb5-59c0-4468-b710-a6b9df2f4497"), "Rely on your courage and your strength, and trust that you can hold your own in a fight." },
                    { new Guid("42556a95-e0e0-40b5-8a5d-e031fd221d8d"), new Guid("a171edb5-59c0-4468-b710-a6b9df2f4497"), "See you as uncivilized or a boorish lout unfit for high society." },
                    { new Guid("2d776caa-fcbf-420b-aed9-a56ee5c6a8aa"), new Guid("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91"), "Think you’re more than a bit uptight, given your vows and tenets." },
                    { new Guid("25bef97c-829a-416b-acb8-f35b60bc986f"), new Guid("9c08f598-a180-4a59-984a-a26a67607054"), "Underestimate you compared to other spellcasters, believing you are little more than a foppish minstrel and overlooking the subtle power of your magic." },
                    { new Guid("77e73740-36fc-4df3-8840-cfad8baae88e"), new Guid("9c08f598-a180-4a59-984a-a26a67607054"), "Respond favorably to your social charm and abilities, but remain suspicious of your beguiling magic." },
                    { new Guid("91bb3e45-7f52-441d-babc-b05303471515"), new Guid("a171edb5-59c0-4468-b710-a6b9df2f4497"), "Believe that you are loyal to your friends and allies and will never relent until the fight is done." },
                    { new Guid("2a801590-b596-4584-ac5a-1c65015ef184"), new Guid("73f7051c-8eff-4337-a87c-183deb7a998c"), "View you as a representative of nature, and are sure you can control it." },
                    { new Guid("cf449731-4015-418d-81b2-849947fd3199"), new Guid("9c08f598-a180-4a59-984a-a26a67607054"), "Relish the opportunity to invite you to social events, either as a performer or a guest, but consider you to be something of a curiosity in their social circles." },
                    { new Guid("82532d8e-b943-4aed-b14e-e3a302ade578"), new Guid("73f7051c-8eff-4337-a87c-183deb7a998c"), "Consider you a mystic, similar to a priest, but answering only to the forces of nature." },
                    { new Guid("34c4e6c1-937c-475e-ba53-bdfcdd4d6d0d"), new Guid("9cace213-82ff-4751-a438-8afd87d433e4"), "Find you intimidating until they get to know you, and maybe even after they get to know you." },
                    { new Guid("a2e4b7a8-09ed-47f3-8f09-3d87b28c56d4"), new Guid("f7cb4156-4ec7-4c78-bd28-4db83a0f5ade"), "Expect you to heal their wounds." },
                    { new Guid("8723a71e-24b5-49b5-8357-b36acc8a68ad"), new Guid("f7cb4156-4ec7-4c78-bd28-4db83a0f5ade"), "Find your devotion impressive, even if they don’t understand it." },
                    { new Guid("747f91ce-3349-4317-bc31-2ad6be7fa6c6"), new Guid("f7cb4156-4ec7-4c78-bd28-4db83a0f5ade"), "Rely on you to interact with other religious figures." },
                    { new Guid("3b024cdb-5520-43de-8e41-82659ad63dfb"), new Guid("3f3362c2-09a1-47da-8945-cea25e313f80"), "Know that you’ve sworn divine oaths of service they can trust you to keep." },
                    { new Guid("42ac891a-1c2f-4751-84cd-e0b8ee6c8140"), new Guid("3f3362c2-09a1-47da-8945-cea25e313f80"), "See you as a symbol of hope, especially in a time of great need." },
                    { new Guid("9030eece-2379-444d-b633-c9095ff74139"), new Guid("3f3362c2-09a1-47da-8945-cea25e313f80"), "Worry you secretly despise them for not living up to your impossible standard, or that you are unwilling to compromise when necessary." },
                    { new Guid("29d18b56-1b93-456b-9a0e-a0189bd86dbf"), new Guid("9cace213-82ff-4751-a438-8afd87d433e4"), "Respect your expertise in the art of warfare and value your opinion on the quality of armaments." },
                    { new Guid("fe9a7547-e4df-455a-a33c-00634db55fde"), new Guid("9cace213-82ff-4751-a438-8afd87d433e4"), "Expect you’re all brawn and no brains." }
                });

            migrationBuilder.InsertData(
                table: "ClassMannerism",
                columns: new[] { "Id", "ClassId", "Text" },
                values: new object[,]
                {
                    { new Guid("fde67e42-2e4a-4abc-9bb4-e84e70a4cc18"), new Guid("deb62736-af71-4600-bd4b-59e55961b74d"), "Hold yourself in high esteem, confident in your abilities and your reputation." },
                    { new Guid("5a4bfb01-6a81-4d56-b4a0-20b0d3caf405"), new Guid("3f3362c2-09a1-47da-8945-cea25e313f80"), "Believe there is always hope that good will triumph over evil, no matter how grim the odds." },
                    { new Guid("0a4f9595-7e77-468a-b87c-b99d8d3a76fc"), new Guid("9c08f598-a180-4a59-984a-a26a67607054"), "Have a passion for your art so strong that you forge a spiritual connection with it." },
                    { new Guid("75025372-a5b4-49f9-89e6-b46f146ca281"), new Guid("4087e406-d324-45af-b9b9-9adf0283a17c"), "Know where to attain illicit goods." },
                    { new Guid("7a5115d6-8a23-4616-83bc-a2ff379db0c2"), new Guid("4087e406-d324-45af-b9b9-9adf0283a17c"), "Skirt or break the law because you think it’s meaningless or have your own code." },
                    { new Guid("9bfdd4d6-3cb2-41c0-95ff-37bf69699243"), new Guid("9c08f598-a180-4a59-984a-a26a67607054"), "Take point when tact and nonviolent solutions are required." },
                    { new Guid("ebb75ed7-bfa4-40c5-8bb4-3f19794d2a70"), new Guid("f7cb4156-4ec7-4c78-bd28-4db83a0f5ade"), "Visit the temples and holy places sacred to your faith, and have an immediate affinity with other worshippers of your deity." },
                    { new Guid("8aa705e5-ec47-4553-a673-7bed0a7ae57f"), new Guid("9c08f598-a180-4a59-984a-a26a67607054"), "Follow your muse, whether it’s a mysterious fey creature, a philosophical concept, a psychic force, or a deity of art or music, and with its aid learn secret lore that few others have." },
                    { new Guid("e076f25a-3cf1-48f2-a7a5-83671f564522"), new Guid("05d42777-0744-4a72-85ad-d27186c96deb"), "Have a strong independent streak, and whether you embrace or reject your magical heritage, you long to distinguish yourself both as a spellcaster and as an individual." },
                    { new Guid("ca503052-4fc3-4997-ac3e-3c5f70a15ec3"), new Guid("05d42777-0744-4a72-85ad-d27186c96deb"), "View your lineage with fascination, fear, or something in between—anything from wholehearted acceptance to vehement rejection." },
                    { new Guid("8f31f877-c43f-493f-a6cb-9db65fba60cb"), new Guid("05d42777-0744-4a72-85ad-d27186c96deb"), "Rely on magic items, such as scrolls and wands, to supplement your limited selection of spells." },
                    { new Guid("1be1a716-5449-4961-893d-67e7a4e84269"), new Guid("f7cb4156-4ec7-4c78-bd28-4db83a0f5ade"), "Know the teachings of your religion’s holy texts and how they apply to a dilemma." },
                    { new Guid("5b4f9efb-8fe3-45a3-ab30-c5ea31fb37e3"), new Guid("3f3362c2-09a1-47da-8945-cea25e313f80"), "Know the ends don’t justify the means, since evil acts increase the power of evil." },
                    { new Guid("7752d7ec-e22e-4d95-b0eb-e41113a8a8a6"), new Guid("3f3362c2-09a1-47da-8945-cea25e313f80"), "Have a strong sense of right and wrong, and grow frustrated when greed or shortsightedness breeds evil." },
                    { new Guid("f4565e71-6154-49e4-b152-9e67df99750b"), new Guid("deb62736-af71-4600-bd4b-59e55961b74d"), "Portray yourself as a heroic daredevil or a roguish braggart, knowing you can live up to the image you present." },
                    { new Guid("d2983995-904d-4f96-a4ce-55abbefbd81b"), new Guid("deb62736-af71-4600-bd4b-59e55961b74d"), "Practice your skills and maneuvers regularly to ensure you never grow rusty." },
                    { new Guid("91551570-edd4-4240-8bea-cc80473f9e5b"), new Guid("ceb15fca-8288-456e-9769-98cce79bb104"), "Scout out ahead of the party, reconnoitering dangers before combat begins." },
                    { new Guid("e0e2f9fc-a9d3-4d41-be08-999ba0878101"), new Guid("9cace213-82ff-4751-a438-8afd87d433e4"), "Have little patience for puzzles or problems that require detailed logic or study." },
                    { new Guid("a6ef7d5a-5f11-4395-bf46-28966b389f03"), new Guid("ceb15fca-8288-456e-9769-98cce79bb104"), "Respect the raw power of nature and understand how to make the best of its bounty." },
                    { new Guid("0ddc24b5-5b32-433f-9468-1e07d0c05483"), new Guid("9cace213-82ff-4751-a438-8afd87d433e4"), "Recognize that the danger of an adventurer’s life must be balanced out with great revelry or ambitious works." },
                    { new Guid("c65bfa42-aaad-401e-a6ad-2fa61272635d"), new Guid("9cace213-82ff-4751-a438-8afd87d433e4"), "Know the purpose and quality of every weapon and piece of armor you own." },
                    { new Guid("c7197881-4e0a-4816-b64e-bf0bb2eaf5f5"), new Guid("a171edb5-59c0-4468-b710-a6b9df2f4497"), "Have a deep-seated well of anger, hatred, or frustration." },
                    { new Guid("ac5fd47c-1575-4a05-8850-bd323519a40a"), new Guid("2483fb2b-b7cc-4eab-9c4e-0118477e46ed"), "Start asking questions—including several that are quite involved—immediately after you’re presented with a conundrum." },
                    { new Guid("cf543469-df67-41eb-9738-90b0dd6cb22a"), new Guid("2483fb2b-b7cc-4eab-9c4e-0118477e46ed"), "Strive to uncover the deeper meanings behind anything you encounter and to identify the social machinations that truly drive events behind the scenes." },
                    { new Guid("6560d9a9-d4ed-4db1-aa66-9d58aba19a0b"), new Guid("df6b0137-7082-470f-939f-5d241ef7d651"), "Endlessly experiment to discover new, more potent alchemical tools." },
                    { new Guid("5382ffaa-7a1a-4b92-80e9-556a58c966eb"), new Guid("2483fb2b-b7cc-4eab-9c4e-0118477e46ed"), "Get so involved in a case that you ignore other matters, deeming them trivial." },
                    { new Guid("3553ea25-69b9-436e-a064-ed8fc9ea9b15"), new Guid("df6b0137-7082-470f-939f-5d241ef7d651"), "Get a kick out of wreaking havoc with the alchemical concoctions you’ve made, and enjoy watching things burn, dissolve, freeze, and jolt." },
                    { new Guid("9d16d728-b78b-47e8-adca-e6a8d75f2580"), new Guid("a171edb5-59c0-4468-b710-a6b9df2f4497"), "Prefer a straightforward approach to one requiring patience and tedium." },
                    { new Guid("c0b4b5d3-a43d-4fa0-9382-f361f2c307c5"), new Guid("de966e73-2c40-40b4-956f-57e326f7ce8e"), "Have an unquenchable intellectual curiosity about how everything in the world around you works—magic in particular." },
                    { new Guid("e4bd8f4d-0774-435c-8b5f-6e4dcc3d18a4"), new Guid("ceb15fca-8288-456e-9769-98cce79bb104"), "Enjoy the thrill of the hunt." },
                    { new Guid("f20c0e04-8d8a-42e0-b96f-1065ad387b86"), new Guid("df6b0137-7082-470f-939f-5d241ef7d651"), "Enjoy tinkering with strange formulas and alchemical reagents, often with a single - minded dedication and recklessness that gives others pause." },
                    { new Guid("3de123ba-e38d-417b-a229-f84b6effa669"), new Guid("a171edb5-59c0-4468-b710-a6b9df2f4497"), "Engage in a regimen of intense physical fitness—and punch anyone who says this conflicts with your distaste for patience and tedium." },
                    { new Guid("25352f03-9d39-46fe-af17-39417ec66512"), new Guid("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91"), "Face adversity with a calm and measured approach, never panicking or succumbing to despair." },
                    { new Guid("7e27c04c-ae5e-4a6e-b18a-fbdf61ed93e4"), new Guid("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91"), "Look to the future for ways you can improve, while remaining at peace with your present self." },
                    { new Guid("1d27448a-3fb0-47cb-b126-85f4a433fe9e"), new Guid("73f7051c-8eff-4337-a87c-183deb7a998c"), "Treat plants and animals as allies, working with them to reach your goals." },
                    { new Guid("22d2fbc4-04ce-4b41-b119-9459dd877a65"), new Guid("73f7051c-8eff-4337-a87c-183deb7a998c"), "Be in constant awe of the natural world, eager to share it with others but wary of their influence upon it." },
                    { new Guid("fdb38cc9-5b9e-45c3-ae43-660d5aaa3675"), new Guid("73f7051c-8eff-4337-a87c-183deb7a998c"), "Have a deep and meaningful respect for the power of nature." },
                    { new Guid("ccdda615-ea42-4aa1-9b39-4e69974a94a2"), new Guid("bc25beea-18e8-4417-8ada-a0f58bc79585"), "View your oracular powers as a blessing, a curse, or both." },
                    { new Guid("27b78d7c-dfea-4d9c-ab76-cf18b899afce"), new Guid("bc25beea-18e8-4417-8ada-a0f58bc79585"), "Push yourself to the limits of what you can withstand to work great acts of magic." },
                    { new Guid("03338b7c-68a3-4299-bcef-95f1a1439fb2"), new Guid("bc25beea-18e8-4417-8ada-a0f58bc79585"), "Rely on magical items to provide a pool of safer and more reliable magic." },
                    { new Guid("6a44f1c6-54c0-49ea-a3cc-8c61d3096138"), new Guid("f7cb4156-4ec7-4c78-bd28-4db83a0f5ade"), "Cooperate with your allies, provided they don’t ask you to go against divine will." },
                    { new Guid("cee3ea9b-e7cd-43ab-a2e0-1cfaa5abcc61"), new Guid("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91"), "Maintain a regimen of physical training and meditation." },
                    { new Guid("0496b73c-c75f-4ea3-a549-e76e18fca052"), new Guid("de966e73-2c40-40b4-956f-57e326f7ce8e"), "Believe fervently that your school of magic is superior (if you’re a specialist) or that true mastery of magic requires knowledge of all schools (if you’re a universalist)." },
                    { new Guid("2050d6a7-747d-4e76-8c0d-1ddc09b4ec53"), new Guid("4087e406-d324-45af-b9b9-9adf0283a17c"), "Hone your skills through intense practice, both on your own and out in the world." },
                    { new Guid("4ccd6d2e-c2e1-412d-9e11-982f22168293"), new Guid("0e53c45a-9ab8-4d4a-bb5b-51af257c56bc"), "Use esoteric jargon and technical terms to precisely describe the minutiae of magical effects, even though the difference is probably lost on other people." },
                    { new Guid("72df3174-ac1c-47b0-bb8c-ef962e743bc4"), new Guid("de966e73-2c40-40b4-956f-57e326f7ce8e"), "Use esoteric jargon and technical terms to precisely describe the minutiae of magical effects, even though the difference is probably lost on other people." },
                    { new Guid("e9e050bf-ac84-414e-84be-516165f99eb3"), new Guid("0e53c45a-9ab8-4d4a-bb5b-51af257c56bc"), "Have an unquenchable intellectual curiosity about how everything in the world around you works—magic in particular." },
                    { new Guid("7363708a-d989-4f1c-8366-a2f7715cbb64"), new Guid("0e53c45a-9ab8-4d4a-bb5b-51af257c56bc"), "Believe fervently that your school of magic is superior (if you’re a specialist) or that true mastery of magic requires knowledge of all schools(if you’re a universalist)." }
                });

            migrationBuilder.InsertData(
                table: "ClassStat",
                columns: new[] { "KeyAbilitiesId", "KeyAbilityClassesId" },
                values: new object[,]
                {
                    { new Guid("f4206177-80d3-4c9c-8f79-357a608897fa"), new Guid("9c08f598-a180-4a59-984a-a26a67607054") },
                    { new Guid("e9e25044-7005-48c7-81bc-372c8a9f829a"), new Guid("73f7051c-8eff-4337-a87c-183deb7a998c") },
                    { new Guid("f4206177-80d3-4c9c-8f79-357a608897fa"), new Guid("05d42777-0744-4a72-85ad-d27186c96deb") },
                    { new Guid("f4206177-80d3-4c9c-8f79-357a608897fa"), new Guid("4087e406-d324-45af-b9b9-9adf0283a17c") },
                    { new Guid("37406a59-0dd9-4766-8713-33b13b7740fd"), new Guid("4087e406-d324-45af-b9b9-9adf0283a17c") },
                    { new Guid("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137"), new Guid("4087e406-d324-45af-b9b9-9adf0283a17c") },
                    { new Guid("37406a59-0dd9-4766-8713-33b13b7740fd"), new Guid("9cace213-82ff-4751-a438-8afd87d433e4") },
                    { new Guid("21b2cca1-66cd-48d1-a91b-085521659548"), new Guid("ceb15fca-8288-456e-9769-98cce79bb104") },
                    { new Guid("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137"), new Guid("ceb15fca-8288-456e-9769-98cce79bb104") },
                    { new Guid("37406a59-0dd9-4766-8713-33b13b7740fd"), new Guid("df6b0137-7082-470f-939f-5d241ef7d651") },
                    { new Guid("37406a59-0dd9-4766-8713-33b13b7740fd"), new Guid("2483fb2b-b7cc-4eab-9c4e-0118477e46ed") },
                    { new Guid("f4206177-80d3-4c9c-8f79-357a608897fa"), new Guid("bc25beea-18e8-4417-8ada-a0f58bc79585") },
                    { new Guid("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137"), new Guid("a171edb5-59c0-4468-b710-a6b9df2f4497") },
                    { new Guid("21b2cca1-66cd-48d1-a91b-085521659548"), new Guid("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91") },
                    { new Guid("21b2cca1-66cd-48d1-a91b-085521659548"), new Guid("9cace213-82ff-4751-a438-8afd87d433e4") },
                    { new Guid("21b2cca1-66cd-48d1-a91b-085521659548"), new Guid("deb62736-af71-4600-bd4b-59e55961b74d") },
                    { new Guid("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137"), new Guid("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91") },
                    { new Guid("21b2cca1-66cd-48d1-a91b-085521659548"), new Guid("3f3362c2-09a1-47da-8945-cea25e313f80") },
                    { new Guid("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137"), new Guid("3f3362c2-09a1-47da-8945-cea25e313f80") },
                    { new Guid("e9e25044-7005-48c7-81bc-372c8a9f829a"), new Guid("f7cb4156-4ec7-4c78-bd28-4db83a0f5ade") },
                    { new Guid("37406a59-0dd9-4766-8713-33b13b7740fd"), new Guid("de966e73-2c40-40b4-956f-57e326f7ce8e") },
                    { new Guid("37406a59-0dd9-4766-8713-33b13b7740fd"), new Guid("0e53c45a-9ab8-4d4a-bb5b-51af257c56bc") }
                });

            migrationBuilder.InsertData(
                table: "DeityDivineFont",
                columns: new[] { "DeitiesId", "DivineFontsId" },
                values: new object[,]
                {
                    { new Guid("eda61d79-9877-483f-b660-bc282d270bb6"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1"), new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be") },
                    { new Guid("980a89b8-bd72-4434-a744-10cdc645cee6"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("196494f4-f104-45ad-8216-2c8bf68d3943"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("980a89b8-bd72-4434-a744-10cdc645cee6"), new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be") },
                    { new Guid("c624bf0e-d22c-4e01-8691-041083462102"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be") },
                    { new Guid("f5f38a92-1302-4d45-adf8-38452dde188b"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("21794a2c-45f8-404a-9ecb-8897571f6c15"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f"), new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be") },
                    { new Guid("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("eda61d79-9877-483f-b660-bc282d270bb6"), new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be") },
                    { new Guid("ac4c804a-c975-40f5-bdd2-7dcb97e9502d"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("21794a2c-45f8-404a-9ecb-8897571f6c15"), new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be") },
                    { new Guid("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be") },
                    { new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606"), new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be") },
                    { new Guid("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be") },
                    { new Guid("01777837-1255-4d6a-9301-96dc48fffee4"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be") },
                    { new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("3d200ca3-0e4a-4a64-a8a1-0ad34870590c"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") },
                    { new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), new Guid("f724073c-4395-4f57-91ff-21fca4f0a6be") },
                    { new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), new Guid("90698ae0-eb7f-49f2-b485-d7a1f9baf653") }
                });

            migrationBuilder.InsertData(
                table: "DeityDomain",
                columns: new[] { "DeitiesId", "DomainsId" },
                values: new object[,]
                {
                    { new Guid("980a89b8-bd72-4434-a744-10cdc645cee6"), new Guid("9c5f23af-1bf7-46c8-bdba-8067b03f752f") },
                    { new Guid("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), new Guid("3020bd98-a4f8-4e92-9c92-58110679137f") },
                    { new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f"), new Guid("e3128860-aa47-47ac-a090-8252e83cec96") },
                    { new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606"), new Guid("794329a6-ca37-4ec4-b3bf-e979c639d628") },
                    { new Guid("01777837-1255-4d6a-9301-96dc48fffee4"), new Guid("21481675-8a0d-4e7c-a373-fad64f4c14e7") },
                    { new Guid("f5f38a92-1302-4d45-adf8-38452dde188b"), new Guid("e3128860-aa47-47ac-a090-8252e83cec96") },
                    { new Guid("21794a2c-45f8-404a-9ecb-8897571f6c15"), new Guid("3eb1a047-7ae9-481b-a9ab-675684b2a67e") },
                    { new Guid("f5f38a92-1302-4d45-adf8-38452dde188b"), new Guid("9eafb500-89d8-46ff-b315-856f11aca152") },
                    { new Guid("f5f38a92-1302-4d45-adf8-38452dde188b"), new Guid("0b2dd6ec-60ae-4cab-ade5-b5bccdc8a993") },
                    { new Guid("196494f4-f104-45ad-8216-2c8bf68d3943"), new Guid("e41819f7-aa1b-416f-99c5-62bde7886a79") },
                    { new Guid("21794a2c-45f8-404a-9ecb-8897571f6c15"), new Guid("1fc1a8d3-cf3d-4e81-a1d5-f737a2e747f6") },
                    { new Guid("01777837-1255-4d6a-9301-96dc48fffee4"), new Guid("696cb38a-1f8f-4506-b3e6-06c5b5e802af") },
                    { new Guid("f5f38a92-1302-4d45-adf8-38452dde188b"), new Guid("4387ee8e-ad61-4d20-817a-deeebc8bb1da") },
                    { new Guid("f5f38a92-1302-4d45-adf8-38452dde188b"), new Guid("49ba8be3-a11f-4d61-9b64-d8d1fd208ffe") },
                    { new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f"), new Guid("433f01f4-387d-4cb7-b327-2b63bf21c16c") },
                    { new Guid("21794a2c-45f8-404a-9ecb-8897571f6c15"), new Guid("d09b4a1e-21fd-4dda-9fe6-8679bd6e3eef") },
                    { new Guid("980a89b8-bd72-4434-a744-10cdc645cee6"), new Guid("a434a214-22db-4d03-bd31-d2af7f4c4f76") },
                    { new Guid("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), new Guid("f1a372b7-a9bc-4571-b0ca-69780008e40a") },
                    { new Guid("3d200ca3-0e4a-4a64-a8a1-0ad34870590c"), new Guid("1fc1a8d3-cf3d-4e81-a1d5-f737a2e747f6") },
                    { new Guid("01777837-1255-4d6a-9301-96dc48fffee4"), new Guid("3b1c75b0-524c-4a08-b04b-9e66b69b42fc") },
                    { new Guid("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), new Guid("3c78a88a-9b78-4dc7-8f97-231a5788714e") },
                    { new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), new Guid("09797fbb-48b5-42fa-abf3-5468c06dbbce") },
                    { new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), new Guid("d09b4a1e-21fd-4dda-9fe6-8679bd6e3eef") },
                    { new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), new Guid("41f79fe2-6ac6-42ec-a69c-15046cd962f4") },
                    { new Guid("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), new Guid("ce60c9f8-e9a7-42e2-87e5-5d7e5210dbfa") },
                    { new Guid("01777837-1255-4d6a-9301-96dc48fffee4"), new Guid("c803d19e-6341-4d09-b96f-2926c23c6bcf") },
                    { new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), new Guid("4c7d189c-915f-4c09-b711-fa65a68a34d7") },
                    { new Guid("196494f4-f104-45ad-8216-2c8bf68d3943"), new Guid("8ab289e9-baf0-407e-80af-280774a66c15") },
                    { new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), new Guid("611f0345-55bd-4632-9bfc-b10a5cf64491") },
                    { new Guid("3d200ca3-0e4a-4a64-a8a1-0ad34870590c"), new Guid("3020bd98-a4f8-4e92-9c92-58110679137f") },
                    { new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), new Guid("1fc1a8d3-cf3d-4e81-a1d5-f737a2e747f6") },
                    { new Guid("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), new Guid("bc369149-d7c5-4319-b7d8-8137f9cfdcd8") },
                    { new Guid("3d200ca3-0e4a-4a64-a8a1-0ad34870590c"), new Guid("ef17f4d2-95cd-4561-86fc-487a749244e4") },
                    { new Guid("196494f4-f104-45ad-8216-2c8bf68d3943"), new Guid("09797fbb-48b5-42fa-abf3-5468c06dbbce") },
                    { new Guid("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), new Guid("ef17f4d2-95cd-4561-86fc-487a749244e4") },
                    { new Guid("3d200ca3-0e4a-4a64-a8a1-0ad34870590c"), new Guid("3eb1a047-7ae9-481b-a9ab-675684b2a67e") },
                    { new Guid("01777837-1255-4d6a-9301-96dc48fffee4"), new Guid("3658060d-b09b-4e73-b949-0255b77bd07b") },
                    { new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f"), new Guid("ce60c9f8-e9a7-42e2-87e5-5d7e5210dbfa") },
                    { new Guid("3d200ca3-0e4a-4a64-a8a1-0ad34870590c"), new Guid("833f560a-af75-49c8-8da6-d4e15a6a18a0") },
                    { new Guid("c624bf0e-d22c-4e01-8691-041083462102"), new Guid("f1a372b7-a9bc-4571-b0ca-69780008e40a") },
                    { new Guid("01777837-1255-4d6a-9301-96dc48fffee4"), new Guid("175bf44e-7909-46eb-b135-a7e97297d8df") },
                    { new Guid("c624bf0e-d22c-4e01-8691-041083462102"), new Guid("3b1c75b0-524c-4a08-b04b-9e66b69b42fc") },
                    { new Guid("196494f4-f104-45ad-8216-2c8bf68d3943"), new Guid("eceea1c6-3be5-49dd-bfb4-fca321132069") },
                    { new Guid("c624bf0e-d22c-4e01-8691-041083462102"), new Guid("4387ee8e-ad61-4d20-817a-deeebc8bb1da") },
                    { new Guid("c624bf0e-d22c-4e01-8691-041083462102"), new Guid("d3a39e59-080b-4324-8921-124763c5b6af") },
                    { new Guid("c624bf0e-d22c-4e01-8691-041083462102"), new Guid("833f560a-af75-49c8-8da6-d4e15a6a18a0") },
                    { new Guid("01777837-1255-4d6a-9301-96dc48fffee4"), new Guid("a434a214-22db-4d03-bd31-d2af7f4c4f76") },
                    { new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f"), new Guid("526ee5b8-2123-45ea-9711-123252645561") },
                    { new Guid("eda61d79-9877-483f-b660-bc282d270bb6"), new Guid("41f79fe2-6ac6-42ec-a69c-15046cd962f4") },
                    { new Guid("196494f4-f104-45ad-8216-2c8bf68d3943"), new Guid("1a434308-2ec6-4963-aa14-b82efa52fb98") },
                    { new Guid("980a89b8-bd72-4434-a744-10cdc645cee6"), new Guid("3eb1a047-7ae9-481b-a9ab-675684b2a67e") },
                    { new Guid("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), new Guid("9cc28967-eeee-4300-8723-a1fb61075bbc") },
                    { new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81"), new Guid("41f79fe2-6ac6-42ec-a69c-15046cd962f4") },
                    { new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606"), new Guid("ce60c9f8-e9a7-42e2-87e5-5d7e5210dbfa") },
                    { new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81"), new Guid("ef17f4d2-95cd-4561-86fc-487a749244e4") },
                    { new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1"), new Guid("d09b4a1e-21fd-4dda-9fe6-8679bd6e3eef") },
                    { new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1"), new Guid("526ee5b8-2123-45ea-9711-123252645561") },
                    { new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1"), new Guid("611f0345-55bd-4632-9bfc-b10a5cf64491") },
                    { new Guid("196494f4-f104-45ad-8216-2c8bf68d3943"), new Guid("ab621b51-801a-4e47-9581-c7fa211731b3") },
                    { new Guid("ac4c804a-c975-40f5-bdd2-7dcb97e9502d"), new Guid("768a6f8b-75cb-4439-a95a-1a41ef36abd8") },
                    { new Guid("ac4c804a-c975-40f5-bdd2-7dcb97e9502d"), new Guid("216d5607-4d52-4581-a669-06d0f2773b65") },
                    { new Guid("ac4c804a-c975-40f5-bdd2-7dcb97e9502d"), new Guid("7463725f-9db1-45ce-8bde-57857ab6a2f9") },
                    { new Guid("eda61d79-9877-483f-b660-bc282d270bb6"), new Guid("768a6f8b-75cb-4439-a95a-1a41ef36abd8") },
                    { new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), new Guid("611f0345-55bd-4632-9bfc-b10a5cf64491") },
                    { new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1"), new Guid("c750af99-1697-4c06-abb1-cb91bc2f8099") },
                    { new Guid("ac4c804a-c975-40f5-bdd2-7dcb97e9502d"), new Guid("3eb1a047-7ae9-481b-a9ab-675684b2a67e") },
                    { new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), new Guid("d09b4a1e-21fd-4dda-9fe6-8679bd6e3eef") },
                    { new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), new Guid("1a434308-2ec6-4963-aa14-b82efa52fb98") },
                    { new Guid("eda61d79-9877-483f-b660-bc282d270bb6"), new Guid("794329a6-ca37-4ec4-b3bf-e979c639d628") },
                    { new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), new Guid("bc369149-d7c5-4319-b7d8-8137f9cfdcd8") },
                    { new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), new Guid("a434a214-22db-4d03-bd31-d2af7f4c4f76") },
                    { new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), new Guid("da053ff5-4d67-4b00-bce6-19eb9a5f94bd") },
                    { new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), new Guid("9eadaa7c-bb04-4017-a31c-77a5355e0d2c") },
                    { new Guid("eda61d79-9877-483f-b660-bc282d270bb6"), new Guid("ef17f4d2-95cd-4561-86fc-487a749244e4") },
                    { new Guid("eda61d79-9877-483f-b660-bc282d270bb6"), new Guid("1a434308-2ec6-4963-aa14-b82efa52fb98") },
                    { new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), new Guid("e214011e-7af3-4a53-9b4a-e0ed7ae4479a") },
                    { new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), new Guid("62a8bd3c-1541-43a7-b1ab-5e4c0b63be84") },
                    { new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), new Guid("9eafb500-89d8-46ff-b315-856f11aca152") },
                    { new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), new Guid("87a70253-a298-467a-92e1-a3be315e34b0") },
                    { new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606"), new Guid("21481675-8a0d-4e7c-a373-fad64f4c14e7") },
                    { new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81"), new Guid("49ba8be3-a11f-4d61-9b64-d8d1fd208ffe") },
                    { new Guid("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), new Guid("ce60c9f8-e9a7-42e2-87e5-5d7e5210dbfa") },
                    { new Guid("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), new Guid("3eb1a047-7ae9-481b-a9ab-675684b2a67e") },
                    { new Guid("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0"), new Guid("0b2dd6ec-60ae-4cab-ade5-b5bccdc8a993") },
                    { new Guid("980a89b8-bd72-4434-a744-10cdc645cee6"), new Guid("8eb27986-a0a7-433c-90b0-fe992c088bfe") },
                    { new Guid("21794a2c-45f8-404a-9ecb-8897571f6c15"), new Guid("3020bd98-a4f8-4e92-9c92-58110679137f") },
                    { new Guid("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0"), new Guid("ef17f4d2-95cd-4561-86fc-487a749244e4") },
                    { new Guid("980a89b8-bd72-4434-a744-10cdc645cee6"), new Guid("833f560a-af75-49c8-8da6-d4e15a6a18a0") },
                    { new Guid("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0"), new Guid("41f79fe2-6ac6-42ec-a69c-15046cd962f4") },
                    { new Guid("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0"), new Guid("49ba8be3-a11f-4d61-9b64-d8d1fd208ffe") },
                    { new Guid("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0"), new Guid("9eafb500-89d8-46ff-b315-856f11aca152") },
                    { new Guid("980a89b8-bd72-4434-a744-10cdc645cee6"), new Guid("c803d19e-6341-4d09-b96f-2926c23c6bcf") },
                    { new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606"), new Guid("433f01f4-387d-4cb7-b327-2b63bf21c16c") },
                    { new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), new Guid("ab698922-2a43-4eb1-a400-2b96abcbb255") },
                    { new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), new Guid("7463725f-9db1-45ce-8bde-57857ab6a2f9") },
                    { new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81"), new Guid("ab621b51-801a-4e47-9581-c7fa211731b3") },
                    { new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), new Guid("3eb1a047-7ae9-481b-a9ab-675684b2a67e") },
                    { new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), new Guid("4c7d189c-915f-4c09-b711-fa65a68a34d7") },
                    { new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), new Guid("9eadaa7c-bb04-4017-a31c-77a5355e0d2c") },
                    { new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), new Guid("8e2fe9d1-c723-4754-8cb3-8955bb0094fc") },
                    { new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1"), new Guid("78d1b6a0-7f67-4e3c-a25c-dbf4aa4cd838") },
                    { new Guid("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), new Guid("49ba8be3-a11f-4d61-9b64-d8d1fd208ffe") },
                    { new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81"), new Guid("794329a6-ca37-4ec4-b3bf-e979c639d628") },
                    { new Guid("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), new Guid("9c5f23af-1bf7-46c8-bdba-8067b03f752f") }
                });

            migrationBuilder.InsertData(
                table: "DeityFollowerAlignments",
                columns: new[] { "Id", "AlignmentId", "DeityId" },
                values: new object[,]
                {
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0281f"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02816"), new Guid("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), new Guid("eda61d79-9877-483f-b660-bc282d270bb6") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02826"), new Guid("25f9299a-9a7c-40bc-b8bd-58588d19381b"), new Guid("21794a2c-45f8-404a-9ecb-8897571f6c15") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0281b"), new Guid("25f9299a-9a7c-40bc-b8bd-58588d19381b"), new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0281e"), new Guid("2ad80bbd-a735-4431-9e3a-f784e053b756"), new Guid("ac4c804a-c975-40f5-bdd2-7dcb97e9502d") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02822"), new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02825"), new Guid("2ad80bbd-a735-4431-9e3a-f784e053b756"), new Guid("21794a2c-45f8-404a-9ecb-8897571f6c15") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0281d"), new Guid("add12009-9c8a-4287-b02b-7e5b9459bf44"), new Guid("ac4c804a-c975-40f5-bdd2-7dcb97e9502d") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0283a"), new Guid("25f9299a-9a7c-40bc-b8bd-58588d19381b"), new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0281a"), new Guid("2ad80bbd-a735-4431-9e3a-f784e053b756"), new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0281c"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("ac4c804a-c975-40f5-bdd2-7dcb97e9502d") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02817"), new Guid("54f32060-3da3-4edf-b6dc-3839b8b7415d"), new Guid("eda61d79-9877-483f-b660-bc282d270bb6") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02815"), new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), new Guid("eda61d79-9877-483f-b660-bc282d270bb6") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02821"), new Guid("2ad80bbd-a735-4431-9e3a-f784e053b756"), new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02818"), new Guid("54f32060-3da3-4edf-b6dc-3839b8b7415d"), new Guid("3f66e9a6-fe24-4cdd-84de-91feb25e54ff") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02820"), new Guid("add12009-9c8a-4287-b02b-7e5b9459bf44"), new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02824"), new Guid("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02823"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02819"), new Guid("add12009-9c8a-4287-b02b-7e5b9459bf44"), new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02839"), new Guid("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02843"), new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), new Guid("f5f38a92-1302-4d45-adf8-38452dde188b") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0282c"), new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), new Guid("3d200ca3-0e4a-4a64-a8a1-0ad34870590c") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0284a"), new Guid("25f9299a-9a7c-40bc-b8bd-58588d19381b"), new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02841"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("c624bf0e-d22c-4e01-8691-041083462102") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02842"), new Guid("add12009-9c8a-4287-b02b-7e5b9459bf44"), new Guid("c624bf0e-d22c-4e01-8691-041083462102") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0282d"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("3d200ca3-0e4a-4a64-a8a1-0ad34870590c") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02830"), new Guid("54f32060-3da3-4edf-b6dc-3839b8b7415d"), new Guid("980a89b8-bd72-4434-a744-10cdc645cee6") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02831"), new Guid("25f9299a-9a7c-40bc-b8bd-58588d19381b"), new Guid("06a3a466-02b2-49d7-8c72-94c3e0fe7f50") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02844"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("f5f38a92-1302-4d45-adf8-38452dde188b") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02845"), new Guid("add12009-9c8a-4287-b02b-7e5b9459bf44"), new Guid("f5f38a92-1302-4d45-adf8-38452dde188b") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02832"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02846"), new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), new Guid("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0282f"), new Guid("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), new Guid("980a89b8-bd72-4434-a744-10cdc645cee6") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02849"), new Guid("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0282e"), new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), new Guid("980a89b8-bd72-4434-a744-10cdc645cee6") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02847"), new Guid("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), new Guid("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02833"), new Guid("2ad80bbd-a735-4431-9e3a-f784e053b756"), new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0284b"), new Guid("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02840"), new Guid("2006ffe6-8a03-4d40-99ac-935d814140ec"), new Guid("c624bf0e-d22c-4e01-8691-041083462102") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0283f"), new Guid("25f9299a-9a7c-40bc-b8bd-58588d19381b"), new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02827"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("196494f4-f104-45ad-8216-2c8bf68d3943") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0283b"), new Guid("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), new Guid("01777837-1255-4d6a-9301-96dc48fffee4") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02836"), new Guid("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02828"), new Guid("2ad80bbd-a735-4431-9e3a-f784e053b756"), new Guid("196494f4-f104-45ad-8216-2c8bf68d3943") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02835"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02829"), new Guid("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), new Guid("196494f4-f104-45ad-8216-2c8bf68d3943") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0283c"), new Guid("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), new Guid("01777837-1255-4d6a-9301-96dc48fffee4") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0284d"), new Guid("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0282a"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("196494f4-f104-45ad-8216-2c8bf68d3943") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02837"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02848"), new Guid("54f32060-3da3-4edf-b6dc-3839b8b7415d"), new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0283d"), new Guid("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), new Guid("01777837-1255-4d6a-9301-96dc48fffee4") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02838"), new Guid("54f32060-3da3-4edf-b6dc-3839b8b7415d"), new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0284c"), new Guid("54f32060-3da3-4edf-b6dc-3839b8b7415d"), new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0283e"), new Guid("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a02834"), new Guid("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08") },
                    { new Guid("2052eb18-4c69-45ae-aa91-b9b027a0282b"), new Guid("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), new Guid("196494f4-f104-45ad-8216-2c8bf68d3943") }
                });

            migrationBuilder.InsertData(
                table: "FeatDetailsBlock",
                columns: new[] { "Id", "FeatId", "Text" },
                values: new object[,]
                {
                    { new Guid("2c4b8bac-89f1-45f3-a60a-c6dfbbb00ea1"), new Guid("76a68ae1-d7e0-4b2a-af54-4978b06db5cb"), "You can use Wall Jump only once in a turn, unless you’re legendary in Athletics, in which case you can use Wall Jump as many times as you can use consecutive jump actions in that turn." },
                    { new Guid("32cdf8c4-ea19-43b2-8cf4-8b462fee385d"), new Guid("8df39189-1886-4523-95b0-5980cad573f4"), "You Recognize Spells swiftly. Once per round, you can Recognize a Spell using a skill in which you’re a master as a free action." },
                    { new Guid("605cae2e-9971-44ec-9fe2-9df99dd6fa87"), new Guid("8a71ca0e-0c73-4fdd-bde7-431f3237bca6"), "You Squeeze 5 feet per round (10 feet on a critical success). If you’re legendary in Acrobatics, you Squeeze at full Speed." },
                    { new Guid("8bae76df-a77a-4fb2-a16f-81864f06e55d"), new Guid("76a68ae1-d7e0-4b2a-af54-4978b06db5cb"), "You can use your momentum from a jump to propel yourself off a wall. If you’re adjacent to a wall at the end of a jump (whether performing a High Jump, Long Jump, or Leap), you don’t fall as long as your next action is another jump. Furthermore, since your previous jump gives you momentum, you can use High Jump or Long Jump as a single action, but you don’t get to Stride as part of the activity." },
                    { new Guid("79f8ff8b-a14d-4621-ab56-df66be388a38"), new Guid("48c371fb-6e9c-4d4f-965d-d56694b52100"), "You take 1 minute to Repair an item. If you’re a master in Crafting, it takes 3 actions. If you’re legendary, it takes 1 action." },
                    { new Guid("a23693cb-3840-48a8-94fb-7f93f6d118b6"), new Guid("b8193a38-a31c-45f2-a715-2542f09b97ca"), "You’re fully immersed in another ancestry’s culture and traditions, whether born into them, earned through rite of passage, or bonded through a deep friendship or romance. Choose a common ancestry. You can select ancestry feats from the ancestry you chose, in addition to your character’s own ancestry, as long as the ancestry feats don’t require any physiological feature that you lack, as determined by the GM." },
                    { new Guid("eedd663a-d431-476d-9125-5d45f19d4ec3"), new Guid("a1804dfb-e3e0-45aa-b735-2f37fed15779"), "You can Demoralize with a mere glare. When you do, Demoralize loses the auditory trait and gains the visual trait, and you don’t take a penalty if the creature doesn’t understand your language." },
                    { new Guid("e32321a9-80fd-4f59-939d-9a0dd3c98862"), new Guid("7586b528-bef3-41be-b1f0-ea1fcb958c88"), "You can use High Jump and Long Jump as a single action instead of 2 actions. If you do, you don’t perform the initial Stride (nor do you fail if you don’t Stride 10 feet)." },
                    { new Guid("485c9894-7bac-4b39-a277-004d316976ae"), new Guid("8b9edbcc-05ce-4df7-bc51-910ff6be643d"), "You become trained in all simple weapons. If you were already trained in all simple weapons, you become trained in all martial weapons. If you were already trained in all martial weapons, you become trained in one advanced weapon of your choice." },
                    { new Guid("497171c0-318e-4491-b527-ce421ee5ab7f"), new Guid("2a59396f-bf2a-4075-8207-3c906b7624ff"), "When Climbing, you move 5 more feet on a success and 10 more feet on a critical success, to a maximum of your Speed." },
                    { new Guid("3b09f3f6-9075-4013-9bd5-d674e3f00ffc"), new Guid("2a59396f-bf2a-4075-8207-3c906b7624ff"), "If you’re legendary in Athletics, you gain a climb Speed equal to your Speed." },
                    { new Guid("f3025adc-d289-42fc-b072-64fb3a523a45"), new Guid("ca8d59e8-f938-4ffb-9890-9bed87134d5b"), "You know basic facts off the top of your head. Choose a skill you’re an expert in that has the Recall Knowledge action and for which you have the Assurance feat. You can use the Recall Knowledge action with that skill as a free action once per round. If you do, you must use Assurance on the skill check." },
                    { new Guid("0f251d56-cfff-45a5-9133-ddda22b51196"), new Guid("0f49189c-434c-4490-8cbe-5235e6274441"), "In situations where you can physically menace the target when you Coerce or Demoralize, you gain a +1 circumstance bonus to your Intimidation check and you ignore the penalty for not sharing a language. If your Strength score is 20 or higher and you are a master in Intimidation, this bonus increases to +2." },
                    { new Guid("1ed675fc-6c30-4ded-a479-961f8bdd3227"), new Guid("e4c0f632-f086-40f7-81c4-2d54f1bcb5b9"), "Even in the worst circumstances, you can perform basic tasks. Choose a skill you’re trained in. You can forgo rolling a skill check for that skill to instead receive a result of 10 + your proficiency bonus (do not apply any other bonuses, penalties, or modifiers)." },
                    { new Guid("99c2075b-62d3-4927-8c61-c6d4f79d7fd9"), new Guid("89a41605-0006-4a7b-a101-f73d32f75a04"), "You can bully others with just a few choice implications. You can Coerce a creature after 1 round of conversation instead of 1 minute. You still can’t Coerce a creature in the midst of combat, or without engaging in a conversation." },
                    { new Guid("96d02376-bd63-4d35-92f0-08c08ca9f2ca"), new Guid("384659b6-1c1c-4612-9727-2d8406c2a328"), "You become trained in light armor. If you already were trained in light armor, you gain training in medium armor. If you were trained in both, you become trained in heavy armor." },
                    { new Guid("73719d8e-db64-463a-99f2-c30bc4c50bab"), new Guid("52456558-ce51-4f42-8ff2-fd4dbb72c25d"), "If you trigger a device or set off a trap while disarming it, you gain a +2 circumstance bonus to your AC or saving throw against the device or trap. This applies only to attacks or effects triggered by your failed attempt, not to any later ones, such as additional attacks from a complex trap." },
                    { new Guid("9ac62ad5-c1ab-46ae-8e36-403268396a6e"), new Guid("064690bd-cd97-47a5-9e4c-fb8672bb6225"), "You can set up a disguise in half the usual time (generally 5 minutes). If you’re a master, it takes one-tenth the usual time (usually 1 minute). If you’re legendary, you can create a full disguise and Impersonate as a 3-action activity." },
                    { new Guid("72e1ef9e-b124-40eb-b185-e1f6199d6c77"), new Guid("a6def9d1-3dd5-4d2f-8e75-1773753119d9"), "Your study of magic allows you to instinctively sense its presence. You can cast 1st-level detect magic at will as an arcane innate spell. If you’re a master in Arcana, the spell is heightened to 3rd level; if you’re legendary, it is heightened to 4th level." },
                    { new Guid("db6f1680-f693-4b5c-9dae-16516d0bd65a"), new Guid("1d6f005c-1b19-4072-8609-62af32b427e2"), "Whether through instinct, study, or magic, you feel a deeper connection to your ancestry.You gain a 1st - level ancestry feat." },
                    { new Guid("98b0a02f-62cf-4fd1-bfc1-674b17c90563"), new Guid("8ee11526-08b4-451e-8424-83704f0d1a70"), "You have exceptional talent with one type of performance. You gain a +1 circumstance bonus when making a certain type of performance. If you are a master in Performance, this bonus increases to +2. Select one of the following specialties and apply the bonus when attempting Performance checks of that type. If it’s unclear whether the specialty applies, the GM decides." },
                    { new Guid("5cdf024f-58b7-4b4b-9170-a8b758d94618"), new Guid("7e3b8e25-d2ad-400e-9b03-a4993d0e5f8b"), "You can Identify Magic swiftly. You take only 1 minute when using Identify Magic to determine the properties of an item, ongoing effect, or location, rather than 10 minutes. If you’re a master, it takes a 3-action activity, and if you’re legendary, it takes 1 action." },
                    { new Guid("8156a63f-dd8b-45e7-af35-fc4e6552a587"), new Guid("b5d31ebb-d361-4780-93c5-324bfd3c39b8"), "You’ve studied in large medical wards, treating several patients at once and tending to all their needs. When you use Treat Disease or Treat Wounds, you can treat up to two targets. If you’re a master in Medicine, you can treat up to four targets, and if you’re legendary, you can treat up to eight targets." },
                    { new Guid("447bc70f-fd26-40a6-8663-02d4ccb6c686"), new Guid("57442d19-cae2-465c-9d3d-2e77ecde2a50"), "Your knowledge has expanded to encompass a new field. Choose an additional Lore skill subcategory. You become trained in it. At 3rd, 7th, and 15th levels, you gain an additional skill increase you can apply only to the chosen Lore subcategory." },
                    { new Guid("08b12c02-c83f-43de-be5c-dd9ec87334cf"), new Guid("eda136b0-c9e5-4b60-abd3-cc534c043a00"), "You Swim 5 feet farther on a success and 10 feet farther on a critical success, to a maximum of your Speed. If you’re legendary in Athletics, you gain a swim Speed equal to your Speed." },
                    { new Guid("c53778be-16f6-4284-9f86-328a4191a823"), new Guid("ce1dc7c1-c529-42a2-a2f5-f6ca99df1804"), "You’ve started to make a meaningful connection about the common underpinnings of the four traditions of magic and magical essences, allowing you to understand them all through an arcane lens. Whenever you use a skill action or a skill feat that requires a Nature, Occultism, or Religion check, depending on the magic tradition, you can use Arcana instead. If you would normally take a penalty or have a higher DC for using Arcana on other magic (such as when using Identify Magic), you no longer do so." },
                    { new Guid("7e74f923-5877-4e70-b996-be37b21a8fbc"), new Guid("f3cdc428-01a4-4687-8d48-8de530cbd154"), "You can Pick a Lock using 1 action instead of 2." },
                    { new Guid("af6883b2-2994-4d9a-825e-0aaf92040d99"), new Guid("67a42abf-7456-4bca-a74b-ef8d2fdc4459"), "You can study details in the wilderness to determine the presence of nearby creatures. You can spend 10 minutes assessing the area around you to find out what creatures are nearby, based on nests, scat, and marks on vegetation. Attempt a Survival check against a DC determined by the GM based on how obvious the signs are. On a success, you can attempt a Recall Knowledge check with a –2 penalty to learn more about the creatures just from these signs. If you’re a master in Survival, you don’t take the penalty." },
                    { new Guid("4ebf2045-8b7f-4573-8f3b-af03c404638b"), new Guid("17232376-8797-4f5b-bee0-2614d6938d5a"), "Your experience in navigating a certain type of terrain makes you supremely confident while doing so. You gain a +1 circumstance bonus to Survival checks in one of the following types of terrain, chosen when you select this feat: aquatic, arctic, desert, forest, mountain, plains, sky, swamp, or underground." },
                    { new Guid("78f751ba-70e0-475e-89fc-d2f5f5006e43"), new Guid("2818e8e6-4d55-4f83-ad45-6decff2673c1"), "When you successfully Steal something, observers (creatures other than the creature you stole from) take a –2 circumstance penalty to their Perception DCs to detect your theft. Additionally, if you first Create a Diversion using Deception, taking a single Palm an Object or Steal action doesn’t end your undetected condition." },
                    { new Guid("9f681c15-5e28-4526-9a4c-aebaf2ec9179"), new Guid("ec332db6-b06a-4a93-9935-756953f7a857"), "You’ve researched many faiths enough to recognize notions about them that are unlikely to be true. If you roll a critical failure at a Religion check to Decipher Writing of a religious nature or to Recall Knowledge about the tenets of faiths, you get a failure instead. When attempting to Recall Knowledge about the tenets of your own faith, if you roll a failure, you get a success instead, and if you roll a success, you get a critical success instead." },
                    { new Guid("310c2c54-d5b7-408f-81c4-4465fcd9b9f2"), new Guid("288c9224-1ffe-4acc-8343-ba9a40e76c38"), "Select one type of difficult terrain from the following list: rubble, snow, or underbrush. While undetected by all non-allies in that type of terrain, you can Sneak without attempting a Stealth check as long as you move no more than 5 feet and do not move within 10 feet of an enemy at any point during your movement. This also allows you to automatically approach creatures to within 15 feet while Avoiding Notice during exploration as long as they aren’t actively Searching or on guard." },
                    { new Guid("b49e4a7d-a147-40c2-a552-b71770e29367"), new Guid("7de0d323-fc78-4154-a4d0-91e8af5ef631"), "You know about life on the streets and feel the pulse of your local settlement. You can use your Society modifier instead of your Diplomacy modifier to Gather Information. In any settlement you frequent regularly, you can use the Recall Knowledge action with Society to know the same sorts of information that you could discover with Diplomacy to Gather Information. The DC is usually significantly higher, but you know the information without spending time gathering it. If you fail to recall the information, you can still subsequently attempt to Gather Information normally." },
                    { new Guid("be009048-9abe-439f-97f1-d78289d9752c"), new Guid("7ba0d3ef-7d44-42e4-8e2d-0b8bce8c9d16"), "You can keep your balance easily, even in adverse conditions. Whenever you roll a success using the Balance action, you get a critical success instead. You’re not flat-footed while attempting to Balance on narrow surfaces and uneven ground. Thanks to your incredible balance, you can attempt an Acrobatics check instead of a Reflex save to Grab an Edge." },
                    { new Guid("d8f33acf-ba7f-4aec-a5e0-962dd317b1f8"), new Guid("064e540b-673f-4abb-bacc-fda48911b21a"), "When you critically succeed at the Demoralize action, if the target’s level is lower than yours, the target is fleeing for 1 round." },
                    { new Guid("3437ee0d-8348-4ee0-b08f-7cb793843223"), new Guid("b1c71e21-bea7-453b-b23a-13ecc1b3675b"), "If it’s unclear whether the specialty applies, the GM decides. Some specialties might apply only partially. For example, if you were making a morningstar and had specialty in woodworking, the GM might give you half your bonus because the item requires both blacksmithing and woodworking." },
                    { new Guid("19cd7955-cd5b-4133-8967-48d9f9379ef4"), new Guid("b1c71e21-bea7-453b-b23a-13ecc1b3675b"), "In situations where you can physically menace the target when you Coerce or Demoralize, you gain a +1 circumstance bonus to your Intimidation check and you ignore the penalty for not sharing a language. If your Strength score is 20 or higher and you are a master in Intimidation, this bonus increases to +2." },
                    { new Guid("ab3c5f8b-1cea-4981-b30d-fc1d811fc593"), new Guid("2b952cb7-5972-4866-a8d3-92410b2ed759"), "You can use the Craft activity to create snares, using the rules from page 244. When you select this feat, you add the formulas for four common snares to your formula book." },
                    { new Guid("0a652425-e8de-4a6d-83e8-523505d4f747"), new Guid("fee17526-90f5-401c-bdec-d084f40852a7"), "You can attempt to Disarm, Grapple, Shove, or Trip creatures up to two sizes larger than you, or up to three sizes larger than you if you’re legendary in Athletics." },
                    { new Guid("c2f95e6a-d3ee-41a3-b9c5-2ce52b87cb28"), new Guid("d466988f-8d00-4230-ab88-5c963abbecd1"), "You elude and evade attempts to uncover your true nature or intentions. When a spell or magical effect tries to read your mind, detect whether you are lying, or reveal your alignment, you can attempt a Deception check against the spell or effect’s DC. If you succeed, the effect reveals nothing." },
                    { new Guid("0edf9962-598d-4813-bdef-f310458b9ea6"), new Guid("b5a95cad-67ab-4716-b582-4a11d8b863d1"), "You become trained in the skill of your choice." },
                    { new Guid("76c25d32-da2f-4db2-af66-56b8b3542db9"), new Guid("5fec7506-9390-4455-83ed-fc3666ca4fa2"), "You can withstand more punishment than most before succumbing. Increase your maximum Hit Points by your level. You reduce the DC of recovery checks by 1 (page 459)." },
                    { new Guid("6f804bdb-e8ea-4b94-b8da-9dd428098588"), new Guid("7aded813-2325-4a4d-aea7-077680584823"), "Sign language is difficult to understand during combat due to the level of attention needed, unlike basic gestures like pointing at a foe to suggest a target. Sign language is hard to use in areas of low visibility, just like speech is difficult in a noisy environment." },
                    { new Guid("0f984b03-0710-45ec-b3d2-8b79b3bad4d1"), new Guid("7aded813-2325-4a4d-aea7-077680584823"), "You learn the sign languages associated with the languages you know, allowing you to sign and understand signs. Sign languages typically require both hands to convey more complex concepts, and they are visual rather than auditory." },
                    { new Guid("55213e09-5320-4baa-9324-35e22eb06496"), new Guid("dfb5e49e-df3e-443e-bfbf-d41e042306ed"), "You’ve learned to fight underwater. You are not flat-footed while in water, and you don’t take the usual penalties for using a bludgeoning or slashing melee weapon in water." },
                    { new Guid("2f35abd2-9e98-470e-a8a4-12ff83325793"), new Guid("3bb4c8cd-9368-43dd-92b2-99174568570a"), "You can downplay the consequences or outrageousness of your requests using sheer brazenness and charm. When you Request something, you reduce any DC increases for making an outrageous request by 2, and if you roll a critical failure for your Request, you get a failure instead. While this means you can never cause your target to reduce their attitude toward you by making a Request, they eventually tire of requests, even though they still have a positive attitude toward you." },
                    { new Guid("5b465363-62e4-41bb-a073-96f9423c8c4e"), new Guid("2107ba8d-4766-4434-b23e-fe90d9837b02"), "You learned folk medicine to help recover from diseases and poison, and using it diligently has made you especially resilient. When you Treat a Disease or a Poison, or someone else uses one of these actions on you, increase the circumstance bonus granted on a success to +4, and if the result of the patient’s saving throw is a success, the patient gets a critical success." },
                    { new Guid("46646590-2516-4adb-9ae5-7c050520e480"), new Guid("6684d89b-1994-4fa9-8b6b-c5123b642e86"), "You can Earn Income (page 236) using Diplomacy, spending your days hunting for bargains and reselling at a profit. You can also spend time specifically sniffing out a great bargain on an item; this works as if you were using Earn Income with Diplomacy, except instead of gaining money, you purchase the item at a discount equal to the money you would have gained, gaining the item for free if your earned income equals or exceeds its cost. Finally, if you select Bargain Hunter during character creation at 1st level, you start play with an additional 2 gp." },
                    { new Guid("5a2ebba7-943f-4b48-87e7-23a5bd5891a4"), new Guid("8ee83a83-4763-4423-87ff-c12ef752a494"), "When you Command an Animal you’re mounted on to take a move action (such as Stride), you automatically succeed instead of needing to attempt a check. Any animal you’re mounted on acts on your turn, like a minion. If you Mount an animal in the middle of an encounter, it skips its next turn and then acts on your next turn. Page 249 has more on Command an Animal." },
                    { new Guid("81d98c13-816a-41c5-9d33-476397d08dc7"), new Guid("219b84b9-cb31-44df-b37e-6bf4916e5dfb"), "If you activate a magic item that requires a spell attack roll or spell DC and you don’t have the ability to cast spells of the relevant tradition, use your level as your proficiency bonus and the highest of your Intelligence, Wisdom, or Charisma modifiers. If you’re a master in the appropriate skill for the item’s tradition, you instead use the trained proficiency bonus, and if you’re legendary, you instead use the expert proficiency bonus." },
                    { new Guid("fe9c688e-04a1-4e87-bfea-ad1d9224efd5"), new Guid("ad4fe73a-0518-46c1-bfee-130d1b2053ab"), "You can read lips of others nearby who you can clearly see. When you’re at your leisure, you can do this automatically. In encounter mode or when attempting a more difficult feat of lipreading, you’re fascinated and flat-footed during each round in which you focus on lip movements, and you must succeed at a Society check (DC determined by the GM) to successfully read someone’s lips. In either case, the language read must be one that you know." },
                    { new Guid("600a8c6c-ad12-4e0c-b656-70f740cce02e"), new Guid("73d6b44a-a2a6-4a70-be2c-2dd59c09657a"), "You easily pull yourself onto ledges. When you Grab an Edge, you can pull yourself onto that surface and stand. You can use Athletics instead of a Reflex save to Grab an Edge." },
                    { new Guid("95e082e4-1262-4fa5-8937-a0bf794053eb"), new Guid("eb5ca078-b3f2-4e84-8df4-526ced138637"), "You never get information about your areas of expertise wrong. When you Recall Knowledge using any Lore subcategory in which you’re trained, if you roll a critical failure, you get a failure instead. If you’re a master in a Lore subcategory, on a critical success, you gain even more information or context than usual." },
                    { new Guid("755917de-c9d7-4d39-a1ea-9e6c72ab7885"), new Guid("f725b35e-73bc-45b9-b5ee-6dfb225147b4"), "You’re skilled at moving with a group. When you are Avoiding Notice and your allies Follow the Expert, you and those allies can roll a single Stealth check, using the lowest modifier, instead of rolling separately. This doesn’t apply for initiative rolls." },
                    { new Guid("eb92aacb-50c4-49d2-8ed0-71860ad8582e"), new Guid("9648e97f-800c-492f-9277-93a17174bab1"), "You’ve learned how to handle situations when you’re out of your depth. Your proficiency bonus to untrained skill checks is equal to half your level instead of +0. If you’re 7th level or higher, the bonus increases to your full level instead. This doesn’t allow you to use the skill’s trained actions." },
                    { new Guid("6cd9c0c0-51e4-4c37-96d7-a7c861812b8e"), new Guid("219b84b9-cb31-44df-b37e-6bf4916e5dfb"), "Attempt a check using the skill matching the item’s magic tradition, or matching a tradition that has the spell on its list, if you’re trying to cast a spell from the item. The relevant skills are Arcana for arcane, Nature for primal, Occultism for occult, Religion for divine, or any of the four for an item that has the magical trait and not a tradition trait. The GM determines the DC based on the item’s level (possibly adjusted depending on the item or situation)." },
                    { new Guid("8c4e02b6-3966-491d-a8e8-aa05e8f6c0cb"), new Guid("2c8b47a4-eb56-491b-82fd-a3f894282025"), "Your knowledge has expanded to encompass a new field. Choose an additional Lore skill subcategory. You become trained in it. At 3rd, 7th, and 15th levels, you gain an additional skill increase you can apply only to the chosen Lore subcategory." },
                    { new Guid("1fe89bb7-ca01-4a5f-9d34-8699b45c9829"), new Guid("5ac7371e-af01-460e-a188-198481c67505"), "When you roll initiative, you can yell a mighty battle cry and Demoralize an observed foe as a free action. If you’re legendary in Intimidation, you can use a reaction to Demoralize your foe when you critically succeed at an attack roll." },
                    { new Guid("d0dfc3c2-425e-4551-9964-bbdf182c468b"), new Guid("3539bdbe-8e7f-45c0-a094-649d85d3adca"), "You can move your full Speed when you Sneak. You can use Swift Sneak while Burrowing, Climbing, Flying, or Swimming instead of Striding if you have the corresponding movement type." },
                    { new Guid("11d84471-94ee-4c1e-a67e-07c3ad92966e"), new Guid("219b84b9-cb31-44df-b37e-6bf4916e5dfb"), "You examine a magic item you normally couldn’t use in an effort to fool it and activate it temporarily. For example, this might allow a fighter to cast a spell from a wand or allow a wizard to cast a spell that’s not on the arcane list using a scroll. You must know what activating the item does, or you can’t attempt to trick it." },
                    { new Guid("0589bdf3-abf3-4850-a9fe-5f8454150417"), new Guid("d76bcd62-20d9-4fce-9fc1-735ec21a0cb2"), "If you’re an expert in Performance, you can fascinate up to four observers; if you’re a master, you can fascinate up to 10 observers; and if you’re legendary, you can fascinate any number of observers at the same time." },
                    { new Guid("30714efb-c8ad-4874-a32a-a5361cbe1924"), new Guid("12456924-12d6-4f6e-bde1-100892c683b5"), "Your fame has spread throughout the lands. NPCs who succeed at a DC 10 Society check to Recall Knowledge have heard of you and usually have an attitude toward you one step better than normal, depending on your reputation and the NPC’s disposition. For instance, if you’re well-known for cruel and demanding behavior, creatures might be intimidated by you, rather than be friendly toward you. When you Earn Income with Performance, you attract higher-level audiences than your location would allow, as audiences flock to see you. For instance, rulers and angels might travel to your small tower in the woods to hear you perform. Typically, this increases the audiences available by 2 levels or more, determined by the GM." },
                    { new Guid("b95929b6-0cf7-4eb3-aa95-fa8f2f2c9ca0"), new Guid("d76bcd62-20d9-4fce-9fc1-735ec21a0cb2"), "When you Perform, compare your result to the Will DC of one observer. If you succeed, the target is fascinated by you for 1 round. If the observer is in a situation that demands immediate attention, such as combat, you must critically succeed to fascinate it and the Perform action gains the incapacitation trait. You must choose which creature you’re trying to fascinate before you roll your check, and the target is then temporarily immune for 1 hour." },
                    { new Guid("1c266490-9c64-4913-a6bf-5b9ff4d37a9c"), new Guid("a64ac93e-e7c5-46d1-85ec-72d93d5dcf7a"), "Tracking is second nature to you, and when necessary you can follow a trail without pause. You can Track while moving at full Speed by taking a –5 penalty to your Survival check. If you’re a master in Survival, you don’t take the –5 penalty. If you’re legendary in Survival, you no longer need to roll a new Survival check every hour when tracking, though you still need to roll whenever there are significant changes in the trail." },
                    { new Guid("0b11531a-68c6-4cd9-a7f9-e4f3494f4ab3"), new Guid("fa30f639-b913-4050-b7bc-a8e9991178f1"), "You often smuggle things past the authorities. When the GM rolls your Stealth check to see if a passive observer notices a small item you have concealed, the GM uses the number rolled or 10—whichever is higher—as the result of your die roll, adding it to your Stealth modifier to determine your Stealth check result. If you’re a master in Stealth, the GM uses the number rolled or 15, and if you’re legendary in Stealth, you automatically succeed at hiding a small concealed item from passive observers. This provides no benefits when a creature attempts a Perception check while actively searching you for hidden items. Due to your smuggling skill, you’re more likely to find more lucrative smuggling jobs when using Underworld Lore to Earn Income" },
                    { new Guid("5ca60765-3953-40b6-8d4a-0532b2e4c80d"), new Guid("0e715099-8cfd-449b-a6b0-37467f68accc"), "You carefully safeguard your professional endeavors to prevent disaster. When you use Lore to Earn Income, if you roll a critical failure, you instead get a failure. If you’re an expert in Lore, you gain twice as much income from a failed check to Earn Income, unless it was originally a critical failure." },
                    { new Guid("b1851b98-e05d-4c7a-bed7-90b4e44ddc0a"), new Guid("171b6ae6-cda9-45a7-8c0a-64672e338e0b"), "Your fame has spread throughout the lands (for instance, if you have Warfare Lore, you might be a legendary general or tactician). This works as Legendary Performer above, except you gain higher-level jobs when you Earn Income with Lore." },
                    { new Guid("fd638442-dba6-4c64-a978-6076c474ffa1"), new Guid("dbd06473-8700-438f-b4e1-35474b87171c"), "You have a system that lets you search at great speed, finding details and secrets twice as quickly as others can. When Searching, you take half as long as usual to Search a given area. This means that while exploring, you double the Speed you can move while ensuring you’ve Searched an area before walking into it (up to half your Speed). If you’re legendary in Perception, you instead Search areas four times as quickly." },
                    { new Guid("28d7b87a-55a3-48f3-9071-ab3e1600f129"), new Guid("fffc0274-b5cd-428f-8144-a7d8b01f5986"), "You’re a treasure trove of information, but not all of it comes from reputable sources. When you fail (but don’t critically fail) a Recall Knowledge check using any skill, you learn a bit of true knowledge and a bit of erroneous knowledge, but you don’t have any way to differentiate which is which." },
                    { new Guid("538628da-6b39-455a-919a-7b2d8de5ff61"), new Guid("17f35e0f-3778-4143-b516-d08faf79bc68"), "You’re so immersed in divine scripture that you find meaning and guidance in your texts in any situation. Spend 10 minutes Deciphering Writing on religious scriptures of your deity or philosophy while thinking about a particular problem or conundrum you face, and then attempt a Religion check (DC determined by the GM). If you succeed, you unearth a relevant passage, parable, or aphorism that can help you move forward or change your thinking to help solve your conundrum. For example, the GM might provide you with a cryptic poem or hint that can guide you to the next step of solving your problem." },
                    { new Guid("4e989ca3-733a-4120-aa84-aaba3aa053f8"), new Guid("ff4b4b20-73c2-4a67-a1a5-e504c8aa2dc6"), "You’re always sneaking unless you choose to be seen, even when there’s nowhere to hide. You can Hide and Sneak even without cover or being concealed. When you employ an exploration tactic other than Avoiding Notice, you also gain the benefits of Avoiding Notice unless you choose not to. See page 479 for more information about exploration tactics." },
                    { new Guid("49a1d867-7420-4c1d-9c70-3b36f83adf22"), new Guid("15ccc079-da12-4678-8b48-f626e51418df"), "It takes more to kill you than most. You die from the dying condition at dying 5, rather than dying 4." },
                    { new Guid("c729dd0c-a2bf-44f0-9d2a-7ff744c09b26"), new Guid("2fbc54de-6f02-49d5-a01c-6adfd732a81e"), "You can find ways to craft just about anything, despite restrictions. As long as you have the appropriate Crafting skill feat (such as Magical Crafting for magic items) and meet the item’s level and proficiency requirement, you ignore just about any other requirement, such as being of a specific ancestry or providing spells. The only exceptions are requirements that add to the item’s cost, including castings of spells that themselves have a cost, and requirements of special items such as the philosopher’s stone that have exclusive means of access and Crafting. The GM decides whether you can ignore a requirement." },
                    { new Guid("308d6b71-ee1c-4e7b-b3b5-1ef198b64205"), new Guid("d264d400-645f-4e7e-8100-ae5b2caf9e0e"), "You can survive indefinitely without food or water and can endure severe, extreme, and incredible cold and heat without taking damage from doing so." },
                    { new Guid("38b5844d-0409-48fd-ab87-07bbe0e02f68"), new Guid("5c26de36-847d-4a16-8871-0a2016fdfacc"), "You were raised among the nobility or have learned proper etiquette and bearing, allowing you to present yourself as a noble and play games of influence and politics. You can use Society to Make an Impression on a noble, as well as with Impersonate to pretend to be a noble if you aren’t one. If you want to impersonate a specific noble, you still need to use Deception to Impersonate normally, and to Lie when necessary." },
                    { new Guid("c30bef55-a24b-4a39-99ef-0e0bd895355a"), new Guid("24bfd707-04bb-4464-a3ad-e1dd040c0377"), "When you Leap, you can jump 5 feet up with a vertical Leap, and you increase the distance you can jump horizontally by 5 feet." },
                    { new Guid("ffef847d-bf3b-4b80-9e63-3a2d6714deea"), new Guid("059f1e6a-f8cd-4be2-8024-ddc21dd7cd60"), "You zealously monitor a patient’s progress to administer treatment faster. When you Treat Wounds, your patient becomes immune for only 10 minutes instead of 1 hour. This applies only to your Treat Wounds activities, not any other the patient receives." },
                    { new Guid("8327dfe8-9bc4-40ab-8459-51ce05d11517"), new Guid("a38f19f2-3b2d-4907-8425-d71dc351e8df"), "You have social connections you can leverage to trade favors or meet important people. When you’re in an area with connections (typically a settlement where you’ve spent downtime building connections, or possibly another area in the same nation), you can attempt a Society check to arrange a meeting with an important political figure or ask for a favor in exchange for a later favor of your contact’s choice. The GM decides the DC based on the difficulty of the favor and the figure’s prominence." },
                    { new Guid("aa2b2d06-a965-4e6a-ba72-099e3d2b4def"), new Guid("30763d23-d261-4295-b636-f94bca378bec"), "If you are trained in the appropriate skill for the spell’s tradition and it’s a common spell of 2nd level or lower, you automatically identify it (you still roll to attempt to get a critical success, but can’t get a worse result than success). The highest level of spell you automatically identify increases to 4 if you’re an expert, 6 if you’re a master, and 10 if you’re legendary. The GM rolls a secret Arcana, Nature, Occultism, or Religion check, whichever corresponds to the tradition of the spell being cast. If you’re not trained in the skill, you can’t get a result better than failure." },
                    { new Guid("f95849f0-3bba-430f-b44a-6828c1fbdbe9"), new Guid("68a98dbf-4a45-4217-a94f-2d0969915d96"), "Your body quickly bounces back from afflictions. You regain twice as many Hit Points from resting. Each time you succeed at a Fortitude save against an ongoing disease or poison, you reduce its stage by 2, or by 1 against a virulent disease or poison. Each critical success you achieve against an ongoing disease or poison reduces its stage by 3, or by 2 against a virulent disease or poison. In addition, you reduce the severity of your drained condition by 2 when you rest for a night instead of by 1." },
                    { new Guid("c479e6b3-e61e-4e45-8b4e-7375df616325"), new Guid("8bfbc2e3-87d6-480d-8fd7-baeb77e465cd"), "When you critically succeed to Create a Diversion, you continue to remain hidden after the end of your turn. This effect lasts for an amount of time that depends on the diversion and situation, as determined by the GM (minimum 1 additional round)." },
                    { new Guid("6a59de26-a216-4f4f-b81f-094eb8998249"), new Guid("174c21f8-b29a-4141-9070-eca5ecfdee71"), "You step carefully and quickly. You can Step into difficult terrain." },
                    { new Guid("7b4e22c3-cf7d-4ab3-9d47-3bca57cd7ed6"), new Guid("37e3bc29-be7b-4112-92aa-0b7dddbc2da3"), "You move more quickly on foot. Your Speed increases by 5 feet." },
                    { new Guid("7be3eec5-5c9b-4f76-b412-3bec0c802dd6"), new Guid("9b475bb4-2086-4f81-b4ab-ef3f8f09f5db"), "You have an incredible ability to invest more magic items. Increase your limit on invested items from 10 to 12." },
                    { new Guid("23d9c608-82be-4500-8430-ece2f345a971"), new Guid("c8dd98a8-e102-4751-9606-88ed457bfdeb"), "You are a genius at Crafting, easily able to determine how things are made and create new inventions. You can spend downtime to invent a common formula that you don’t know. This works just like the Craft activity: you spend half the Price of the formula up front, attempt a Crafting check, and on a success either finish the formula by paying the difference or work for longer to decrease the Price. The difference is that you spend the additional time in research, design, and development, rather than in creating an item. Once it’s complete, you add the new formula you invented to your formula book." },
                    { new Guid("180ac1bb-e6ae-4d53-b33a-71978026a8e5"), new Guid("6f87700e-7194-47d6-a9b2-20e0e2e53482"), "Your performances inspire admiration and win you fans. You can Make an Impression using Performance instead of Diplomacy." },
                    { new Guid("e0ff07c3-5e1e-4258-8e85-c1255b47705e"), new Guid("4f6b0041-df64-4d81-9ddd-baebcfdd28ed"), "You stand up. This movement doesn’t trigger reactions." },
                    { new Guid("44cfef57-7ea2-4289-bab1-9721399c2190"), new Guid("3d690c93-0e1b-42c8-9d62-4e4219729dec"), "You react more quickly than others can. You gain a +2 circumstance bonus to initiative rolls." },
                    { new Guid("f1ce54f4-d426-4acf-bda9-645a50a04a01"), new Guid("37f7d759-3c83-491a-a516-b41b64cf57a7"), "When you successfully Coerce someone, the maximum time they comply increases to a week, still determined by the GM. If you’re legendary, the maximum increases to a month." },
                    { new Guid("6b5087c0-7e76-445c-966e-7a50f572448f"), new Guid("89921651-065e-48f8-98cb-c9b6cf6c71e9"), "You craft flawless creations with great efficiency. Whenever you roll a success at a Crafting check to make an item of the type you chose with Specialty Crafting, you get a critical success instead." },
                    { new Guid("550d9521-8aa7-45c5-85f0-0d3871077f8d"), new Guid("43f75824-0d49-466f-aa58-e40046c4a6d4"), "You are skilled at learning information through conversation. The Gather Information exploration activity takes you half as long as normal (typically reducing the time to 1 hour). If you’re a master in Diplomacy and you Gather Information at the normal speed, when you attempt to do so and roll a critical failure, you get a failure instead. There is still no guarantee that a rumor you learn with Gather Information is accurate." },
                    { new Guid("b916a391-2032-4ec4-b914-f40d36019fa8"), new Guid("18e0c385-d2ba-4646-989d-2e49d43d5f36"), "You can carry more than your frame implies. Increase your maximum and encumbered Bulk limits by 2." },
                    { new Guid("c92cea06-9c7d-43a4-906d-e532765fd3f2"), new Guid("06f5008a-8b53-4c11-b0ec-2176e135d8b8"), "Your skill with languages and codes is so great that you can decipher information with little more than a quick read through a text. You can Decipher Writing using Society while reading at normal speed. If you slow down and spend the full amount of time that’s ordinarily required and roll a success, you get a critical success; if you critically succeed while spending the normal amount of time, you gain a nearly word-for-word understanding of the document." },
                    { new Guid("7dd54aeb-9180-4509-ac60-9d9f31b4d9c9"), new Guid("738f86de-6f73-4ffa-a790-abd8feeb43c5"), "When you Make an Impression, you can compare your Diplomacy check result to the Will DCs of two targets instead of one. It’s possible to get a different degree of success for each target. The number of targets increases to four if you’re an expert, 10 if you’re a master, and 25 if you’re legendary." },
                    { new Guid("0482965b-932e-407e-a445-337a78cb3eca"), new Guid("ccdd4b23-9813-407e-a7a6-8bc2cdafbab5"), "When you Coerce, you can compare your Intimidation check result to the Will DCs of two targets instead of one. It’s possible to get a different degree of success for each target. The number of targets you can Coerce in a single action increases to four if you’re an expert, 10 if you’re a master, and 25 if you’re legendary." },
                    { new Guid("d0c298c6-63be-431c-80e9-5a95ec712f73"), new Guid("6f59e2f4-2100-436d-8cf8-266585faa937"), "First impressions are your strong suit. When you meet someone in a casual or social situation, you can immediately attempt a Diplomacy check to Make an Impression on that creature rather than needing to converse for 1 minute. You take a –5 penalty to the check. If you fail or critically fail, you can engage in 1 minute of conversation and attempt a new check at the end of that time rather than accepting the failure or critical failure result." },
                    { new Guid("6156f6a0-8ca3-4260-aa1c-8842c9a6d780"), new Guid("3afb7bd6-f0c2-4187-9d47-f7a06d512fd3"), "You’re so skilled with languages you can create a pidgin instantly. You can always talk to any creature that has a language—even a language you don’t know —by creating a new pidgin language that uses simplified terms and conveys basic concepts. To do so, you must first understand at least what medium of communication the creature uses (speech, sign language, and so on)." },
                    { new Guid("a9300d60-b3e5-4b0b-9376-75a590caf556"), new Guid("3f62ad52-d80b-4662-979c-6eb66a224801"), "Multiple smaller creatures or creatures with significantly smaller appetites than a human are counted as a single creature for this feat, and larger creatures or those with significantly greater appetites each count as multiple creatures. The GM determines how much a non-human creature needs to eat." },
                    { new Guid("a6f780cc-319d-4c0e-84b5-18dd1f1b3889"), new Guid("3f62ad52-d80b-4662-979c-6eb66a224801"), "Each time your proficiency rank in Survival increases, double the number of additional creatures you can take care of on a success (to eight if you’re an expert, 16 if you’re a master, or 32 if you’re legendary). You can choose to care for half the number of additional creatures and provide a comfortable living instead of subsistence living." },
                    { new Guid("89245459-0885-4ec0-bab4-0ce44729a508"), new Guid("3f62ad52-d80b-4662-979c-6eb66a224801"), "While using Survival to Subsist, if you roll any result worse than a success, you get a success. On a success, you can provide subsistence living for yourself and four additional creatures, and on a critical success, you can take care of twice as many creatures as on a success." },
                    { new Guid("af297ffe-fd7d-42b4-93b4-05f79cc46251"), new Guid("c041f814-94c4-43a1-be45-3bcd2621f2bb"), "You’ve discovered medical breakthroughs or techniques that achieve miraculous results. Once per day for each target, you can spend 1 hour treating that target and attempt a Medicine check to remove a disease or the blinded, deafened, doomed, or drained condition. Use the DC of the disease or of the spell or effect that created the condition. If the effect’s source is an artifact, above 20th level, or similarly powerful, increase the DC by 10." },
                    { new Guid("a36d8e49-5dd2-44c2-acb0-89d69ed09e80"), new Guid("fccdaf8a-46b0-4a18-9a90-dbb228317b58"), "You are adept at foiling creatures’ special senses and cautious enough to safeguard against them at all times. Whenever you use the Avoid Notice, Hide, or Sneak actions, you are always considered to be taking precautions against special senses (see the Detecting with Other Senses sidebar on page 465)." },
                    { new Guid("be06ab53-d3f3-48bd-95b0-e5ed0ef51451"), new Guid("5803b272-2368-49ce-ba0b-8c97aa753885"), "You can negotiate incredibly quickly in adverse situations. You attempt to Make an Impression and then Request your opponent cease their current activity and engage in negotiations. You take a –5 penalty to your Diplomacy check. The GM sets the DC of the Request based on the circumstances—it’s generally at least a very hard DC of the creature’s level. Some creatures might simply refuse, and even those who agree to parley might ultimately find your arguments lacking and return to violence." },
                    { new Guid("2084aa10-37e6-4665-b379-32a1c378e09e"), new Guid("38b0c4f7-2ad6-4c04-928d-dc53f2ff39b7"), "Even when caught in falsehoods, you pile lie upon lie. Reduce the circumstance bonus a target gains for your previous attempts to Create a Diversion or Lie to it from +4 to +2. If you’re a master in Deception, reduce the bonus to +1, and if you’re legendary, your targets don’t get these bonuses at all." },
                    { new Guid("9dfdb9a4-49d8-41a6-a8ac-2ea5e9e4626c"), new Guid("9ee79ba9-47ac-4cf5-906d-9e88190e8d22"), "Your ability to Steal defies belief. You can attempt to Steal something that is actively wielded or that would be extremely noticeable or time consuming to remove (like worn shoes or armor). You must do so slowly and carefully, spending at least 1 minute (and significantly longer for items that are normally time consuming to remove, like armor). Throughout this duration you must have some means of staying hidden, such as the cover of darkness or a bustling crowd. You take a –5 penalty to your Thievery check. Even if you succeed, if the item is extremely prominent—like a suit of full plate armor—onlookers will quickly notice it’s gone after you steal it." },
                    { new Guid("52ea6d08-fd50-45a1-8ee9-2dca70178979"), new Guid("53bda5e8-f9d2-461f-9495-c9db35ab99c1"), "Learning spells comes easily to you. If you’re an expert in a tradition’s associated skill, you take 10 minutes per spell level to learn a spell of that tradition, rather than 1 hour per spell level. If you fail to learn the spell, you can try again after 1 week or after you gain a level, whichever comes first. If you’re a master in the tradition’s associated skill, learning a spell takes 5 minutes per spell level, and if you’re legendary, it takes 1 minute per spell level. You can use downtime to learn and inscribe new spells. This works as if you were using Earn Income with the tradition’s associated skill, but instead of gaining money, you choose a spell available to you to learn and gain a discount on learning it, learning it for free if your earned income equals or exceeds its cost." },
                    { new Guid("d7fb4179-4b97-4759-8a00-3984bdb91602"), new Guid("43ae43aa-11d2-420f-bf17-6978f8a45a0f"), "Your charm allows you to win over those you lie to. When you get a critical success using the Lie action, the target’s attitude toward you improves by one step, as though you’d succeeded at using Diplomacy to Make an Impression. This works only once per conversation, and if you critically succeed against multiple targets using the same result, you choose one creature’s attitude to improve. You must be lying to impart seemingly important information, inflate your status, or ingratiate yourself, which trivial or irrelevant lies can’t achieve." },
                    { new Guid("947e2872-b7c3-4255-839d-6bde545f65e7"), new Guid("f552a716-9e47-457c-a9ec-51fa8cd3a85d"), "You have a sense for spells that twist minds or reveal secrets. You gain a +2 circumstance bonus to Occultism checks to Identify Magic with the mental, possession, prediction, or scrying traits." },
                    { new Guid("5983317e-3930-45c3-a5b2-d286fd3bf850"), new Guid("8dc95af1-d049-457f-91f8-311ead81336d"), "You easily pick up new languages. You learn two new languages, chosen from common languages, uncommon languages, and any others you have access to. You learn an additional language if you are or become a master in Society and again if you are or become legendary." },
                    { new Guid("0b8ded86-03cd-412f-a306-67aead75c577"), new Guid("0422a543-ec8f-4c04-9e15-5b4fd5c1f065"), "You forge strong connections with animals. You can spend 7 days of downtime regularly interacting with a normal animal (not a companion or other special animal) that is friendly or helpful to you. After this duration, attempt a DC 20 Nature check. If successful, you bond with the animal. The animal is permanently helpful to you, unless you do something egregious to break your bond. A helpful animal is easier to direct, as described under Command an Animal on page 249. Bonding with a new animal ends any previous bond you had. You can’t have both a bonded animal and an animal companion (though you can have both a bonded animal and a familiar)." },
                    { new Guid("614b8596-39fa-4006-903f-355857fc1e2d"), new Guid("df3e0135-e1de-4b1f-a580-19f521c5f328"), "You can Crawl incredibly swiftly—up to half your Speed, rather than 5 feet. If you’re a master in Acrobatics, you can Crawl at full Speed, and if you’re legendary, you aren’t flat-footed while prone." },
                    { new Guid("4ca461d1-0a65-42e2-8171-d30269bccf2c"), new Guid("1acd1549-a4de-477d-a3f4-e862c04c8a7a"), "You can draw upon strange variations in your spellcasting, whether or not you can cast occult spells. The DCs to Recognize Spells you cast and Identify Magic you use increase by 5." },
                    { new Guid("70b38a25-db58-44a1-8785-a7124775e352"), new Guid("9ab4e3c9-f592-4c0d-ac6e-adb33651feca"), "You unparalleled athletic skill allows you to jump impossible distances. Triple the distance you Long Jump (so you could jump 60 feet on a successful DC 20 check). When you High Jump, use the calculation for a Long Jump but don’t triple the distance." },
                    { new Guid("1e6015e9-a70f-4e85-810c-bbe811bd477d"), new Guid("9c848549-edaa-49b9-aa64-fcea1ccbc966"), "Your catlike aerial acrobatics allow you to cushion your falls. Treat falls as 10 feet shorter. If you’re an expert in Acrobatics, treat falls as 25 feet shorter. If you’re a master in Acrobatics, treat them as 50 feet shorter. If you’re legendary in Acrobatics, you always land on your feet and don’t take damage, regardless of the distance of the fall." },
                    { new Guid("8667db8e-760b-4b1d-a0b1-559e02a22b15"), new Guid("a90aba98-98fe-4a4d-86a6-93025e5d558a"), "You can Craft magic items, though some have other requirements, as listed in Chapter 11. When you select this feat, you gain formulas for four common magic items of 2nd level or lower." },
                    { new Guid("8a8dd86f-24fc-469c-b760-011217f25d3c"), new Guid("045ae2b1-ef9d-44a3-898d-8feb0832b94c"), "You can frighten foes so much, they might die. Attempt an Intimidation check against the Will DC of a living creature within 30 feet of you that you sense or observe and who can sense or observe you. If the target can’t hear you or doesn’t understand the language you are speaking, you take a –4 circumstance penalty. The creature is temporarily immune for 1 minute." },
                    { new Guid("d5968cb8-d28f-4615-a56a-00d65455649b"), new Guid("d1f81e6f-f97f-4bf3-8ddb-7db5ff7c351c"), "You can Steal or Palm an Object that’s closely guarded, such as in a pocket, without taking the –5 penalty. You can’t steal objects that would be extremely noticeable or time consuming to remove (like worn shoes or armor or actively wielded objects). If you’re a master in Thievery, you can attempt to Steal from a creature in combat or otherwise on guard. When doing so, Stealing requires 2 manipulate actions instead of 1, and you take a –5 penalty." },
                    { new Guid("c2d3b438-cbb4-43c2-88c1-3903570434c4"), new Guid("269b8813-ba84-42c6-9b73-11de579797bb"), "Your techniques allow you to fight as you climb. You’re not flat-footed while Climbing and can Climb with a hand occupied. You must still use another hand and both legs to Climb." },
                    { new Guid("3345970c-ae02-486b-a2ea-75eef371f9a4"), new Guid("9415b689-43b4-4177-b861-32cab298b5fe"), "You can Subsist using Survival on different planes, even those without resources or natural phenomena you normally need. For instance, you can forage for food even if the plane lacks food that could normally sustain you. A success on your check to Subsist can also reduce the damage dealt by the plane, at the GM’s discretion." },
                    { new Guid("98e7f9c9-8027-485d-af27-2de34ee1e1da"), new Guid("9ab4e3c9-f592-4c0d-ac6e-adb33651feca"), "You can jump a distance greater than your Speed by spending additional actions when you Long Jump or High Jump. For each additional action spent, add your Speed to the limit on how far you can Leap." },
                    { new Guid("60f7edf8-b1cd-4a3b-b412-af7a4b880942"), new Guid("6db67ca1-3fef-4705-9ad3-4d0e121e943b"), "You can patch up wounds, even in combat. Attempt a Medicine check with the same DC as for Treat Wounds and restore the corresponding amount of HP; this doesn’t remove the wounded condition. As with Treat Wounds, you can attempt checks against higher DCs if you have the minimum proficiency rank. The target is then temporarily immune to your Battle Medicine for 1 day." },
                    { new Guid("068516d5-9c17-490a-8f75-cf975420ca79"), new Guid("c7443dbf-2f52-48df-a53c-8dd6ad6732c0"), "You can apply natural cures to heal your allies. You can use Nature instead of Medicine to Treat Wounds. If you’re in the wilderness, you might have easier access to fresh ingredients, allowing you to gain a +2 circumstance bonus to your check to Treat Wounds using Nature, subject to the GM’s determination." },
                    { new Guid("2d1ff363-b4d4-43e3-910c-dac144202e6d"), new Guid("1332e046-d8ea-4a33-9a07-69308317891c"), "You can use Deception to weave traps to trip up anyone trying to deceive you. If you can engage in conversation with someone trying to Lie to you, use your Deception DC if it is higher than your Perception DC to determine whether they succeed. This doesn’t apply if you don’t have a back-and-forth dialogue, such as when someone attempts to Lie during a long speech." },
                    { new Guid("e6d543e3-8f19-45b3-ade2-59d9525160eb"), new Guid("a3395df1-fc95-4989-833c-c0d7465ecd1c"), "You have incredible breath control, which grants you advantages when air is hazardous or sparse. You can hold your breath for 25 times as long as usual before suffocating. You gain a +1 circumstance bonus to saving throws against inhaled threats, such as inhaled poisons, and if you roll a success on such a saving throw, you get a critical success instead." },
                    { new Guid("9f69671b-1e75-49a2-b6a8-d418bbf60f3f"), new Guid("85740fcc-7aaf-494f-81d7-8360620977d1"), "Your avoidance or observation is beyond the ken of most in your profession. Choose Fortitude saves, Reflex saves, Will saves, or Perception. You become an expert in your choice. At 17th level, you become a master in your choice." },
                    { new Guid("13825e71-f1db-4f44-9ec8-3bdf31a04712"), new Guid("d1d5b37b-2fcd-4699-892f-5c81cc437323"), "You spend time teaching an animal to do a certain action. You can either select a basic action the animal already knows how to do (typically those listed in the Command an Animal action on page 249) or attempt to teach the animal a new basic action. The GM determines the DC of any check required and the amount of time the training takes (usually at least a week). It’s usually impossible to teach an animal a trick that uses critical thinking. If you’re expert, master, or legendary in Nature, you might be able to train more unusual creatures, at the GM’s discretion." }
                });

            migrationBuilder.InsertData(
                table: "FeatRequirement",
                columns: new[] { "Id", "FeatId", "Text" },
                values: new object[] { new Guid("1713b28d-8d45-4cfd-a71c-56e903c7eb68"), new Guid("6db67ca1-3fef-4705-9ad3-4d0e121e943b"), "You’re holding or wearing healer’s tools (page 209)." });

            migrationBuilder.InsertData(
                table: "FeatTrait",
                columns: new[] { "FeatsId", "TraitsId" },
                values: new object[,]
                {
                    { new Guid("064e540b-673f-4abb-bacc-fda48911b21a"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("52456558-ce51-4f42-8ff2-fd4dbb72c25d"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("d1d5b37b-2fcd-4699-892f-5c81cc437323"), new Guid("ccae1335-3555-4e55-9fe4-d22f6b9bc162") },
                    { new Guid("045ae2b1-ef9d-44a3-898d-8feb0832b94c"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("52456558-ce51-4f42-8ff2-fd4dbb72c25d"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("288c9224-1ffe-4acc-8343-ba9a40e76c38"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("219b84b9-cb31-44df-b37e-6bf4916e5dfb"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("288c9224-1ffe-4acc-8343-ba9a40e76c38"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("219b84b9-cb31-44df-b37e-6bf4916e5dfb"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("219b84b9-cb31-44df-b37e-6bf4916e5dfb"), new Guid("dee6c869-337c-4f4c-ba3c-3c3e77c19857") },
                    { new Guid("17232376-8797-4f5b-bee0-2614d6938d5a"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("219b84b9-cb31-44df-b37e-6bf4916e5dfb"), new Guid("ccae1335-3555-4e55-9fe4-d22f6b9bc162") },
                    { new Guid("17232376-8797-4f5b-bee0-2614d6938d5a"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("064e540b-673f-4abb-bacc-fda48911b21a"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("d1d5b37b-2fcd-4699-892f-5c81cc437323"), new Guid("dee6c869-337c-4f4c-ba3c-3c3e77c19857") },
                    { new Guid("b5d31ebb-d361-4780-93c5-324bfd3c39b8"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("b5d31ebb-d361-4780-93c5-324bfd3c39b8"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("9648e97f-800c-492f-9277-93a17174bab1"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("30763d23-d261-4295-b636-f94bca378bec"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("eb5ca078-b3f2-4e84-8df4-526ced138637"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("eb5ca078-b3f2-4e84-8df4-526ced138637"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("045ae2b1-ef9d-44a3-898d-8feb0832b94c"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("8ee11526-08b4-451e-8424-83704f0d1a70"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("30763d23-d261-4295-b636-f94bca378bec"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("8ee11526-08b4-451e-8424-83704f0d1a70"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("ce1dc7c1-c529-42a2-a2f5-f6ca99df1804"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("045ae2b1-ef9d-44a3-898d-8feb0832b94c"), new Guid("f1f5c47a-fec2-4983-8229-3c4e8b43f0b5") },
                    { new Guid("d1d5b37b-2fcd-4699-892f-5c81cc437323"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("ce1dc7c1-c529-42a2-a2f5-f6ca99df1804"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("045ae2b1-ef9d-44a3-898d-8feb0832b94c"), new Guid("be9994ab-79ef-4ec0-9761-492059b0083a") },
                    { new Guid("dfb5e49e-df3e-443e-bfbf-d41e042306ed"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("76a68ae1-d7e0-4b2a-af54-4978b06db5cb"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("76a68ae1-d7e0-4b2a-af54-4978b06db5cb"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("dfb5e49e-df3e-443e-bfbf-d41e042306ed"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("045ae2b1-ef9d-44a3-898d-8feb0832b94c"), new Guid("f7ad867e-49e3-40e3-ad95-bbf461be2087") },
                    { new Guid("5fec7506-9390-4455-83ed-fc3666ca4fa2"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("d1d5b37b-2fcd-4699-892f-5c81cc437323"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("fee17526-90f5-401c-bdec-d084f40852a7"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("fee17526-90f5-401c-bdec-d084f40852a7"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("045ae2b1-ef9d-44a3-898d-8feb0832b94c"), new Guid("1ee8c64b-ad34-4b3b-a01c-a1057eea01f6") },
                    { new Guid("8b9edbcc-05ce-4df7-bc51-910ff6be643d"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("2a59396f-bf2a-4075-8207-3c906b7624ff"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("3539bdbe-8e7f-45c0-a094-649d85d3adca"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("738f86de-6f73-4ffa-a790-abd8feeb43c5"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("ccdd4b23-9813-407e-a7a6-8bc2cdafbab5"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("ccdd4b23-9813-407e-a7a6-8bc2cdafbab5"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("6f59e2f4-2100-436d-8cf8-266585faa937"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("6f59e2f4-2100-436d-8cf8-266585faa937"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("3f62ad52-d80b-4662-979c-6eb66a224801"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("3f62ad52-d80b-4662-979c-6eb66a224801"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("fccdaf8a-46b0-4a18-9a90-dbb228317b58"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("fccdaf8a-46b0-4a18-9a90-dbb228317b58"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("37e3bc29-be7b-4112-92aa-0b7dddbc2da3"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("174c21f8-b29a-4141-9070-eca5ecfdee71"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("68a98dbf-4a45-4217-a94f-2d0969915d96"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("d76bcd62-20d9-4fce-9fc1-735ec21a0cb2"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("d76bcd62-20d9-4fce-9fc1-735ec21a0cb2"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("a64ac93e-e7c5-46d1-85ec-72d93d5dcf7a"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("a64ac93e-e7c5-46d1-85ec-72d93d5dcf7a"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("fa30f639-b913-4050-b7bc-a8e9991178f1"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("fa30f639-b913-4050-b7bc-a8e9991178f1"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("0e715099-8cfd-449b-a6b0-37467f68accc"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("0e715099-8cfd-449b-a6b0-37467f68accc"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("dbd06473-8700-438f-b4e1-35474b87171c"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("fffc0274-b5cd-428f-8144-a7d8b01f5986"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("fffc0274-b5cd-428f-8144-a7d8b01f5986"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("738f86de-6f73-4ffa-a790-abd8feeb43c5"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("17f35e0f-3778-4143-b516-d08faf79bc68"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("18e0c385-d2ba-4646-989d-2e49d43d5f36"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("43f75824-0d49-466f-aa58-e40046c4a6d4"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("3afb7bd6-f0c2-4187-9d47-f7a06d512fd3"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("3afb7bd6-f0c2-4187-9d47-f7a06d512fd3"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("06f5008a-8b53-4c11-b0ec-2176e135d8b8"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("06f5008a-8b53-4c11-b0ec-2176e135d8b8"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("37f7d759-3c83-491a-a516-b41b64cf57a7"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("37f7d759-3c83-491a-a516-b41b64cf57a7"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("4f6b0041-df64-4d81-9ddd-baebcfdd28ed"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("4f6b0041-df64-4d81-9ddd-baebcfdd28ed"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("c8dd98a8-e102-4751-9606-88ed457bfdeb"), new Guid("ccae1335-3555-4e55-9fe4-d22f6b9bc162") },
                    { new Guid("c8dd98a8-e102-4751-9606-88ed457bfdeb"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("c8dd98a8-e102-4751-9606-88ed457bfdeb"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("0f49189c-434c-4490-8cbe-5235e6274441"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("0f49189c-434c-4490-8cbe-5235e6274441"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("a1804dfb-e3e0-45aa-b735-2f37fed15779"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("a1804dfb-e3e0-45aa-b735-2f37fed15779"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("9b475bb4-2086-4f81-b4ab-ef3f8f09f5db"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("9b475bb4-2086-4f81-b4ab-ef3f8f09f5db"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("6f87700e-7194-47d6-a9b2-20e0e2e53482"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("3539bdbe-8e7f-45c0-a094-649d85d3adca"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("3d690c93-0e1b-42c8-9d62-4e4219729dec"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("89921651-065e-48f8-98cb-c9b6cf6c71e9"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("89921651-065e-48f8-98cb-c9b6cf6c71e9"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("43f75824-0d49-466f-aa58-e40046c4a6d4"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("18e0c385-d2ba-4646-989d-2e49d43d5f36"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("c041f814-94c4-43a1-be45-3bcd2621f2bb"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("17f35e0f-3778-4143-b516-d08faf79bc68"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("2fbc54de-6f02-49d5-a01c-6adfd732a81e"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("6db67ca1-3fef-4705-9ad3-4d0e121e943b"), new Guid("dee6c869-337c-4f4c-ba3c-3c3e77c19857") },
                    { new Guid("6db67ca1-3fef-4705-9ad3-4d0e121e943b"), new Guid("06f2cf99-b089-4e34-b443-53028fdc2ae0") },
                    { new Guid("6db67ca1-3fef-4705-9ad3-4d0e121e943b"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("6db67ca1-3fef-4705-9ad3-4d0e121e943b"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("5ac7371e-af01-460e-a188-198481c67505"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("5ac7371e-af01-460e-a188-198481c67505"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("6684d89b-1994-4fa9-8b6b-c5123b642e86"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("6684d89b-1994-4fa9-8b6b-c5123b642e86"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("ca8d59e8-f938-4ffb-9890-9bed87134d5b"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("ca8d59e8-f938-4ffb-9890-9bed87134d5b"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("e4c0f632-f086-40f7-81c4-2d54f1bcb5b9"), new Guid("9979d44e-3a35-4eef-a767-d3c974b5fbf6") },
                    { new Guid("e4c0f632-f086-40f7-81c4-2d54f1bcb5b9"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("e4c0f632-f086-40f7-81c4-2d54f1bcb5b9"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("384659b6-1c1c-4612-9727-2d8406c2a328"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("a6def9d1-3dd5-4d2f-8e75-1773753119d9"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("a6def9d1-3dd5-4d2f-8e75-1773753119d9"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("1d6f005c-1b19-4072-8609-62af32b427e2"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("1d6f005c-1b19-4072-8609-62af32b427e2"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("57442d19-cae2-465c-9d3d-2e77ecde2a50"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("57442d19-cae2-465c-9d3d-2e77ecde2a50"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("b8193a38-a31c-45f2-a715-2542f09b97ca"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("2c8b47a4-eb56-491b-82fd-a3f894282025"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("2c8b47a4-eb56-491b-82fd-a3f894282025"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("1acd1549-a4de-477d-a3f4-e862c04c8a7a"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("15ccc079-da12-4678-8b48-f626e51418df"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("1acd1549-a4de-477d-a3f4-e862c04c8a7a"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("0422a543-ec8f-4c04-9e15-5b4fd5c1f065"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("2fbc54de-6f02-49d5-a01c-6adfd732a81e"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("5c26de36-847d-4a16-8871-0a2016fdfacc"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("5c26de36-847d-4a16-8871-0a2016fdfacc"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("059f1e6a-f8cd-4be2-8024-ddc21dd7cd60"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("059f1e6a-f8cd-4be2-8024-ddc21dd7cd60"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("a38f19f2-3b2d-4907-8425-d71dc351e8df"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("a38f19f2-3b2d-4907-8425-d71dc351e8df"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("a38f19f2-3b2d-4907-8425-d71dc351e8df"), new Guid("0c06a5b8-24e7-486b-bb98-91caef377013") },
                    { new Guid("38b0c4f7-2ad6-4c04-928d-dc53f2ff39b7"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("38b0c4f7-2ad6-4c04-928d-dc53f2ff39b7"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("269b8813-ba84-42c6-9b73-11de579797bb"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("269b8813-ba84-42c6-9b73-11de579797bb"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("9ab4e3c9-f592-4c0d-ac6e-adb33651feca"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("9ab4e3c9-f592-4c0d-ac6e-adb33651feca"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("43ae43aa-11d2-420f-bf17-6978f8a45a0f"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("43ae43aa-11d2-420f-bf17-6978f8a45a0f"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("9c848549-edaa-49b9-aa64-fcea1ccbc966"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("9c848549-edaa-49b9-aa64-fcea1ccbc966"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("85740fcc-7aaf-494f-81d7-8360620977d1"), new Guid("ccae1335-3555-4e55-9fe4-d22f6b9bc162") },
                    { new Guid("85740fcc-7aaf-494f-81d7-8360620977d1"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("85740fcc-7aaf-494f-81d7-8360620977d1"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("a3395df1-fc95-4989-833c-c0d7465ecd1c"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("0422a543-ec8f-4c04-9e15-5b4fd5c1f065"), new Guid("ccae1335-3555-4e55-9fe4-d22f6b9bc162") },
                    { new Guid("0422a543-ec8f-4c04-9e15-5b4fd5c1f065"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("c041f814-94c4-43a1-be45-3bcd2621f2bb"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("6f87700e-7194-47d6-a9b2-20e0e2e53482"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("5803b272-2368-49ce-ba0b-8c97aa753885"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("73d6b44a-a2a6-4a70-be2c-2dd59c09657a"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("73d6b44a-a2a6-4a70-be2c-2dd59c09657a"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("f725b35e-73bc-45b9-b5ee-6dfb225147b4"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("f725b35e-73bc-45b9-b5ee-6dfb225147b4"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("5803b272-2368-49ce-ba0b-8c97aa753885"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("f3cdc428-01a4-4687-8d48-8de530cbd154"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("eda136b0-c9e5-4b60-abd3-cc534c043a00"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("eda136b0-c9e5-4b60-abd3-cc534c043a00"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("8a71ca0e-0c73-4fdd-bde7-431f3237bca6"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("8a71ca0e-0c73-4fdd-bde7-431f3237bca6"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("48c371fb-6e9c-4d4f-965d-d56694b52100"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("48c371fb-6e9c-4d4f-965d-d56694b52100"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("8df39189-1886-4523-95b0-5980cad573f4"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("8df39189-1886-4523-95b0-5980cad573f4"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("7586b528-bef3-41be-b1f0-ea1fcb958c88"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("7586b528-bef3-41be-b1f0-ea1fcb958c88"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("7e3b8e25-d2ad-400e-9b03-a4993d0e5f8b"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("7e3b8e25-d2ad-400e-9b03-a4993d0e5f8b"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("064690bd-cd97-47a5-9e4c-fb8672bb6225"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("064690bd-cd97-47a5-9e4c-fb8672bb6225"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("89a41605-0006-4a7b-a101-f73d32f75a04"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("89a41605-0006-4a7b-a101-f73d32f75a04"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("2a59396f-bf2a-4075-8207-3c906b7624ff"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("ad4fe73a-0518-46c1-bfee-130d1b2053ab"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("24bfd707-04bb-4464-a3ad-e1dd040c0377"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("ad4fe73a-0518-46c1-bfee-130d1b2053ab"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("2107ba8d-4766-4434-b23e-fe90d9837b02"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("67a42abf-7456-4bca-a74b-ef8d2fdc4459"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("67a42abf-7456-4bca-a74b-ef8d2fdc4459"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("2818e8e6-4d55-4f83-ad45-6decff2673c1"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("2818e8e6-4d55-4f83-ad45-6decff2673c1"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("ec332db6-b06a-4a93-9935-756953f7a857"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("ec332db6-b06a-4a93-9935-756953f7a857"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("7de0d323-fc78-4154-a4d0-91e8af5ef631"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("7de0d323-fc78-4154-a4d0-91e8af5ef631"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("7ba0d3ef-7d44-42e4-8e2d-0b8bce8c9d16"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("7ba0d3ef-7d44-42e4-8e2d-0b8bce8c9d16"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("b1c71e21-bea7-453b-b23a-13ecc1b3675b"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("b1c71e21-bea7-453b-b23a-13ecc1b3675b"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("2b952cb7-5972-4866-a8d3-92410b2ed759"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("2b952cb7-5972-4866-a8d3-92410b2ed759"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("d466988f-8d00-4230-ab88-5c963abbecd1"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("d466988f-8d00-4230-ab88-5c963abbecd1"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("b5a95cad-67ab-4716-b582-4a11d8b863d1"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("b5a95cad-67ab-4716-b582-4a11d8b863d1"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("7aded813-2325-4a4d-aea7-077680584823"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("7aded813-2325-4a4d-aea7-077680584823"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("3bb4c8cd-9368-43dd-92b2-99174568570a"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("3bb4c8cd-9368-43dd-92b2-99174568570a"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("2107ba8d-4766-4434-b23e-fe90d9837b02"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("8ee83a83-4763-4423-87ff-c12ef752a494"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("24bfd707-04bb-4464-a3ad-e1dd040c0377"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("f3cdc428-01a4-4687-8d48-8de530cbd154"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("9415b689-43b4-4177-b861-32cab298b5fe"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("9ee79ba9-47ac-4cf5-906d-9e88190e8d22"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("d264d400-645f-4e7e-8100-ae5b2caf9e0e"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("d264d400-645f-4e7e-8100-ae5b2caf9e0e"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("ff4b4b20-73c2-4a67-a1a5-e504c8aa2dc6"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("ff4b4b20-73c2-4a67-a1a5-e504c8aa2dc6"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("9415b689-43b4-4177-b861-32cab298b5fe"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("171b6ae6-cda9-45a7-8c0a-64672e338e0b"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("171b6ae6-cda9-45a7-8c0a-64672e338e0b"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("12456924-12d6-4f6e-bde1-100892c683b5"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("12456924-12d6-4f6e-bde1-100892c683b5"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("8bfbc2e3-87d6-480d-8fd7-baeb77e465cd"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("8bfbc2e3-87d6-480d-8fd7-baeb77e465cd"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("1332e046-d8ea-4a33-9a07-69308317891c"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("1332e046-d8ea-4a33-9a07-69308317891c"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("9ee79ba9-47ac-4cf5-906d-9e88190e8d22"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("a90aba98-98fe-4a4d-86a6-93025e5d558a"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("d1f81e6f-f97f-4bf3-8ddb-7db5ff7c351c"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("d1f81e6f-f97f-4bf3-8ddb-7db5ff7c351c"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("f552a716-9e47-457c-a9ec-51fa8cd3a85d"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("f552a716-9e47-457c-a9ec-51fa8cd3a85d"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("df3e0135-e1de-4b1f-a580-19f521c5f328"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("df3e0135-e1de-4b1f-a580-19f521c5f328"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("c7443dbf-2f52-48df-a53c-8dd6ad6732c0"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("c7443dbf-2f52-48df-a53c-8dd6ad6732c0"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("8dc95af1-d049-457f-91f8-311ead81336d"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("a90aba98-98fe-4a4d-86a6-93025e5d558a"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("8dc95af1-d049-457f-91f8-311ead81336d"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") },
                    { new Guid("53bda5e8-f9d2-461f-9495-c9db35ab99c1"), new Guid("4fbbdfad-330f-4e0f-92dd-d070a59d7498") },
                    { new Guid("53bda5e8-f9d2-461f-9495-c9db35ab99c1"), new Guid("3d4c67f6-d5a1-4529-9559-02aa18d81054") }
                });

            migrationBuilder.InsertData(
                table: "HeritageRace",
                columns: new[] { "HeritagesId", "RacesId" },
                values: new object[,]
                {
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), new Guid("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), new Guid("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), new Guid("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), new Guid("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), new Guid("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce") },
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), new Guid("903f97e5-6972-4ad2-9377-447b7d6758a3") },
                    { new Guid("b54692a4-5791-4971-9590-17889ca0cbaa"), new Guid("903f97e5-6972-4ad2-9377-447b7d6758a3") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), new Guid("903f97e5-6972-4ad2-9377-447b7d6758a3") },
                    { new Guid("a8c3e70e-6eb6-4a5e-85cd-755eccc7677e"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), new Guid("903f97e5-6972-4ad2-9377-447b7d6758a3") },
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("4ce3660b-c78a-4eb5-b487-e234132f4f34"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("2edffa58-9514-4e51-82f8-e1b08e427aeb"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("c2c39377-feae-4142-a4c9-6d0e458d355c"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), new Guid("903f97e5-6972-4ad2-9377-447b7d6758a3") },
                    { new Guid("dce19cbd-7be3-4fd6-939b-48712d5f6daa"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("0b36fe08-7970-45a3-a816-05d187ae1709"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), new Guid("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), new Guid("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), new Guid("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), new Guid("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), new Guid("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5") },
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), new Guid("903f97e5-6972-4ad2-9377-447b7d6758a3") },
                    { new Guid("cbaec7eb-4492-42a3-83ac-1e82a5658fb8"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("634935e2-14bd-4de5-b1d9-fcff13093d94"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("b54692a4-5791-4971-9590-17889ca0cbaa"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") },
                    { new Guid("a3b12707-a7f5-41f0-9f49-f41d1839d5f7"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") },
                    { new Guid("03d1ff17-a448-47c9-b71f-5973a66e2563"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") },
                    { new Guid("03cbc90d-fbf1-488b-ab42-47a80884c75a"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") },
                    { new Guid("fdf36b32-00b2-457f-9aca-aa9378c0f92e"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") },
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") },
                    { new Guid("a3b12707-a7f5-41f0-9f49-f41d1839d5f7"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("3cd57ab7-c57a-4287-82ce-e1473f75af48"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("f95169fa-400b-446e-8ba2-0dca02ada9bc"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("4b699d38-c3fc-487c-a55b-f8d561897305"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("3623e7a3-e6e0-49d6-bddf-86374cd4e5d3"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("c7209f66-ad64-4356-bf03-aeb4e94bbd6f"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("635245e9-3230-4dab-8b0b-fac29a761c37"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("b9e766b7-d4e6-4f93-bc21-8020c2cc09bc"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("88f9765e-66ed-4780-bb53-c23c27b4f8ad"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("541986ae-7349-44fd-8004-c2e606e4f140"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("801fba4a-dd78-4f76-beca-ff51faac7b7a"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("967429bb-5245-4a3c-8468-9177f9f1ff77"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("e019e11d-e494-49d6-8861-5c61a4768b6a"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("4023db86-7064-4ad0-936e-e1f5c95e921b"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("62d5db67-945b-4cea-971f-9a2fa5038f2d"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("35e10760-e9f1-4570-89f6-7fd2c3ecee42"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("e6c22bc6-bb97-480b-85c3-6d1b2dd3980a"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("1109b6f8-33b0-4868-92f1-49e1ab8135d3"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("d4c74254-f221-41a2-b2b9-2d8ad741cbc0"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("6820eb19-bb58-4d56-9fdf-ce57f72b75d6"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("37a897ea-ac8a-407c-bf26-8443b948c8b3"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("0bde2b22-b4ee-484d-9052-6c4b47488624"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), new Guid("a8430e0c-d52e-477c-a058-bc970a2113ea") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), new Guid("a8430e0c-d52e-477c-a058-bc970a2113ea") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), new Guid("a8430e0c-d52e-477c-a058-bc970a2113ea") },
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), new Guid("a8430e0c-d52e-477c-a058-bc970a2113ea") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), new Guid("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), new Guid("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), new Guid("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), new Guid("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf") },
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), new Guid("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf") },
                    { new Guid("d40a90eb-140a-43b1-94f5-fb034f62d977"), new Guid("a8430e0c-d52e-477c-a058-bc970a2113ea") },
                    { new Guid("f574f17b-2c71-4a9e-adba-a91a5f5f6e22"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("b5615a58-0fc5-4b2d-87b7-b3f2e74e3a10"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("21a9fd8d-16db-43f2-af67-bd5a97b92d8e"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("4a851a94-b9dd-4afe-b74e-4c3ef1407d9f"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("14a46d8b-148c-4671-90ec-622b746f75e0"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("552b3bc3-c40c-42b6-a13b-436ba14e7c1e"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("d1269abf-7396-4b72-8130-9a74f3253bfb"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("36db9153-1a83-46b1-b303-47a5f4665704"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("7815fbcb-db7c-42fb-90fd-325aaee20d26"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") }
                });

            migrationBuilder.InsertData(
                table: "LanguageRace",
                columns: new[] { "LanguagesId", "RacesId" },
                values: new object[,]
                {
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), new Guid("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce") },
                    { new Guid("7c3e1ffc-a478-4009-986c-bf45770f5f10"), new Guid("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce") },
                    { new Guid("6a5332d4-f0b7-4e9b-8016-ccb5d03e9d0f"), new Guid("a8430e0c-d52e-477c-a058-bc970a2113ea") },
                    { new Guid("4bf191b9-77f7-47d0-89d7-e22555aaee7f"), new Guid("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf") },
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), new Guid("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf") },
                    { new Guid("bbbe92c4-628e-4b49-a1fb-9845a0071980"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("4fc0e030-aa67-4913-b738-16b82ac46354"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), new Guid("a8430e0c-d52e-477c-a058-bc970a2113ea") },
                    { new Guid("59a55746-938a-459e-8ff3-ce201de0a452"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("6582bcfc-19d6-4b4d-9c35-a25047433bb7"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("f05615ab-eba0-476d-8afd-1f628b90240b"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("ba4a2924-27ab-49a1-b700-310b1cfb0c22"), new Guid("903f97e5-6972-4ad2-9377-447b7d6758a3") },
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), new Guid("903f97e5-6972-4ad2-9377-447b7d6758a3") },
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), new Guid("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5") },
                    { new Guid("b968b2e8-1dc2-4c33-b108-5c58c36d85ed"), new Guid("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5") },
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("9200b27c-d210-4b47-bd77-43cfc86440d4"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") }
                });

            migrationBuilder.InsertData(
                table: "Lores",
                columns: new[] { "Id", "Discriminator", "Name", "PlaneId", "StatModifierId" },
                values: new object[] { new Guid("e57522d4-5e50-44c7-bbcb-1c4d0d81baeb"), "PlaneLore", "Plane", new Guid("e57522d4-5e50-44c7-bbcb-1c4d0d81baeb"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") });

            migrationBuilder.InsertData(
                table: "Lores",
                columns: new[] { "Id", "DeityId", "Discriminator", "Name", "StatModifierId" },
                values: new object[] { new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), new Guid("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") });

            migrationBuilder.InsertData(
                table: "Lores",
                columns: new[] { "Id", "Discriminator", "Name", "PlaneId", "StatModifierId" },
                values: new object[,]
                {
                    { new Guid("b191ffc0-7a9a-4285-b758-7542bef75a85"), "PlaneLore", "Plane", new Guid("b191ffc0-7a9a-4285-b758-7542bef75a85"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("f4048c73-6fb0-496c-9e7b-dff087bea6ef"), "PlaneLore", "Plane", new Guid("f4048c73-6fb0-496c-9e7b-dff087bea6ef"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("71064085-85ef-4986-b34c-c270b398749a"), "PlaneLore", "Plane", new Guid("71064085-85ef-4986-b34c-c270b398749a"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("10be56f4-5519-4cb6-8038-83dda6b0d00a"), "PlaneLore", "Plane", new Guid("10be56f4-5519-4cb6-8038-83dda6b0d00a"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("08350a3e-6f60-4b40-b5f0-8ec05e70204e"), "PlaneLore", "Plane", new Guid("08350a3e-6f60-4b40-b5f0-8ec05e70204e"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("af0a9351-d4e7-492d-93c4-2b7ef86cfa85"), "PlaneLore", "Plane", new Guid("af0a9351-d4e7-492d-93c4-2b7ef86cfa85"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("d1670c72-3c58-4e8a-8c36-6dd1d944383d"), "PlaneLore", "Plane", new Guid("d1670c72-3c58-4e8a-8c36-6dd1d944383d"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("b31acddd-b42e-4014-95cf-0e9ca41c73d3"), "PlaneLore", "Plane", new Guid("b31acddd-b42e-4014-95cf-0e9ca41c73d3"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("1a0e31c5-8271-458c-a941-d1a9a5a60d51"), "PlaneLore", "Plane", new Guid("1a0e31c5-8271-458c-a941-d1a9a5a60d51"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("8e6d1e80-b710-4468-89d5-a97d4178fd14"), "PlaneLore", "Plane", new Guid("8e6d1e80-b710-4468-89d5-a97d4178fd14"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("429fa72a-4a20-40ce-97b1-b4008807472b"), "PlaneLore", "Plane", new Guid("429fa72a-4a20-40ce-97b1-b4008807472b"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") }
                });

            migrationBuilder.InsertData(
                table: "Lores",
                columns: new[] { "Id", "DeityId", "Discriminator", "Name", "StatModifierId" },
                values: new object[,]
                {
                    { new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606"), new Guid("b093bbc0-fa6f-4b45-8200-c7ef61c55606"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("f5f38a92-1302-4d45-adf8-38452dde188b"), new Guid("f5f38a92-1302-4d45-adf8-38452dde188b"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("eda61d79-9877-483f-b660-bc282d270bb6"), new Guid("eda61d79-9877-483f-b660-bc282d270bb6"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), new Guid("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f"), new Guid("88e528a7-7a02-4151-a5f0-23e64e68916f"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("ac4c804a-c975-40f5-bdd2-7dcb97e9502d"), new Guid("ac4c804a-c975-40f5-bdd2-7dcb97e9502d"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), new Guid("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81"), new Guid("de85224c-6a69-482c-8a8d-dea0c4667e81"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("21794a2c-45f8-404a-9ecb-8897571f6c15"), new Guid("21794a2c-45f8-404a-9ecb-8897571f6c15"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0"), new Guid("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("196494f4-f104-45ad-8216-2c8bf68d3943"), new Guid("196494f4-f104-45ad-8216-2c8bf68d3943"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("980a89b8-bd72-4434-a744-10cdc645cee6"), new Guid("980a89b8-bd72-4434-a744-10cdc645cee6"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), new Guid("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), new Guid("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") }
                });

            migrationBuilder.InsertData(
                table: "Lores",
                columns: new[] { "Id", "Discriminator", "Name", "PlaneId", "StatModifierId" },
                values: new object[] { new Guid("7c34baea-48a6-4a49-8b15-8781a5c1ab47"), "PlaneLore", "Plane", new Guid("7c34baea-48a6-4a49-8b15-8781a5c1ab47"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") });

            migrationBuilder.InsertData(
                table: "Lores",
                columns: new[] { "Id", "DeityId", "Discriminator", "Name", "StatModifierId" },
                values: new object[,]
                {
                    { new Guid("01777837-1255-4d6a-9301-96dc48fffee4"), new Guid("01777837-1255-4d6a-9301-96dc48fffee4"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), new Guid("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("c624bf0e-d22c-4e01-8691-041083462102"), new Guid("c624bf0e-d22c-4e01-8691-041083462102"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("3d200ca3-0e4a-4a64-a8a1-0ad34870590c"), new Guid("3d200ca3-0e4a-4a64-a8a1-0ad34870590c"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") }
                });

            migrationBuilder.InsertData(
                table: "Lores",
                columns: new[] { "Id", "Discriminator", "Name", "PlaneId", "StatModifierId" },
                values: new object[] { new Guid("cc26757e-a07a-4213-84a3-36b300a2306a"), "PlaneLore", "Plane", new Guid("cc26757e-a07a-4213-84a3-36b300a2306a"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") });

            migrationBuilder.InsertData(
                table: "Lores",
                columns: new[] { "Id", "DeityId", "Discriminator", "Name", "StatModifierId" },
                values: new object[] { new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1"), new Guid("4fec4b99-9934-4872-993a-aec20fcf47e1"), "DeityLore", "Deity", new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") });

            migrationBuilder.InsertData(
                table: "Lores",
                columns: new[] { "Id", "Discriminator", "Name", "PlaneId", "StatModifierId" },
                values: new object[,]
                {
                    { new Guid("cdd0a36f-c298-41e6-9252-d3cbc81f5bd6"), "PlaneLore", "Plane", new Guid("cdd0a36f-c298-41e6-9252-d3cbc81f5bd6"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("84410831-a91b-4556-96a0-7eeba0653279"), "PlaneLore", "Plane", new Guid("84410831-a91b-4556-96a0-7eeba0653279"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("e48dae17-e2ad-48fa-8cfb-756dea200ca5"), "PlaneLore", "Plane", new Guid("e48dae17-e2ad-48fa-8cfb-756dea200ca5"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("235e010f-bfb6-40f0-a65f-628f2ea721bf"), "PlaneLore", "Plane", new Guid("235e010f-bfb6-40f0-a65f-628f2ea721bf"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("b1ed0a25-c679-4365-a45e-4d7fc057c1d9"), "PlaneLore", "Plane", new Guid("b1ed0a25-c679-4365-a45e-4d7fc057c1d9"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("4d67dae9-fa19-4ce6-be98-e52a7ca93f09"), "PlaneLore", "Plane", new Guid("4d67dae9-fa19-4ce6-be98-e52a7ca93f09"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("3e4b22a2-a4bd-42cc-b27f-a381758a4c11"), "PlaneLore", "Plane", new Guid("3e4b22a2-a4bd-42cc-b27f-a381758a4c11"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") },
                    { new Guid("2e98856d-d10d-46c9-8d7a-fe12e6581733"), "PlaneLore", "Plane", new Guid("2e98856d-d10d-46c9-8d7a-fe12e6581733"), new Guid("37406a59-0dd9-4766-8713-33b13b7740fd") }
                });

            migrationBuilder.InsertData(
                table: "MagicTraditionSpell",
                columns: new[] { "SpellsId", "TraditionsId" },
                values: new object[,]
                {
                    { new Guid("8e4669af-e67c-42a4-bd0f-9e117496cb6c"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("8e4669af-e67c-42a4-bd0f-9e117496cb6c"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("2ef1bfc9-3ca3-45b8-804a-ba9d948224de"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("a0dc825d-78c6-4464-a62e-17d7001c258e"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("2ef1bfc9-3ca3-45b8-804a-ba9d948224de"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("b59d7490-542e-4d17-9463-2e384faf2c0f"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") }
                });

            migrationBuilder.InsertData(
                table: "MagicTraditionSpell",
                columns: new[] { "SpellsId", "TraditionsId" },
                values: new object[,]
                {
                    { new Guid("c1546cbd-ec60-459f-b7f5-e29d51beb5f2"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("c1546cbd-ec60-459f-b7f5-e29d51beb5f2"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("c1546cbd-ec60-459f-b7f5-e29d51beb5f2"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("41fcd185-b9ba-41aa-96cf-1a8bcb65a64d"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("1e745c5e-5d8f-4abd-b66c-e0e582833257"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("1e745c5e-5d8f-4abd-b66c-e0e582833257"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("a0dc825d-78c6-4464-a62e-17d7001c258e"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("b59d7490-542e-4d17-9463-2e384faf2c0f"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("54d80001-c58b-4524-b23d-3962bb5f7ed4"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("54d80001-c58b-4524-b23d-3962bb5f7ed4"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("51df17bf-ef57-4eed-973c-55cf33285b61"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("51df17bf-ef57-4eed-973c-55cf33285b61"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("509c9a55-433c-4f99-8a7a-609d38f23ed1"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("509c9a55-433c-4f99-8a7a-609d38f23ed1"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("509c9a55-433c-4f99-8a7a-609d38f23ed1"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("509c9a55-433c-4f99-8a7a-609d38f23ed1"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("54176cd6-c3a3-43fd-8d47-9283811b03bb"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("236cd0a3-a07b-4c9f-ba11-e3c113d91634"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("236cd0a3-a07b-4c9f-ba11-e3c113d91634"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("3c902d87-38ff-4aad-acb3-266811986252"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("3c902d87-38ff-4aad-acb3-266811986252"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("436d4b2a-846a-4ff1-ae57-63ecfe80f337"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("436d4b2a-846a-4ff1-ae57-63ecfe80f337"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("3c902d87-38ff-4aad-acb3-266811986252"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("1e745c5e-5d8f-4abd-b66c-e0e582833257"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("b59d7490-542e-4d17-9463-2e384faf2c0f"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("73180f19-0c26-4f90-b377-8ae1d3df6525"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("3a8c5edf-e86c-431a-a25a-bb90d590eb35"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("3a8c5edf-e86c-431a-a25a-bb90d590eb35"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("3e91401a-203c-4d1e-9a76-0012e2617cd8"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("31f6e676-dbee-4c8f-9f17-a842afab35e3"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("31f6e676-dbee-4c8f-9f17-a842afab35e3"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("001dcfdb-d978-498b-a101-1d13c57b67f2"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("001dcfdb-d978-498b-a101-1d13c57b67f2"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("8280e542-c9e9-41d9-b152-aff2f054d447"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("3e91401a-203c-4d1e-9a76-0012e2617cd8"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("05375af9-4bc5-4eab-8731-2fb74c2062d9"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("9ebcaed3-689b-4886-939d-a8b0399180c5"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("5d1503f3-0176-4480-93b5-c4b4fef56dd3"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("5d1503f3-0176-4480-93b5-c4b4fef56dd3"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("af9903ec-8e9e-4752-bae4-042aca73f91a"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("5d1503f3-0176-4480-93b5-c4b4fef56dd3"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("9627d10b-e488-4299-9e1b-2c3a511ec007"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("05375af9-4bc5-4eab-8731-2fb74c2062d9"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("3e91401a-203c-4d1e-9a76-0012e2617cd8"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("31f6e676-dbee-4c8f-9f17-a842afab35e3"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("d8cf6802-13fb-4518-a463-538b28bed2da"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("3a8c5edf-e86c-431a-a25a-bb90d590eb35"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("66172098-6cdb-4587-89bb-24fe1a8faf7c"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("3a8c5edf-e86c-431a-a25a-bb90d590eb35"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("55780227-9986-4a2e-aa35-93a105314818"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("9d06d9f1-deaf-4fd0-8963-9ca6f5a645fa"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("9d06d9f1-deaf-4fd0-8963-9ca6f5a645fa"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("79fbdd8a-c496-4974-af00-14c3640841ab"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("79fbdd8a-c496-4974-af00-14c3640841ab"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("614267ca-482a-4435-bcea-127594ea342f"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("614267ca-482a-4435-bcea-127594ea342f"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("d8cf6802-13fb-4518-a463-538b28bed2da"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("d8cf6802-13fb-4518-a463-538b28bed2da"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("73180f19-0c26-4f90-b377-8ae1d3df6525"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("66172098-6cdb-4587-89bb-24fe1a8faf7c"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("3a320d74-73e9-40ab-a972-eb6b571f21fd"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("66172098-6cdb-4587-89bb-24fe1a8faf7c"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("2d0fa5a4-eab0-4eca-85cb-23241e5ef814"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("2d0fa5a4-eab0-4eca-85cb-23241e5ef814"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("6505b7e2-7c35-45ed-8fda-ff4bf3dd2822"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("2d0fa5a4-eab0-4eca-85cb-23241e5ef814"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("3a2a1f6e-f8d9-465d-94cc-1253a5c42062"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("2a4b767b-27d0-4519-b1f7-c554837d0c73"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("3a2a1f6e-f8d9-465d-94cc-1253a5c42062"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("6505b7e2-7c35-45ed-8fda-ff4bf3dd2822"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("6505b7e2-7c35-45ed-8fda-ff4bf3dd2822"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("4d709d69-ddde-487c-94a3-c876b4e79969"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("4d709d69-ddde-487c-94a3-c876b4e79969"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("5ca21ccd-2ccc-4900-99fe-40480d6103f2"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("4d709d69-ddde-487c-94a3-c876b4e79969"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("2a4b767b-27d0-4519-b1f7-c554837d0c73"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("94beacae-4765-499c-b93e-934fff8585a4"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("068fc3bd-e1ac-4069-8a29-13bd1a0b92f2"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("068fc3bd-e1ac-4069-8a29-13bd1a0b92f2"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("b2cc63b2-466a-478a-b024-b785f2b722de"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("7ca414c2-6185-4817-b1d7-9692d7a4433a"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("fc8ec088-6c8d-4d90-9293-9fc0720a3855"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("7ca414c2-6185-4817-b1d7-9692d7a4433a"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("b2cc63b2-466a-478a-b024-b785f2b722de"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("66172098-6cdb-4587-89bb-24fe1a8faf7c"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("060ba321-f5b9-4ac8-907c-fec7bb740713"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("35ac23b0-0e3d-4aab-8217-116f931edcb7"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("27b176c3-a4ac-425b-b7f1-9e6b7c25063f"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("4f77cd26-f3f0-4e6a-8424-b01480daadc4"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("4f77cd26-f3f0-4e6a-8424-b01480daadc4"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("2665ca32-131c-43cd-b30b-c763eb024a08"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("2665ca32-131c-43cd-b30b-c763eb024a08"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("e4568cde-13d1-4684-81b2-180bc291198f"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("e130e307-ede2-4a68-9667-cfc482855d95"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("3a320d74-73e9-40ab-a972-eb6b571f21fd"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("3a320d74-73e9-40ab-a972-eb6b571f21fd"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("3a320d74-73e9-40ab-a972-eb6b571f21fd"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("e130e307-ede2-4a68-9667-cfc482855d95"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("35ac23b0-0e3d-4aab-8217-116f931edcb7"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("b7157338-c1de-4e79-a90c-e0f62abd709c"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("ea3e3b79-80ab-4ef4-9dc7-6fb38561a935"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("060ba321-f5b9-4ac8-907c-fec7bb740713"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("f3fa6c93-ee1d-4da1-982d-55c015c0eeaa"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("f3fa6c93-ee1d-4da1-982d-55c015c0eeaa"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("1030f973-aee2-4c2f-8cc5-a98aa4594de4"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("1030f973-aee2-4c2f-8cc5-a98aa4594de4"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("484d98ad-91d1-4b2d-86d0-ec997a6f772b"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("ea3e3b79-80ab-4ef4-9dc7-6fb38561a935"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("484d98ad-91d1-4b2d-86d0-ec997a6f772b"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("2c2d2218-3a46-4075-899c-c4e9353aaec3"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("c5bd7524-e3f5-46b6-b1de-527896978d1c"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("c5bd7524-e3f5-46b6-b1de-527896978d1c"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("c5bd7524-e3f5-46b6-b1de-527896978d1c"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("311b0146-7b80-4594-800f-b0046237d47f"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("311b0146-7b80-4594-800f-b0046237d47f"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("2c2d2218-3a46-4075-899c-c4e9353aaec3"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("b6f25115-9358-44eb-bfc2-37b01c3863f4"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("5d1503f3-0176-4480-93b5-c4b4fef56dd3"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("2d8be059-3a79-4d4d-a7e8-31dee66680cc"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("fbb8d7cc-6793-484c-80a8-4fafb137e01e"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("fbb8d7cc-6793-484c-80a8-4fafb137e01e"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("fbb8d7cc-6793-484c-80a8-4fafb137e01e"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("5c0b6313-4951-4dc4-9289-0ec20210643d"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("5c0b6313-4951-4dc4-9289-0ec20210643d"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("7b0f3283-1f79-4a64-a697-eb842bb776b2"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("7b0f3283-1f79-4a64-a697-eb842bb776b2"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("2d8be059-3a79-4d4d-a7e8-31dee66680cc"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("328dda55-0bc8-461f-a3d3-686df512438c"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("328dda55-0bc8-461f-a3d3-686df512438c"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("eb816f67-17d1-439b-badb-2657b57f64e2"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("db143e7b-8212-4350-a09f-09205811470e"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("db143e7b-8212-4350-a09f-09205811470e"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("9ff794c4-74a1-412e-9d44-06d64f1570b1"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("7b0f3283-1f79-4a64-a697-eb842bb776b2"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("9ff794c4-74a1-412e-9d44-06d64f1570b1"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("2d8be059-3a79-4d4d-a7e8-31dee66680cc"), new Guid("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8") },
                    { new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") },
                    { new Guid("dcadfb92-e8c7-47a4-a6cc-4de6eefb7c3c"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("af9903ec-8e9e-4752-bae4-042aca73f91a"), new Guid("10dddda5-a943-4ecb-ba33-57ceba60245e") },
                    { new Guid("6e689573-2fdb-409f-abd2-a27135775498"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("7ebf76e9-a8fb-49a1-956c-f97f784dcbb9"), new Guid("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698") },
                    { new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), new Guid("fffa34af-0ad5-4e1e-9de9-92becba8c30b") }
                });

            migrationBuilder.InsertData(
                table: "PlanePlaneTrait",
                columns: new[] { "PlanesId", "TraitsId" },
                values: new object[,]
                {
                    { new Guid("4d67dae9-fa19-4ce6-be98-e52a7ca93f09"), new Guid("5f8d1fc6-5199-4c64-9633-f22db88b0b9e") },
                    { new Guid("2e98856d-d10d-46c9-8d7a-fe12e6581733"), new Guid("eba4f250-66db-48f2-b902-1398ba91a753") },
                    { new Guid("2e98856d-d10d-46c9-8d7a-fe12e6581733"), new Guid("5f8d1fc6-5199-4c64-9633-f22db88b0b9e") },
                    { new Guid("235e010f-bfb6-40f0-a65f-628f2ea721bf"), new Guid("8112fec1-79be-4738-9dc1-d98222fc1a6f") },
                    { new Guid("b31acddd-b42e-4014-95cf-0e9ca41c73d3"), new Guid("7b459163-b6bf-4471-976f-3489eab76349") },
                    { new Guid("b31acddd-b42e-4014-95cf-0e9ca41c73d3"), new Guid("348aeff9-7683-4763-b61d-79cba5b4547d") },
                    { new Guid("b31acddd-b42e-4014-95cf-0e9ca41c73d3"), new Guid("5f8d1fc6-5199-4c64-9633-f22db88b0b9e") },
                    { new Guid("f4048c73-6fb0-496c-9e7b-dff087bea6ef"), new Guid("83998080-dd80-4522-b1ef-75c6918c35ff") },
                    { new Guid("f4048c73-6fb0-496c-9e7b-dff087bea6ef"), new Guid("5f8d1fc6-5199-4c64-9633-f22db88b0b9e") },
                    { new Guid("71064085-85ef-4986-b34c-c270b398749a"), new Guid("9740e5d6-b49e-4827-8962-e70ffaa4e8be") },
                    { new Guid("e48dae17-e2ad-48fa-8cfb-756dea200ca5"), new Guid("2556952c-915d-4bc6-85f2-39b640854c9b") },
                    { new Guid("b191ffc0-7a9a-4285-b758-7542bef75a85"), new Guid("76206317-bdb6-4f71-b4c6-6536d06172d9") },
                    { new Guid("b191ffc0-7a9a-4285-b758-7542bef75a85"), new Guid("5f8d1fc6-5199-4c64-9633-f22db88b0b9e") },
                    { new Guid("1a0e31c5-8271-458c-a941-d1a9a5a60d51"), new Guid("7b459163-b6bf-4471-976f-3489eab76349") },
                    { new Guid("1a0e31c5-8271-458c-a941-d1a9a5a60d51"), new Guid("e7f12fc2-3003-4472-9ff0-904a838e1e75") },
                    { new Guid("1a0e31c5-8271-458c-a941-d1a9a5a60d51"), new Guid("5f8d1fc6-5199-4c64-9633-f22db88b0b9e") },
                    { new Guid("08350a3e-6f60-4b40-b5f0-8ec05e70204e"), new Guid("ccc03793-3fbe-4947-b411-96b49613e5c6") },
                    { new Guid("8e6d1e80-b710-4468-89d5-a97d4178fd14"), new Guid("c5358cea-44ea-4ef0-b6eb-281bdbc80e2a") },
                    { new Guid("8e6d1e80-b710-4468-89d5-a97d4178fd14"), new Guid("2556952c-915d-4bc6-85f2-39b640854c9b") },
                    { new Guid("d1670c72-3c58-4e8a-8c36-6dd1d944383d"), new Guid("a415e74d-e174-4573-b311-c02ea2fc2875") },
                    { new Guid("e48dae17-e2ad-48fa-8cfb-756dea200ca5"), new Guid("8112fec1-79be-4738-9dc1-d98222fc1a6f") },
                    { new Guid("7c34baea-48a6-4a49-8b15-8781a5c1ab47"), new Guid("eba4f250-66db-48f2-b902-1398ba91a753") },
                    { new Guid("3e4b22a2-a4bd-42cc-b27f-a381758a4c11"), new Guid("97dd8e80-f871-4a0b-943c-c6fc6b532d81") }
                });

            migrationBuilder.InsertData(
                table: "RaceRaceTrait",
                columns: new[] { "RaceTraitsId", "RacesId" },
                values: new object[,]
                {
                    { new Guid("852a5dc2-9cc6-4fb0-9250-801e27b1f8a3"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("6857833c-2458-4ece-b784-69b45a8afa63"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), new Guid("ed816fd4-9e13-43b4-b80f-30d2b5c910ff") },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), new Guid("903f97e5-6972-4ad2-9377-447b7d6758a3") },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("5138d6c9-4abf-446c-9e1b-5660a956242a"), new Guid("3404bf2c-eb1c-4cc6-b376-450a969af548") },
                    { new Guid("d15ee066-6c0e-4068-825e-79a87e3fecd6"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("06fa7847-6549-48a9-81cf-54be921e98bb"), new Guid("903f97e5-6972-4ad2-9377-447b7d6758a3") },
                    { new Guid("2ee1182b-590e-4ba0-b25a-404ebdfa365d"), new Guid("a8430e0c-d52e-477c-a058-bc970a2113ea") },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), new Guid("a8430e0c-d52e-477c-a058-bc970a2113ea") },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), new Guid("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce") },
                    { new Guid("ca44727c-ddd1-45b3-bb03-2e0cf7c10dc6"), new Guid("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5") },
                    { new Guid("4f75a119-344a-488a-b905-ed558e450f33"), new Guid("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce") },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), new Guid("7fc53559-4776-482c-910c-be3bd84d2de4") },
                    { new Guid("21de256c-7e2c-401c-bc8e-d2ad49ac1473"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), new Guid("e6ac68fc-98bf-4012-97a1-9910f988a1a4") },
                    { new Guid("e6ec055e-2598-48c4-b003-2b07f8847a41"), new Guid("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf") },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), new Guid("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf") },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), new Guid("96a536c5-7fe0-4a25-af8b-881a2892b576") },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), new Guid("519063b5-7283-4c0b-bb3a-d5d5edeba551") },
                    { new Guid("54611353-c19f-452b-91c3-557a80a661c4"), new Guid("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5") }
                });

            migrationBuilder.InsertData(
                table: "SpellDetailBlock",
                columns: new[] { "Id", "SpellId", "Text" },
                values: new object[,]
                {
                    { new Guid("e79c445d-4649-4cc9-b427-dbfb754c1ad3"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- Canine Speed 40 feet; Melee [one-action] jaws, Damage 2d8 piercing." },
                    { new Guid("46f110c3-3c5a-4319-b725-e7ea9a52528a"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- Cat Speed 40 feet; Melee [one-action] jaws, Damage 2d6 piercing; Melee[one - action] claw(agile), Damage 1d10 slashing." },
                    { new Guid("19cb8dc2-bef1-4622-b4e2-786de8f85b81"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- Deer Speed 50 feet; Melee [one-action] antler, Damage 2d6 piercing." },
                    { new Guid("dcbaa11d-7b56-43d2-a72e-13ec97f14e3f"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- Bull Speed 30 feet; Melee [one-action] horn, Damage 2d8 piercing." },
                    { new Guid("ba775672-2c5d-43a3-a002-e1214d439f7e"), new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03"), "You detect illusion magic only if that magic’s effect has a lower level than the level of your detect magic spell. However, items that have an illusion aura but aren’t deceptive in appearance (such as an invisibility potion) typically are detected normally." },
                    { new Guid("c474670c-dd98-40b0-a6fc-f5d19f51fec1"), new Guid("e4568cde-13d1-4684-81b2-180bc291198f"), "The spell ends for all creatures if you or one of your allies uses a hostile action against a target, or when the cause is completed. The GM might determine this spell has alignment traits befitting the cause." },
                    { new Guid("5ff96a2e-a6ea-4517-aba3-0fe377bae9d5"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), "- 5 temporary Hit Points." },
                    { new Guid("a36f0b28-ae6d-43ea-8671-40f6db86733c"), new Guid("8280e542-c9e9-41d9-b152-aff2f054d447"), "An object you hit is destroyed (no save), regardless of Hardness, unless it’s an artifact or similarly hard to destroy. A single casting can destroy no more than a 10-foot cube of matter. This automatically destroys any force construct, such as a wall of force." },
                    { new Guid("887e893d-9fcc-497b-8919-8042b3cdc1ec"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), "You gain the following statistics and abilities regardless of which battle form you choose:" },
                    { new Guid("567dee10-2303-414d-98fa-56f7716db07d"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), "- AC = 18 + your level. Ignore your armor’s check penalty and Speed reduction." },
                    { new Guid("f75b792f-043d-41cf-b6a9-56f7bd20ba1f"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), "- Low-light vision." },
                    { new Guid("f70c57db-900e-463b-b89a-c2bd7fe6cf56"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), "- One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You’re trained with them. Your attack modifier is +16, and your damage bonus is +5. These attacks are Dexterity based (for the purpose of the clumsy condition, for example). If your attack modifier for Dexterity-based unarmed attacks is higher, you can use it instead." },
                    { new Guid("7c3a524d-46bf-4367-941d-bc97e7c55be8"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), "- Pterosaur Speed 10 feet, fly Speed 40 feet; imprecise scent 30 feet; Melee[one-action] beak, Damage 3d6 piercing." },
                    { new Guid("d96945ba-09d9-4b78-acc7-5b09c7afab4c"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), "- Bird Speed 10 feet, fly Speed 50 feet; Melee [one-action] beak, Damage 2d8 piercing; Melee [one-action] talon (agile), Damage 1d10 slashing." },
                    { new Guid("1aec42b4-675b-4d61-8575-0115a42e52cc"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), "- Bat Speed 20 feet, fly Speed 30 feet; precise echolocation 40 feet; Melee [one-action] fangs, Damage 2d8 piercing; Melee [one-action] wing (agile), Damage 2d6 bludgeoning." },
                    { new Guid("f3e7e74b-556d-46f8-87fe-861544c2331b"), new Guid("e4568cde-13d1-4684-81b2-180bc291198f"), "- 15th: As 14th, plus the target can attempt a Will save at the end of each of its turns to end the spell for itself." },
                    { new Guid("ee30e7f9-5884-4454-955c-1da78755dab9"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), "You also gain specific abilities based on the form you choose:" },
                    { new Guid("ebc22a9b-b423-46ad-a966-0e1681936c64"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), "- Acrobatics modifier of +16, unless your own modifier is higher." },
                    { new Guid("702a5b5e-0fad-48db-b126-02b58069b5f7"), new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d"), "The GM rolls a secret DC 6 flat check. On a failure, the result is always “nothing.” This makes it impossible to tell whether a “nothing” result is accurate. If anyone asks about the same topic as the first casting of augury during an additional casting, the GM uses the secret roll result from the first casting. If circumstances change, though, it’s possible to get a different result." },
                    { new Guid("32014b54-ab8b-4c60-be4e-2ab72ae18ea0"), new Guid("6e689573-2fdb-409f-abd2-a27135775498"), "If you were Medium or smaller, you become Large, as the effects of enlarge. You must have space to expand into, or the spell is lost. You also gain the following benefits." },
                    { new Guid("4ed0277b-81ff-4863-b844-79de8e86bc7e"), new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), "- An instant tsunami sweeps over creatures in the area, dealing 3d10 bludgeoning damage with the water trait (doubled for creatures swimming in the area)." },
                    { new Guid("9e535072-b4b7-428e-94c3-898de6ca0ab6"), new Guid("e4568cde-13d1-4684-81b2-180bc291198f"), "- 13th or Lower: The target is so dedicated to the cause that it pursues the cause to the death (unless you say otherwise)." },
                    { new Guid("fc855a59-8d6c-44f2-978d-86551ac8ecbc"), new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300"), "- Green: The wall stops toxins, gases, and breath weapons from passing through. It deals 10 poison damage to anyone passing through and makes them enfeebled 1 for 1 minute. A basic Fortitude save reduces the damage and negates the enfeebled condition on a success. Passwall can counteract a green chromatic wall." },
                    { new Guid("02ad0292-99e0-42e1-a2f8-da387196a90c"), new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300"), "- Yellow :The wall stops acid, cold, electricity, fire, force, negative, positive, and sonic effects from passing through, and it deals 30 electricity damage to anyone passing through, with a basic Reflex save. Disintegrate can counteract a yellow chromatic wall." },
                    { new Guid("6256a8a8-31ae-4576-aa8c-722662fa37d7"), new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300"), "- Orange: The wall destroys thrown weapons that would pass through, and it deals 25 acid damage to anyone passing through, with a basic Reflex save. Gust of wind can counteract an orange chromatic wall." },
                    { new Guid("66f7ae40-6842-4482-b926-73b19f6dd8f9"), new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300"), "- Red: The wall destroys ranged weapon ammunition (such as arrows and crossbow bolts) that would pass through, and it deals 20 fire damage to anyone passing through, with a basic Reflex save. Cone of cold can counteract a red chromatic wall." },
                    { new Guid("5d6a8acb-12b1-425e-80f5-6166c16c1826"), new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300"), "Roll 1d4 to determine the color of the wall. Each color has a particular effect on items, effects, or creatures that attempt to pass through. Chromatic wall can’t be counteracted normally; rather, each color is automatically counteracted when targeted by a specific spell, even if that spell’s level is lower than that of chromatic wall." },
                    { new Guid("4ed9cd14-123d-4859-9255-c36eac8a062e"), new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), "- A massive wildfire burns in a sudden inferno, dealing 3d10 fire damage." },
                    { new Guid("f34e506c-12c8-4dad-9cbf-9e543170d9f1"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), "- Wasp Speed 20 feet, fly Speed 40 feet; Melee [one-action] stinger, Damage 1d8 piercing plus 1d6 persistent poison." },
                    { new Guid("c8c78ca8-a307-42eb-bb47-0b63589ba7e3"), new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), "- Beating winds churn across the sky, dealing 3d10 bludgeoning damage to creatures flying in the area." },
                    { new Guid("45983a64-0a25-4eba-9eaf-d050a4b49d11"), new Guid("e4568cde-13d1-4684-81b2-180bc291198f"), "- 14th: The target is dedicated to the cause, but the spell ends for the target if it’s reduced to half its maximum Hit Points or fewer." },
                    { new Guid("077a48c4-a7b5-40db-8538-fc69166f8900"), new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), "- Incredible lightning lashes the area, dealing 3d10 electricity damage." },
                    { new Guid("dcd40c58-78c7-4be6-8ba9-8ab86f679fb3"), new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), "- A roaring earthquake shakes and bludgeons creatures on the ground, dealing 3d10 bludgeoning damage." },
                    { new Guid("381ec139-c96a-41af-8fce-22ca8c5dbeb2"), new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), "- Flesh-dissolving acid rain deals 3d10 acid damage." },
                    { new Guid("cf2e53f8-3cc3-4b6a-b9b4-c923c6d7aacb"), new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), "Each creature attempts one basic Reflex save that applies to all five types of damage." },
                    { new Guid("766add6f-238c-4106-ae46-8595907ce970"), new Guid("b6f25115-9358-44eb-bfc2-37b01c3863f4"), "The first time you Sustain the Spell each round, the divine aura’s radius grows 10 feet." },
                    { new Guid("f388440c-c3bf-46ed-8048-109135a6e719"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- Snake Speed 20 feet, climb Speed 20 feet, swim Speed 20 feet; Melee[one - action] fangs, Damage 2d4 piercing plus 1d6 poison." },
                    { new Guid("858468ee-88f6-495c-8cf5-542d9209b061"), new Guid("b7157338-c1de-4e79-a90c-e0f62abd709c"), "To many deities, casting this spell on a follower of your own deity without significant cause is anathema." },
                    { new Guid("69870368-0e1e-43a6-9939-de554f70b183"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- Shark swim Speed 35 feet; Melee [one-action] jaws, Damage 2d8 piercing; breathe underwater but not in air." },
                    { new Guid("b63c6577-1c20-42ef-8bf4-4fd87ec3f16a"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- Frog Speed 25 feet, swim Speed 25 feet; Melee [one-action] jaws, Damage 2d6 bludgeoning; Melee [one-action] tongue (reach 15 feet), Damage 2d4 bludgeoning." },
                    { new Guid("6bd47ee1-f4dc-4c6c-97bf-04c1b84e55d1"), new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), "- A blast of freezing wind deals 3d10 cold damage." },
                    { new Guid("66e1d25e-9eb7-42dc-b412-220923879e98"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- Bear Speed 30 feet; Melee [one-action] jaws, Damage 2d8 piercing; Melee [one-action] claw (agile), Damage 1d8 slashing." },
                    { new Guid("dc1ca729-0d82-4e6e-8464-01e612e2d9bd"), new Guid("b6f25115-9358-44eb-bfc2-37b01c3863f4"), "When a creature of opposite alignment hits a target with a melee attack, the creature must succeed at a Will save or be blinded for 1 minute. It’s then temporarily immune for 1 minute." },
                    { new Guid("ce26e35f-f33b-4e20-bf3a-1e1d58bb2802"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "- One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You’re trained with them. Your attack modifier is +16, and your damage bonus is +9. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack modifier is higher, you can use it instead." },
                    { new Guid("e25b180f-db39-4c21-9ed3-6d808c006020"), new Guid("6e689573-2fdb-409f-abd2-a27135775498"), "- Weakness 10 to the alignment opposite the one you chose." },
                    { new Guid("08a3e3f0-9d91-4c27-87b8-df3ff705ca2d"), new Guid("6e689573-2fdb-409f-abd2-a27135775498"), "- A +1 status bonus to saves against spells." },
                    { new Guid("53e6b7c7-4384-4ac0-b0df-5a786b6016cb"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "- AC = 18 + your level. Ignore your armor’s check penalty and Speed reduction." },
                    { new Guid("d6d57c2a-5593-4664-a1ce-669c612f62ca"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "You gain the following statistics and abilities regardless of which battle form you choose:" },
                    { new Guid("9b6100f0-8551-4d82-b8a8-c642e5e859cd"), new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb"), "At the GM’s discretion, you can try to produce greater effects, but this is dangerous and the spell may have only a partial effect." },
                    { new Guid("a0ba7a4e-2f91-4988-ab24-505e68e7d734"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Irori: Speed 80 feet, air walk; Melee [one-action] unfettered strike (agile, versatile P or S, finesse, reach 15 feet), Damage 6d8+6 bludgeoning; Ranged [one-action] wind strike (range 60 feet), Damage 6d4+6 bludgeoning." },
                    { new Guid("2e8f36e1-e005-43fd-9ed9-26b6e8710a44"), new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb"), "- Reverse certain effects that refer to the wish spell" },
                    { new Guid("5a80550b-1451-46d0-b80a-a28bc7fbdca5"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "- 15 temporary Hit Points." },
                    { new Guid("dadf406b-366a-4ca6-8624-d4f315438b58"), new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb"), "- Produce any effect whose power is equivalent to any occult spell 9th level or lower, or non - occult spell 7th level or lower." },
                    { new Guid("b56cb637-0b05-4b5e-a9c8-41d717987cf7"), new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb"), "- Duplicate any occult spell of 9th level or lower." },
                    { new Guid("f2b10f10-1854-4e8b-b052-304b6fe58f9f"), new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb"), "The spell has the following effects:" },
                    { new Guid("ef5d40a9-0203-48f4-9744-f411c7a97342"), new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d"), "- Weal and Woe: The results will be a mix of good and bad." },
                    { new Guid("039876d3-70a2-4c24-a3a8-ebd2fd3d2504"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Iomedae: Speed 70 feet, air walk; shield (15 Hardness, can’t be damaged); Melee [one-action] longsword (versatile P, reach 15 feet), Damage 6d8+6 slashing." },
                    { new Guid("615ce084-3dba-407b-9239-3b7008af1d76"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Gozreh: No land Speed, fly Speed 70 feet, swim Speed70 feet, ignore difficult terrain and greater difficult terrain; Melee [one-action] waves (bull rush, reach 15 feet, thrown 20 feet), Damage 6d8+6 bludgeoning; Ranged [one-action] wind (versatile electricity, range 120 feet), Damage 6d6+3 bludgeoning." },
                    { new Guid("c16c0f4b-da16-4d0f-9cb2-baab4ba1667c"), new Guid("6e689573-2fdb-409f-abd2-a27135775498"), "- Darkvision." },
                    { new Guid("e13e5c33-fa04-43d2-9430-8ee5988e2e62"), new Guid("6e689573-2fdb-409f-abd2-a27135775498"), "- Your unarmed attacks and weapons deal 1 additional damage of the chosen alignment type." },
                    { new Guid("18c4ba08-3dcf-4336-b349-bc3929058dc5"), new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb"), "- Duplicate any non-occult spell of 7th level or lower." },
                    { new Guid("b78b210e-6ae9-4f99-8a09-9d77e4859e6b"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Erastil: Speed 70 feet, air walk, ignore difficult terrain and greater difficult terrain; Ranged[one - action] longbow(deadly d8, range increment 150 feet), Damage 6d8 + 3 piercing." },
                    { new Guid("f8d811ef-2e56-4548-9127-c1ded8842548"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "- Low-light vision and imprecise scent 30 feet." },
                    { new Guid("d21692fa-cd36-4823-80c9-f47bff9b8412"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Lamashtu: Speed 30 feet, fly Speed 70 feet; Melee [one-action] falchion (forceful, reach 15 feet), Damage 6d10+6 slashing; Ranged [one-action] waters of Lamashtu (range 120 feet), Damage 6d6 + 3 poison." },
                    { new Guid("a3beeee6-be5e-478b-bc1e-09f401eb8aa7"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Urgathoa: Speed 70 feet, air walk; Melee [one-action] scythe (deadly d10, trip, reach 15 feet), Damage 6d10+6 slashing; Ranged [one-action] pallid plague (range 120 feet), Damage 6d6+3 negative." },
                    { new Guid("d1ec7d7c-0749-465f-8582-565703093c6d"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Shelyn: Speed 70 feet, air walk, ignore difficult terrain and greater difficult terrain; Melee [one-action] glaive (deadly d8, nonlethal, reach 20 feet), Damage 6d8+6 slashing; Ranged [one-action] melody of inner beauty, (nonlethal, range 120 feet), Damage 6d6+3 sonic." },
                    { new Guid("d7fbbf0f-05e2-416d-960a-ced70a90df6f"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Zon-Kuthon: Speed 70 feet, air walk, ignore difficult terrain and greater difficult terrain; Melee [one-action] spiked chain (disarm, trip, reach 15 feet), Damage 6d8+6 slashing; Ranged [one-action] midnight pain (mental, nonlethal, range 120 feet), Damage 6d6+3 mental." },
                    { new Guid("5c1d6d32-a8a9-4d35-8a55-a75492ce165e"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "- Stegosaurus: Speed 30 feet; Melee [one-action] tail (reach 10 feet), Damage 2d8 piercing." },
                    { new Guid("fcd2be86-8f04-4d01-bbda-ebea7dec2614"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "- Deinonychus: Speed 40 feet; Melee [one-action] talon (agile), Damage 2d4 piercing plus 1 persistent bleed; Melee [one-action] jaws, Damage 1d10 piercing." },
                    { new Guid("2259126a-45a5-4687-9821-c15ce1b70cab"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Sarenrae: Speed 30 feet, fly Speed 70 feet; Melee [one-action] scimitar (forceful, nonlethal, reach 15 feet), Damage 6d6+6 slashing; Ranged [one-action] everflame (nonlethal, range 120 feet), Damage 6d6+3 fire." },
                    { new Guid("451a5567-b1ed-4573-84d6-abd04ee44351"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "- Brontosaurus: Speed 25 feet; Melee [one-action] tail (reach 15 feet), Damage 2d6 bludgeoning; Melee [one-action] foot, Damage 2d8 bludgeoning." },
                    { new Guid("c7873354-5805-4c8a-8831-1d82a30ee8ed"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- Ape Speed 25 feet, climb Speed 20 feet; Melee [one-action] fist, Damage 2d6 bludgeoning." },
                    { new Guid("7c9dd7f8-02bd-4213-affe-ae981c11b182"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "- Ankylosaurus: Speed 25 feet; Melee [one-action] tail (backswing, reach 10 feet), Damage 2d6 bludgeoning; Melee [one-action] foot, Damage 2d6 bludgeoning." },
                    { new Guid("efab6a65-c298-4b9e-a580-9ff3726bb950"), new Guid("6e689573-2fdb-409f-abd2-a27135775498"), "- A fly Speed equal to your Speed." },
                    { new Guid("4772e504-4fd7-45fb-a47b-8693e6e2fdd2"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "You also gain specific abilities based on the form you choose:" },
                    { new Guid("d09af233-4775-4202-a171-23a8b3489dd9"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "- Athletics modifier of +18, unless your own is higher." },
                    { new Guid("d23a21c8-3019-441b-9cbb-85aa284751c5"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Rovagug: Speed 50 feet, burrow Speed 30 feet, immune to immobilized; Melee [one-action] jaws (reach 15 feet), Damage 6d12+6 piercing; Melee [one-action] leg (agile, versatile P, reach 15 feet), Damage 6d8+6 bludgeoning." },
                    { new Guid("1f160434-ebe0-4fee-8fc1-ad761d54f891"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Pharasma: Speed 70 feet, air walk; Melee [one-action] dagger (agile, finesse, reach 15 feet, thrown 40 feet), Damage 6d6+6 slashing; Ranged [one-action] spiral blast (range 120 feet, damages only undead), Damage 6d8+3 positive." },
                    { new Guid("a443f87b-292a-437b-a60a-c327af9c27e9"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Norgorber: Speed 70 feet, air walk, ignore difficult terrain and greater difficult terrain; Melee [one-action] shortsword (agile, finesse, versatile S, reach 15 feet), Damage 6d6+6 piercing; Ranged [one-action] blackfinger toss (range 120 feet), Damage 6d6+3 poison." },
                    { new Guid("ef3ff3a5-bf5b-4e95-89b2-4a96fc08f719"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Nethys: Nethys Speed 70 feet, air walk; Ranged [one-action] raw magic (range 120 feet; versatile cold, electricity, or fire), Damage 6d6 force." },
                    { new Guid("e38e0b0c-dd32-4e48-8f7c-b5dd74371b98"), new Guid("6e689573-2fdb-409f-abd2-a27135775498"), "- 40 temporary Hit Points." },
                    { new Guid("37ac6077-a033-413b-b8f6-1120ec70cb14"), new Guid("6e689573-2fdb-409f-abd2-a27135775498"), "- One or more unarmed melee attacks. If you chose good or lawful, your fist attacks deal 2d8 damage. If you chose chaotic, you gain a bite unarmed attack that deals 2d10 piercing damage. If you chose evil, you gain a claws unarmed attack that deals 2d8 slashing damage and has the agile and finesse traits." },
                    { new Guid("799ce61b-2cdb-4ec9-9036-649d279e9c08"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Gorum: Speed 70 feet, immune to immobilized; Melee [one-action] greatsword (versatile P, reach 15 feet), Damage 6d12+6 slashing." },
                    { new Guid("7abfa2fb-aac3-48fd-81c6-1e6522b70c15"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Cayden Cailean: Speed 70 feet, air walk, ignore difficult terrain and greater difficult terrain; Melee [one-action] rapier (deadly, reach 15 feet), Damage 6d6+6 piercing; Ranged [one-action] ale splash (range 120 feet), Damage 6d6+3 poison." },
                    { new Guid("5ffa2d79-74e2-4327-9f08-4f3216cd2417"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Desna: Speed 30 feet, fly Speed 70 feet; Melee [one-action] starknife (agile, deadly, finesse, reach 15 feet, silver, thrown 60 feet), Damage 6d4+6 piercing; Ranged [one-action] moonbeam (range 120 feet, silver), Damage 6d6+3 fire." },
                    { new Guid("151544d1-c8dd-4dfe-99de-643f7f4476a9"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "- Tyrannosaurus: Speed 30 feet; Melee [one-action] jaws (deadly, reach 10 feet), Damage 1d12 piercing; Melee [one-action] tail (reach 10 feet), Damage 1d10 bludgeoning." },
                    { new Guid("99d2bb14-6f2f-43d1-b317-3d62407948b0"), new Guid("7ebf76e9-a8fb-49a1-956c-f97f784dcbb9"), "When a creature of opposite alignment hits a target with a melee attack, the creature must succeed at a Will save or be blinded for 1 minute. It’s then temporarily immune for 1 minute." },
                    { new Guid("af0a1742-904c-4467-a3a8-510bff8e19d7"), new Guid("7ebf76e9-a8fb-49a1-956c-f97f784dcbb9"), "Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose. The bonuses granted by the spell increase to +2 against attacks by—and effects created by—creatures with an alignment opposite to the spell (lawful if you chose chaotic, evil if you chose good). These bonuses increase to +4 against effects created by such creatures that attempt to impose the controlled condition on a target of your divine aura, as well as against attacks made by creatures summoned by anything opposite in alignment to your divine aura." },
                    { new Guid("300ba168-764f-491e-a447-df9f3c2f3c3c"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "You gain the following statistics and abilities regardless of which battle form you choose:" },
                    { new Guid("861b2972-0bf6-4ac7-87cf-d7200caf3872"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- AC = 16 + your level. Ignore your armor’s check penalty and Speed reduction." },
                    { new Guid("a08010bb-278e-457b-8a83-9bd955303460"), new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3"), "- Living Creature: The spell deals negative damage equal to 1d4 plus your spellcasting modifier. The target attempts a basic Fortitude save, but is also enfeebled 1 for 1 round on a critical failure." },
                    { new Guid("5a911837-34c2-47c2-b348-125d22fea173"), new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3"), "- Undead Creature: The target is flat-footed for 1 round on a failed Fortitude save. On a critical failure, the target is also fleeing for 1 round unless it succeeds at a Will save. Heightened (+1)" },
                    { new Guid("ade20fbb-a1e0-4cb8-8b63-4ed7306f1427"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- 5 temporary Hit Points." },
                    { new Guid("a2575b6e-2f53-4c64-92ca-a2e2006809cf"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- Low-light vision and imprecise scent 30 feet." },
                    { new Guid("54acdc29-8944-49a8-b38b-3bd5bf590358"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You’re trained with them. Your attack modifier is +9, and your damage bonus is +1. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack bonus is higher, you can use it instead." },
                    { new Guid("59c4fe59-3095-446e-b43f-34a001f7afd3"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "- Athletics modifier of +9, unless your own modifier is higher." },
                    { new Guid("3f43ac0e-e9bf-431b-adad-1e38650be56e"), new Guid("31f6e676-dbee-4c8f-9f17-a842afab35e3"), "You can target a creature only if you’ve seen it in person, have one of its significant belongings, or have a piece of its body. To target an object, you must have touched it or have a fragment of it. Discern location automatically overcomes protections against detection and divination of lower level than this spell, even if they would normally have a chance to block it." },
                    { new Guid("0a3de3aa-3e97-4f6b-a661-88f0f8477e82"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), "You also gain specific abilities based on the type of animal you choose:" },
                    { new Guid("fd081fec-24f3-4bde-a6c4-44c031947a4a"), new Guid("b6f25115-9358-44eb-bfc2-37b01c3863f4"), "Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose. The bonuses granted by the spell increase to +2 against attacks by—and effects created by—creatures with an alignment opposite to the spell (lawful if you chose chaotic, evil if you chose good). These bonuses increase to +4 against effects created by such creatures that attempt to impose the controlled condition on a target of your divine aura, as well as against attacks made by creatures summoned by anything opposite in alignment to your divine aura." },
                    { new Guid("ba4c847a-4c45-4d7b-adb4-41a03b562606"), new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d"), "- Nothing: There won’t be particularly good or bad results." },
                    { new Guid("93b29669-1b66-422e-96be-17a1c795e34f"), new Guid("54d80001-c58b-4524-b23d-3962bb5f7ed4"), "Only creatures of 6th level or higher—unless divine spellcasters, undead, or beings from the Outer Sphere—have alignment auras." },
                    { new Guid("59abdf72-d40a-4b6c-93d2-2a91bb5e4784"), new Guid("55780227-9986-4a2e-aa35-93a105314818"), "- Triceratops: Speed 30 feet; Melee [one-action] horn, Damage 2d8 piercing, plus 1d6 persistent bleed on a critical hit; Melee [one-action] foot, Damage 2d6 bludgeoning." },
                    { new Guid("2b7a891d-5e49-4e72-86e4-0d0d8fc5f99d"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- AC = 25 + your level. Ignore your armor’s check penalty and Speed reduction." },
                    { new Guid("a360bbe1-1f56-4bac-b1b5-a8dab82d5659"), new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d"), "- Woe: The results will be bad." },
                    { new Guid("e0460453-86b5-447b-b407-f5568d63f4a6"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Calistria: Speed 30 feet, fly Speed 70 feet; Melee [one-action] whip (disarm, finesse, nonlethal, reach 20 feet), Damage 6d4+6 slashing; Ranged [one-action] savored sting (range 60 feet), Damage 6d6+3 poison." },
                    { new Guid("a0746a57-ce84-495e-b5c9-b41c0161607c"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Asmodeus: Speed 70 feet, air walk; Melee [one-action] mace (reach 15 feet), Damage 6d10+6 bludgeoning; Ranged [one-action] hellfire (range 120 feet), Damage 6d6+3 fire." },
                    { new Guid("18cfb804-b63c-42c2-8de5-57f110ed13f3"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Abadar: Speed 50 feet, burrow Speed 30 feet, immune to immobilized; Ranged[one - action] crossbow(range increment 120 feet, reload 1), Damage 6d10 + 3 piercing." },
                    { new Guid("62aac3fd-dc88-4275-b479-964d0e390ef0"), new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d"), "- Weal: The results will be good." },
                    { new Guid("90f30a66-c2fc-441e-9f77-5b0054606681"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "You also gain the specific abilities listed for your deity below:" },
                    { new Guid("c11e0547-ec12-4c4b-a40b-bc5177fa1527"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "You gain the following statistics and abilities regardless of which deity’s battle form you assume:" },
                    { new Guid("498b0a9a-0524-49bc-877f-3140eac68339"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Athletics modifier of +35, unless your own is higher." },
                    { new Guid("802fe062-ca5f-431f-ae6e-23726d5feac2"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Torag: Speed 50 feet, burrow Speed 30 feet, immune to immobilized; shield (15 Hardness, can’t be damaged); Melee [one-action] warhammer (bull rush, reach 15 feet), Damage 6d8+6 bludgeoning." },
                    { new Guid("7f34d0c1-10ae-4937-a9fb-aae94c21ff6e"), new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d"), "The spell can predict results up to 30 minutes into the future and reveals the GM’s best guess among the following outcomes:" },
                    { new Guid("0e46e684-dda7-4d66-9a64-0ae231eda72f"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- Darkvision." },
                    { new Guid("95d2bd40-775a-43e7-b421-e46792dd7ebc"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- 30 temporary Hit Points." },
                    { new Guid("d03cdf8c-3ba5-4729-b1e1-f3ab158d80db"), new Guid("7ebf76e9-a8fb-49a1-956c-f97f784dcbb9"), "The first time you Sustain the Spell each round, the divine aura’s radius grows 10 feet." },
                    { new Guid("87ae08fa-7ec5-4c5e-99e3-918c6530e65b"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), "- One or more attacks specific to your deity’s battle form, which are the only attacks you can use. You’re trained with them. Your attack modifier is +33, and you use the listed damage. Melee attacks are Strength based (for the purposes of the enfeebled condition, for example) unless they have the finesse trait, and all ranged attacks are Dexterity based. Attacks that deal positive or negative damage don’t heal creatures." }
                });

            migrationBuilder.InsertData(
                table: "SpellHeightening",
                columns: new[] { "Id", "Description", "Level", "SpellId" },
                values: new object[,]
                {
                    { new Guid("e6a136cc-0056-439b-b6a2-dd406c4b5752"), "The damage increases by 2d6.", 1, new Guid("2a4b767b-27d0-4519-b1f7-c554837d0c73") },
                    { new Guid("94452491-58bd-487f-b187-8525fe6a0160"), "The damage increased by 1d4.", 1, new Guid("eb816f67-17d1-439b-badb-2657b57f64e2") },
                    { new Guid("34a0a521-0496-4876-8e2e-1b7195af1f4b"), "You can target up to 10 creatures, and targets can also speak the language.", 4, new Guid("6505b7e2-7c35-45ed-8fda-ff4bf3dd2822") },
                    { new Guid("2f7a2dd1-f158-490c-9ffe-b67b3a085a5c"), "Your battle form is Huge and your attacks have 15-foot reach, or 20-foot reach if they started with 15-foot reach. You instead gain 20 temporary HP, an attack modifier of +18, a damage bonus of +6, double the damage dice, and Athletics +21.", 5, new Guid("55780227-9986-4a2e-aa35-93a105314818") },
                    { new Guid("d523848c-c447-477b-b8f3-48dc196055ef"), "The target can also speak the language.", 3, new Guid("6505b7e2-7c35-45ed-8fda-ff4bf3dd2822") },
                    { new Guid("dae11cb9-b62c-4073-827c-635821ed5e74"), "You can target up to 10 creatures.", 5, new Guid("4d709d69-ddde-487c-94a3-c876b4e79969") },
                    { new Guid("8e38a5fc-f74d-4c0a-b653-4bc2c4610d9e"), "The number of targets increases by 1.", 1, new Guid("f3fa6c93-ee1d-4da1-982d-55c015c0eeaa") },
                    { new Guid("283ef60d-8ca4-463d-80cc-12bafa287dfc"), "You can target up to 10 creatures.", 8, new Guid("068fc3bd-e1ac-4069-8a29-13bd1a0b92f2") },
                    { new Guid("a7a1d25e-fd89-4602-8322-e796cc091afd"), "Your battle form is Gargantuan and your attacks have 20-foot reach, or 25-foot reach if they started with 15-foot reach. You instead gain AC = 21 + your level, 25 temporary HP, an attack modifier of +25, a damage bonus of +15, double the damage dice, and Athletics +25.", 7, new Guid("55780227-9986-4a2e-aa35-93a105314818") },
                    { new Guid("548e581b-6bf6-4a27-9622-996ca1e4e8ff"), "The number of targets increases by 1.", 1, new Guid("060ba321-f5b9-4ac8-907c-fec7bb740713") },
                    { new Guid("3d32cc67-f66b-4b7d-a267-ff050108114c"), "The spell’s range is touch and it targets 1 willing creature.The duration is until the next time you make your daily preparations.", 5, new Guid("66172098-6cdb-4587-89bb-24fe1a8faf7c") },
                    { new Guid("cda1fc96-7b2c-4df9-b65f-04b4a2e0f5c7"), "You can choose a spell of 6th level or lower.", 9, new Guid("94beacae-4765-499c-b93e-934fff8585a4") },
                    { new Guid("ae249d83-3fe3-4e38-8154-4d6b07924f3c"), "The damage increases by 2d6 (or by 2d8 if the target is a divine spellcaster).", 1, new Guid("b7157338-c1de-4e79-a90c-e0f62abd709c") },
                    { new Guid("9da22e21-d1e7-43d1-88e8-e95065c242db"), "The initial damage increases to 1d6 + your spellcasting ability modifier, and the persistent damage increases to 2.", 3, new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c") },
                    { new Guid("9e4831ac-5cfe-4a20-9583-6d18d37fa4d2"), "The duration is until the next time you make your daily preparations.", 6, new Guid("2ef1bfc9-3ca3-45b8-804a-ba9d948224de") },
                    { new Guid("07445e05-eccc-4463-b72a-ab813e961d2e"), "The initial damage increases to 2d6 + your spellcasting ability modifier, the persistent damage increases to 3, and the splash damage increases to 2.", 5, new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c") },
                    { new Guid("18cca2c1-2c7b-4486-b085-734cebf5f52d"), "The damage increases by 1d10, and the level of creatures that must attempt a second save on a critical failure increases by 2.", 1, new Guid("7ebf76e9-a8fb-49a1-956c-f97f784dcbb9") },
                    { new Guid("5f67a8e9-f9f4-4b40-a9b6-f651f6b07886"), "You learn the number and types of poison.", 2, new Guid("8e4669af-e67c-42a4-bd0f-9e117496cb6c") },
                    { new Guid("107e9a96-572d-40b9-87d9-bf36b2302260"), "The initial damage increases to 3d6 + your spellcasting ability modifier, the persistent damage increases to 4, and the splash damage increases to 3.", 7, new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c") },
                    { new Guid("7c4a2e8b-867f-4b2b-816a-535e3eb0fc79"), "The level for each category increases by 2.", 10, new Guid("e4568cde-13d1-4684-81b2-180bc291198f") },
                    { new Guid("be4200a2-c623-4146-890a-bddb87f620cf"), "You learn each aura's location and strength.", 2, new Guid("54d80001-c58b-4524-b23d-3962bb5f7ed4") },
                    { new Guid("cecf2b46-be78-406a-ab01-b1bff4d3917a"), "The area increases to a 60-foot cone.", 7, new Guid("2665ca32-131c-43cd-b30b-c763eb024a08") },
                    { new Guid("a7a384da-ca83-4941-969f-668d59f18cb5"), "The initial damage increases to 4d6 + your spellcasting ability modifier, the persistent damage increases to 5, and the splash damage increases to 4.", 9, new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c") },
                    { new Guid("aa381ca0-7a43-4e1b-9d5d-2ad73be5255d"), "The damage increases by 1d6.", 2, new Guid("2d8be059-3a79-4d4d-a7e8-31dee66680cc") },
                    { new Guid("9d5aaa18-2a33-4468-b219-bf3429228901"), "Even creatures with darkvision (but not greater darkvision) can barely see through the darkness. They treat targets seen through the darkness as concealed.", 4, new Guid("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e") },
                    { new Guid("4c4341f2-16d9-4a55-b504-418231e4b9fe"), "The negative damage to living creatures increases by 1d4.", 1, new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3") },
                    { new Guid("b2fd64f9-51d7-42fb-b78d-fd29bf47f508"), "The spell’s range is touch and it targets 1 willing creature.", 3, new Guid("66172098-6cdb-4587-89bb-24fe1a8faf7c") },
                    { new Guid("c9d1c03b-32b0-4182-ad71-89f87576f5a7"), "You learn the school of magic for the highestlevel effect within range that the spell detects. If multiple effects are equally strong, the GM determines which you learn.", 3, new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03") },
                    { new Guid("480f3fc8-55c9-4961-8572-5cc86cc4ca85"), "The item is metal and can include common minerals, like feldspar or quartz.", 5, new Guid("311b0146-7b80-4594-800f-b0046237d47f") },
                    { new Guid("0e4f844c-c605-4423-9321-ca5241df1950"), "As 3rd level, but you also pinpoint the source of the highest-level magic. Like for an imprecise sense, you don’t learn the exact location, but can narrow down the source to within a 5-foot cube (or the nearest if larger than that).", 4, new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03") },
                    { new Guid("842ac0e3-6867-4a83-b8fa-8e60db388251"), "The temporary Hit Points increase to 60, the weakness increases to 15, and the duration increases to 10 minutes.", 9, new Guid("6e689573-2fdb-409f-abd2-a27135775498") },
                    { new Guid("3f51f72d-37e7-4e37-8f3d-48686460b573"), "You can choose a spell of 7th level or lower.", 10, new Guid("94beacae-4765-499c-b93e-934fff8585a4") },
                    { new Guid("fd04a9d3-8d55-49b6-ab6f-863cfda50de7"), "The spell is more difficult to counteract and resist, but the cost is increased to 16gp.", 3, new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1") },
                    { new Guid("c15bae80-bafd-4214-a887-e8dc349d2a51"), "The spell is more difficult to counteract and resist, but the cost is increased to 30gp.", 4, new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1") },
                    { new Guid("ecdcd196-a2f7-4eff-a302-36829c060875"), "The spell is more difficult to counteract and resist, but the cost is increased to 60gp.", 5, new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1") },
                    { new Guid("20e9bfe7-6e9d-4e2d-ae10-68455f7a75dc"), "The spell is more difficult to counteract and resist, but the cost is increased to 120gp.", 6, new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1") },
                    { new Guid("70f8b982-3a29-4498-89e7-eee2ead46d0f"), "The spell is more difficult to counteract and resist, but the cost is increased to 270gp.", 7, new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1") },
                    { new Guid("26042150-1558-43d2-acd2-8a75c20f513e"), "The spell is more difficult to counteract and resist, but the cost is increased to 540gp.", 8, new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1") },
                    { new Guid("d896e7f8-a52e-49d1-a1fe-98148ba1c246"), "You can choose a spell of 5th level or lower.", 8, new Guid("94beacae-4765-499c-b93e-934fff8585a4") },
                    { new Guid("79854345-f541-48f2-8e04-8401e71c598b"), "The spell is more difficult to counteract and resist, but the cost is increased to 1350gp.", 9, new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1") },
                    { new Guid("4d38efb2-763a-44c6-97d6-f67dccc6e8c2"), "The range increases to 1 mile. You don’t need to be able to see your destination, as long as you have been there in the past and know its relative location and distance from you. You are temporarily immune for 1 hour.", 5, new Guid("73180f19-0c26-4f90-b377-8ae1d3df6525") },
                    { new Guid("923762df-f025-49e3-9f23-b82e97f15e5a"), "You can feed 12 Medium creatures.", 4, new Guid("2d0fa5a4-eab0-4eca-85cb-23241e5ef814") },
                    { new Guid("14353fce-2884-4203-ae5c-2a52cc7c629b"), "You can feed 50 Medium creatures.", 6, new Guid("2d0fa5a4-eab0-4eca-85cb-23241e5ef814") },
                    { new Guid("d5f956fa-1486-461c-9ff5-94db3f1f5cdd"), "You can feed 200 Medium creatures.", 8, new Guid("2d0fa5a4-eab0-4eca-85cb-23241e5ef814") },
                    { new Guid("766b8628-93b0-4a8f-baf9-d7be6eb4e957"), "Target up to three weapons, and the damage increases to 3d4 damage.", 5, new Guid("9627d10b-e488-4299-9e1b-2c3a511ec007") },
                    { new Guid("25598434-fc72-4c97-b895-060cada42dda"), "The damage increases to 2d4 damage.", 3, new Guid("9627d10b-e488-4299-9e1b-2c3a511ec007") },
                    { new Guid("637c1c9a-e2f9-497d-85fc-9ca72fbba552"), "The damage increases by 1d6.", 1, new Guid("db143e7b-8212-4350-a09f-09205811470e") },
                    { new Guid("fa60eb32-a8f7-4129-ac79-86db2b0c6e85"), "The spell is more difficult to counteract and resist, but the cost is increased to 3350gp.", 10, new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1") },
                    { new Guid("3ce62722-4290-4b4b-949f-d0698ff70202"), "The damage increases by 2d10.", 1, new Guid("8280e542-c9e9-41d9-b152-aff2f054d447") },
                    { new Guid("99a5bbf6-51c5-4e42-ba6b-e1155c40d500"), "The duration lasts until the next time you make your daily preparations, and you can target up to 10 creatures.", 8, new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647") },
                    { new Guid("461c1a6c-d9e9-4c24-82df-9799e0001811"), "Your battle form is Large and your fly Speed gains a +10-foot status bonus. You must have enough space to expand into or the spell is lost. You instead gain 10 temporary HP, attack modifier +18, damage bonus +8, and Acrobatics +20.", 5, new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9") },
                    { new Guid("5da315c4-0930-4154-803d-1d618e8073a4"), "The duration increases to 1 hour.", 4, new Guid("35ac23b0-0e3d-4aab-8217-116f931edcb7") },
                    { new Guid("62d6f3f0-5ae7-4ceb-b943-d716a9d05586"), "You can target up to 10 creatures. The extra material component affects targets to which it is anathema.", 9, new Guid("3a8c5edf-e86c-431a-a25a-bb90d590eb35") },
                    { new Guid("0b4eadbc-0ed2-444c-997f-0e248309b869"), "Your battle form is Huge, your fly Speed gains a +15-foot status bonus, and your attacks have 10-foot reach. You must have enough space to expand into or the spell is lost. You instead gain AC = 21 + your level, 15 temporary HP, attack modifier +21, damage bonus +4 and double damage dice (including persistent damage), and Acrobatics +23.", 6, new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9") },
                    { new Guid("070c4a22-2028-4361-89b5-ef690dd3fa6b"), "The spell’s duration increases to 1 hour. Roll 1d8 to determine the wall’s color; the results for 5–8 are below.A red, orange, yellow, or green wall deals an extra 10 damage.", 7, new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300") },
                    { new Guid("4a665729-f77d-4c8c-8f00-dd3fe078e3d8"), "The resistances increase by 2, and the weakness increases by 3.", 2, new Guid("41fcd185-b9ba-41aa-96cf-1a8bcb65a64d") },
                    { new Guid("63371eec-c1ea-4dcb-8c53-e72fe03224a8"), "You instead gain 10 temporary HP, AC = 17 + your level, attack modifier +14, damage bonus +5, and Athletics +14.", 3, new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d") },
                    { new Guid("ce2df890-5896-491e-a1f2-18a9808e1682"), "The initial damage increases by 2d8, and the persistent acid damage increases by 1d6.", 2, new Guid("9ff794c4-74a1-412e-9d44-06d64f1570b1") },
                    { new Guid("96d6be16-ee49-4b00-aa7e-7b364bd363bc"), "The damage increases by 1d6.", 1, new Guid("dcadfb92-e8c7-47a4-a6cc-4de6eefb7c3c") },
                    { new Guid("3a1aa8fe-d985-4af4-a664-e7ceed761d9d"), "The damage increases by 1d8.", 1, new Guid("54176cd6-c3a3-43fd-8d47-9283811b03bb") },
                    { new Guid("0433232e-b381-4a6d-bd3c-404bfdedb535"), "The damage increases by 2d6.", 1, new Guid("ea3e3b79-80ab-4ef4-9dc7-6fb38561a935") },
                    { new Guid("4e928728-b53f-43e2-acbe-7b93732500e9"), "The cold damage increases by 2d6, and the evil damage against celestials increases by 2d6.", 1, new Guid("fc8ec088-6c8d-4d90-9293-9fc0720a3855") },
                    { new Guid("62d0851a-cc5e-462c-aee1-1b5e812ac054"), "Your battle form is Large and your attacks have 10-foot reach. You must have enough space to expand into or the spell is lost. You instead gain 15 temporary HP, AC = 18 + your level, attack modifier +16, damage bonus +9, and Athletics +16.", 4, new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d") },
                    { new Guid("8fad2d3e-740c-4f51-bb8d-8abe84a24783"), "The duration lasts until the next time you make your daily preparations.", 4, new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647") },
                    { new Guid("730097a4-0886-4c81-a15e-b00fc7ec40c9"), "You can specify criteria for which creatures sound the alarm spell—for instance, orcs or masked people.", 3, new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa") },
                    { new Guid("7bd4ff03-9047-4baa-939e-312c7924b42d"), "Your battle form is Huge and your attacks have 15-foot reach. You must have enough space to expand into or the spell is lost. You instead gain 20 temporary HP, AC = 18 + your level, attack modifier +18, damage bonus +7 and double the number of damage dice, and Athletics +20.", 5, new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d") },
                    { new Guid("e7d4ce94-e923-43fb-bcc9-e34987534372"), "The damage increases by 1d12.", 1, new Guid("7ca414c2-6185-4817-b1d7-9692d7a4433a") },
                    { new Guid("84e120a3-6dd6-4348-9a07-934858f71840"), "The resistance increases by 3.", 2, new Guid("e130e307-ede2-4a68-9667-cfc482855d95") }
                });

            migrationBuilder.InsertData(
                table: "SpellRequirement",
                columns: new[] { "Id", "SpellId", "Text" },
                values: new object[,]
                {
                    { new Guid("5ece9a7b-d3b6-4cd5-bbf9-c5657ec5cd7f"), new Guid("a0dc825d-78c6-4464-a62e-17d7001c258e"), "Black Sapphire with a gp value of at least the target's level x100." },
                    { new Guid("87a3439f-f230-40e2-8b44-965944f2c288"), new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1"), "6 gp of ruby dust" },
                    { new Guid("c631f94d-c9e7-41d0-bf15-20d3afd682c2"), new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa"), "3 gp" },
                    { new Guid("7febd529-e31e-46b6-ab97-ed86dfeedf74"), new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa"), "Silver Bell" },
                    { new Guid("e1b278cb-b19d-416e-bb43-1fc017ff681a"), new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa"), "Focus" }
                });

            migrationBuilder.InsertData(
                table: "SpellSpellComponent",
                columns: new[] { "ComponentsId", "SpellsId" },
                values: new object[,]
                {
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("54176cd6-c3a3-43fd-8d47-9283811b03bb") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("e4568cde-13d1-4684-81b2-180bc291198f") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("6e689573-2fdb-409f-abd2-a27135775498") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("509c9a55-433c-4f99-8a7a-609d38f23ed1") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("4f77cd26-f3f0-4e6a-8424-b01480daadc4") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("4f77cd26-f3f0-4e6a-8424-b01480daadc4") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("509c9a55-433c-4f99-8a7a-609d38f23ed1") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("b6f25115-9358-44eb-bfc2-37b01c3863f4") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("236cd0a3-a07b-4c9f-ba11-e3c113d91634") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("54176cd6-c3a3-43fd-8d47-9283811b03bb") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("3e91401a-203c-4d1e-9a76-0012e2617cd8") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("236cd0a3-a07b-4c9f-ba11-e3c113d91634") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("b6f25115-9358-44eb-bfc2-37b01c3863f4") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("436d4b2a-846a-4ff1-ae57-63ecfe80f337") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("436d4b2a-846a-4ff1-ae57-63ecfe80f337") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("b7157338-c1de-4e79-a90c-e0f62abd709c") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("b7157338-c1de-4e79-a90c-e0f62abd709c") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("436d4b2a-846a-4ff1-ae57-63ecfe80f337") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("54176cd6-c3a3-43fd-8d47-9283811b03bb") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("2665ca32-131c-43cd-b30b-c763eb024a08") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("2665ca32-131c-43cd-b30b-c763eb024a08") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("3a320d74-73e9-40ab-a972-eb6b571f21fd") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("3a320d74-73e9-40ab-a972-eb6b571f21fd") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("e130e307-ede2-4a68-9667-cfc482855d95") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("e130e307-ede2-4a68-9667-cfc482855d95") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("7ebf76e9-a8fb-49a1-956c-f97f784dcbb9") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("dcadfb92-e8c7-47a4-a6cc-4de6eefb7c3c") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("dcadfb92-e8c7-47a4-a6cc-4de6eefb7c3c") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("51df17bf-ef57-4eed-973c-55cf33285b61") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("51df17bf-ef57-4eed-973c-55cf33285b61") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("66172098-6cdb-4587-89bb-24fe1a8faf7c") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("66172098-6cdb-4587-89bb-24fe1a8faf7c") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("e4568cde-13d1-4684-81b2-180bc291198f") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("7ebf76e9-a8fb-49a1-956c-f97f784dcbb9") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("b59d7490-542e-4d17-9463-2e384faf2c0f") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("3c902d87-38ff-4aad-acb3-266811986252") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("73180f19-0c26-4f90-b377-8ae1d3df6525") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("8280e542-c9e9-41d9-b152-aff2f054d447") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("9d06d9f1-deaf-4fd0-8963-9ca6f5a645fa") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("9d06d9f1-deaf-4fd0-8963-9ca6f5a645fa") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("8280e542-c9e9-41d9-b152-aff2f054d447") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("9ebcaed3-689b-4886-939d-a8b0399180c5") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("79fbdd8a-c496-4974-af00-14c3640841ab") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("79fbdd8a-c496-4974-af00-14c3640841ab") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("f708a194-3783-46f4-8cb0-bb512ed08727") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("73180f19-0c26-4f90-b377-8ae1d3df6525") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("55780227-9986-4a2e-aa35-93a105314818") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("31f6e676-dbee-4c8f-9f17-a842afab35e3") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("31f6e676-dbee-4c8f-9f17-a842afab35e3") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("31f6e676-dbee-4c8f-9f17-a842afab35e3") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("614267ca-482a-4435-bcea-127594ea342f") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("614267ca-482a-4435-bcea-127594ea342f") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("001dcfdb-d978-498b-a101-1d13c57b67f2") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("001dcfdb-d978-498b-a101-1d13c57b67f2") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("3e91401a-203c-4d1e-9a76-0012e2617cd8") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("3e91401a-203c-4d1e-9a76-0012e2617cd8") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("d8cf6802-13fb-4518-a463-538b28bed2da") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("d8cf6802-13fb-4518-a463-538b28bed2da") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("55780227-9986-4a2e-aa35-93a105314818") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("3c902d87-38ff-4aad-acb3-266811986252") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("9ebcaed3-689b-4886-939d-a8b0399180c5") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("9ebcaed3-689b-4886-939d-a8b0399180c5") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("b59d7490-542e-4d17-9463-2e384faf2c0f") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("54d80001-c58b-4524-b23d-3962bb5f7ed4") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("54d80001-c58b-4524-b23d-3962bb5f7ed4") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("9627d10b-e488-4299-9e1b-2c3a511ec007") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("9627d10b-e488-4299-9e1b-2c3a511ec007") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("a0dc825d-78c6-4464-a62e-17d7001c258e") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("8e4669af-e67c-42a4-bd0f-9e117496cb6c") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("8e4669af-e67c-42a4-bd0f-9e117496cb6c") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("5ca21ccd-2ccc-4900-99fe-40480d6103f2") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("5d1503f3-0176-4480-93b5-c4b4fef56dd3") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("3a8c5edf-e86c-431a-a25a-bb90d590eb35") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("5d1503f3-0176-4480-93b5-c4b4fef56dd3") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("2ef1bfc9-3ca3-45b8-804a-ba9d948224de") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("2ef1bfc9-3ca3-45b8-804a-ba9d948224de") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("5ca21ccd-2ccc-4900-99fe-40480d6103f2") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("41fcd185-b9ba-41aa-96cf-1a8bcb65a64d") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("41fcd185-b9ba-41aa-96cf-1a8bcb65a64d") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("c1546cbd-ec60-459f-b7f5-e29d51beb5f2") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("c1546cbd-ec60-459f-b7f5-e29d51beb5f2") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("05375af9-4bc5-4eab-8731-2fb74c2062d9") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("3a8c5edf-e86c-431a-a25a-bb90d590eb35") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("1e745c5e-5d8f-4abd-b66c-e0e582833257") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("1e745c5e-5d8f-4abd-b66c-e0e582833257") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("05375af9-4bc5-4eab-8731-2fb74c2062d9") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("5ca21ccd-2ccc-4900-99fe-40480d6103f2") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("a0dc825d-78c6-4464-a62e-17d7001c258e") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("6e689573-2fdb-409f-abd2-a27135775498") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("2a4b767b-27d0-4519-b1f7-c554837d0c73") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("db143e7b-8212-4350-a09f-09205811470e") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("2d8be059-3a79-4d4d-a7e8-31dee66680cc") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("2d8be059-3a79-4d4d-a7e8-31dee66680cc") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("068fc3bd-e1ac-4069-8a29-13bd1a0b92f2") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("068fc3bd-e1ac-4069-8a29-13bd1a0b92f2") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("94beacae-4765-499c-b93e-934fff8585a4") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("94beacae-4765-499c-b93e-934fff8585a4") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("94beacae-4765-499c-b93e-934fff8585a4") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("7ca414c2-6185-4817-b1d7-9692d7a4433a") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("1030f973-aee2-4c2f-8cc5-a98aa4594de4") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("7ca414c2-6185-4817-b1d7-9692d7a4433a") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("7b0f3283-1f79-4a64-a697-eb842bb776b2") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("7b0f3283-1f79-4a64-a697-eb842bb776b2") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("35ac23b0-0e3d-4aab-8217-116f931edcb7") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("35ac23b0-0e3d-4aab-8217-116f931edcb7") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("27b176c3-a4ac-425b-b7f1-9e6b7c25063f") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("2a4b767b-27d0-4519-b1f7-c554837d0c73") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("060ba321-f5b9-4ac8-907c-fec7bb740713") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("4d709d69-ddde-487c-94a3-c876b4e79969") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("4d709d69-ddde-487c-94a3-c876b4e79969") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("060ba321-f5b9-4ac8-907c-fec7bb740713") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("328dda55-0bc8-461f-a3d3-686df512438c") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("9ff794c4-74a1-412e-9d44-06d64f1570b1") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("db143e7b-8212-4350-a09f-09205811470e") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("fc8ec088-6c8d-4d90-9293-9fc0720a3855") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("6505b7e2-7c35-45ed-8fda-ff4bf3dd2822") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("6505b7e2-7c35-45ed-8fda-ff4bf3dd2822") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("fc8ec088-6c8d-4d90-9293-9fc0720a3855") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("f3fa6c93-ee1d-4da1-982d-55c015c0eeaa") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("f3fa6c93-ee1d-4da1-982d-55c015c0eeaa") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("35ac23b0-0e3d-4aab-8217-116f931edcb7") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("9ff794c4-74a1-412e-9d44-06d64f1570b1") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("1030f973-aee2-4c2f-8cc5-a98aa4594de4") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("3a2a1f6e-f8d9-465d-94cc-1253a5c42062") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("484d98ad-91d1-4b2d-86d0-ec997a6f772b") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("484d98ad-91d1-4b2d-86d0-ec997a6f772b") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("5c0b6313-4951-4dc4-9289-0ec20210643d") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("5c0b6313-4951-4dc4-9289-0ec20210643d") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("1030f973-aee2-4c2f-8cc5-a98aa4594de4") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("3a2a1f6e-f8d9-465d-94cc-1253a5c42062") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("2d0fa5a4-eab0-4eca-85cb-23241e5ef814") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("2d0fa5a4-eab0-4eca-85cb-23241e5ef814") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("af9903ec-8e9e-4752-bae4-042aca73f91a") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("ea3e3b79-80ab-4ef4-9dc7-6fb38561a935") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("af9903ec-8e9e-4752-bae4-042aca73f91a") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("af9903ec-8e9e-4752-bae4-042aca73f91a") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("ea3e3b79-80ab-4ef4-9dc7-6fb38561a935") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("c5bd7524-e3f5-46b6-b1de-527896978d1c") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("c5bd7524-e3f5-46b6-b1de-527896978d1c") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("eb816f67-17d1-439b-badb-2657b57f64e2") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("2c2d2218-3a46-4075-899c-c4e9353aaec3") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("484d98ad-91d1-4b2d-86d0-ec997a6f772b") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("fbb8d7cc-6793-484c-80a8-4fafb137e01e") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("328dda55-0bc8-461f-a3d3-686df512438c") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("eb816f67-17d1-439b-badb-2657b57f64e2") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("2c2d2218-3a46-4075-899c-c4e9353aaec3") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("311b0146-7b80-4594-800f-b0046237d47f") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("311b0146-7b80-4594-800f-b0046237d47f") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("b2cc63b2-466a-478a-b024-b785f2b722de") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("b2cc63b2-466a-478a-b024-b785f2b722de") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3") },
                    { new Guid("4a9cf550-0cb7-4df1-8519-45765fc23af3"), new Guid("311b0146-7b80-4594-800f-b0046237d47f") },
                    { new Guid("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3") },
                    { new Guid("8665739e-a938-4927-afb6-be0c2d15fdc0"), new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c") }
                });

            migrationBuilder.InsertData(
                table: "SpellTrait",
                columns: new[] { "SpellsId", "TraitsId" },
                values: new object[,]
                {
                    { new Guid("328dda55-0bc8-461f-a3d3-686df512438c"), new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b") },
                    { new Guid("328dda55-0bc8-461f-a3d3-686df512438c"), new Guid("e5b98ff4-8503-461c-870d-7b8c8e4811fa") },
                    { new Guid("001dcfdb-d978-498b-a101-1d13c57b67f2"), new Guid("d751d93f-cff9-448f-8ab0-9a3c07eacbef") },
                    { new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03"), new Guid("a23df7f5-acc6-4f87-9244-0fbbc77c70d2") },
                    { new Guid("31f6e676-dbee-4c8f-9f17-a842afab35e3"), new Guid("0c06a5b8-24e7-486b-bb98-91caef377013") },
                    { new Guid("8280e542-c9e9-41d9-b152-aff2f054d447"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("eb816f67-17d1-439b-badb-2657b57f64e2"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("9ebcaed3-689b-4886-939d-a8b0399180c5"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("db143e7b-8212-4350-a09f-09205811470e"), new Guid("ece55c2d-2715-4e67-aa1e-736c019e89a6") },
                    { new Guid("9ebcaed3-689b-4886-939d-a8b0399180c5"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("31f6e676-dbee-4c8f-9f17-a842afab35e3"), new Guid("a23df7f5-acc6-4f87-9244-0fbbc77c70d2") },
                    { new Guid("db143e7b-8212-4350-a09f-09205811470e"), new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b") },
                    { new Guid("eb816f67-17d1-439b-badb-2657b57f64e2"), new Guid("856db08f-edad-472b-b870-65a8f16252a5") },
                    { new Guid("db143e7b-8212-4350-a09f-09205811470e"), new Guid("9da1e40e-f9b8-4381-9167-229fee66f4f7") },
                    { new Guid("8280e542-c9e9-41d9-b152-aff2f054d447"), new Guid("856db08f-edad-472b-b870-65a8f16252a5") },
                    { new Guid("31f6e676-dbee-4c8f-9f17-a842afab35e3"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("5c0b6313-4951-4dc4-9289-0ec20210643d"), new Guid("d751d93f-cff9-448f-8ab0-9a3c07eacbef") },
                    { new Guid("05375af9-4bc5-4eab-8731-2fb74c2062d9"), new Guid("0c06a5b8-24e7-486b-bb98-91caef377013") },
                    { new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), new Guid("d751d93f-cff9-448f-8ab0-9a3c07eacbef") },
                    { new Guid("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"), new Guid("1a83b706-d9c1-4b46-bcf3-3c9bb82219ee") },
                    { new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3"), new Guid("9da1e40e-f9b8-4381-9167-229fee66f4f7") },
                    { new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3"), new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b") },
                    { new Guid("dcadfb92-e8c7-47a4-a6cc-4de6eefb7c3c"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("dcadfb92-e8c7-47a4-a6cc-4de6eefb7c3c"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("4ab38c95-8b8a-4f7c-b260-1b842a91ace3"), new Guid("30ed464b-6bf4-4a80-8c42-8bb95ecb751c") },
                    { new Guid("7ebf76e9-a8fb-49a1-956c-f97f784dcbb9"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("7b0f3283-1f79-4a64-a697-eb842bb776b2"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("fbb8d7cc-6793-484c-80a8-4fafb137e01e"), new Guid("7cb74b87-4e13-4d8c-afa5-da8cbe671bfc") },
                    { new Guid("5cffbfee-9c91-4c00-a8e5-d24c75200deb"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c"), new Guid("856db08f-edad-472b-b870-65a8f16252a5") },
                    { new Guid("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("e6dec1cf-3b35-4abc-9267-4a30e44df08c"), new Guid("44a15dce-b0cf-4d6a-a4be-92d759fdbaa3") },
                    { new Guid("5c0b6313-4951-4dc4-9289-0ec20210643d"), new Guid("7cb74b87-4e13-4d8c-afa5-da8cbe671bfc") },
                    { new Guid("6e689573-2fdb-409f-abd2-a27135775498"), new Guid("d751d93f-cff9-448f-8ab0-9a3c07eacbef") },
                    { new Guid("6e689573-2fdb-409f-abd2-a27135775498"), new Guid("33bf3198-48a1-4559-9a48-9881901f880b") },
                    { new Guid("fbb8d7cc-6793-484c-80a8-4fafb137e01e"), new Guid("6f187720-6664-44c6-8e09-2053ed1054d6") },
                    { new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03"), new Guid("9da1e40e-f9b8-4381-9167-229fee66f4f7") },
                    { new Guid("b6f25115-9358-44eb-bfc2-37b01c3863f4"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("7b0f3283-1f79-4a64-a697-eb842bb776b2"), new Guid("9da1e40e-f9b8-4381-9167-229fee66f4f7") },
                    { new Guid("05375af9-4bc5-4eab-8731-2fb74c2062d9"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("1e7838ee-f64d-4806-8d3d-e55ba4261c03"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("5ca21ccd-2ccc-4900-99fe-40480d6103f2"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("5ca21ccd-2ccc-4900-99fe-40480d6103f2"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("328dda55-0bc8-461f-a3d3-686df512438c"), new Guid("0cb3dbbc-941b-4e27-b46c-d0246dacc056") },
                    { new Guid("328dda55-0bc8-461f-a3d3-686df512438c"), new Guid("fc3cb057-dcb6-4508-915a-0abd25679211") },
                    { new Guid("9ff794c4-74a1-412e-9d44-06d64f1570b1"), new Guid("44a15dce-b0cf-4d6a-a4be-92d759fdbaa3") },
                    { new Guid("5d1503f3-0176-4480-93b5-c4b4fef56dd3"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("7b0f3283-1f79-4a64-a697-eb842bb776b2"), new Guid("c90d2554-1af6-45d7-9f20-f98aa0799887") },
                    { new Guid("9ff794c4-74a1-412e-9d44-06d64f1570b1"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("2d8be059-3a79-4d4d-a7e8-31dee66680cc"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), new Guid("d751d93f-cff9-448f-8ab0-9a3c07eacbef") },
                    { new Guid("9627d10b-e488-4299-9e1b-2c3a511ec007"), new Guid("ece55c2d-2715-4e67-aa1e-736c019e89a6") },
                    { new Guid("2d8be059-3a79-4d4d-a7e8-31dee66680cc"), new Guid("9da1e40e-f9b8-4381-9167-229fee66f4f7") },
                    { new Guid("2d8be059-3a79-4d4d-a7e8-31dee66680cc"), new Guid("23655aa4-871f-416f-be14-1fc03bedef16") },
                    { new Guid("9627d10b-e488-4299-9e1b-2c3a511ec007"), new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b") },
                    { new Guid("2d8be059-3a79-4d4d-a7e8-31dee66680cc"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("9ff794c4-74a1-412e-9d44-06d64f1570b1"), new Guid("856db08f-edad-472b-b870-65a8f16252a5") },
                    { new Guid("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"), new Guid("1a83b706-d9c1-4b46-bcf3-3c9bb82219ee") },
                    { new Guid("d8cf6802-13fb-4518-a463-538b28bed2da"), new Guid("4f8453ab-e7f8-4d2f-95e7-e0e53a32cbde") },
                    { new Guid("484d98ad-91d1-4b2d-86d0-ec997a6f772b"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("d8cf6802-13fb-4518-a463-538b28bed2da"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("068fc3bd-e1ac-4069-8a29-13bd1a0b92f2"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("7ca414c2-6185-4817-b1d7-9692d7a4433a"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("94beacae-4765-499c-b93e-934fff8585a4"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("7ca414c2-6185-4817-b1d7-9692d7a4433a"), new Guid("dc6ca4d1-85f2-4be9-bc39-9a48b943b392") },
                    { new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), new Guid("dc6ca4d1-85f2-4be9-bc39-9a48b943b392") },
                    { new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), new Guid("36d65d85-b689-46da-86b6-4f0838f296e6") },
                    { new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), new Guid("44a15dce-b0cf-4d6a-a4be-92d759fdbaa3") },
                    { new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), new Guid("689bc25d-de13-418c-8da2-a9280936359d") },
                    { new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), new Guid("d1aabc8c-b3fe-40eb-bfc2-ea72d3b7e0c0") },
                    { new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), new Guid("ae21e02b-11a1-4c53-96ec-5961beb2761d") },
                    { new Guid("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"), new Guid("7cb74b87-4e13-4d8c-afa5-da8cbe671bfc") },
                    { new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("d253d16d-cbac-4673-a25f-0a3c33173cd1"), new Guid("c90d2554-1af6-45d7-9f20-f98aa0799887") },
                    { new Guid("b2cc63b2-466a-478a-b024-b785f2b722de"), new Guid("ae21e02b-11a1-4c53-96ec-5961beb2761d") },
                    { new Guid("b2cc63b2-466a-478a-b024-b785f2b722de"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("3a2a1f6e-f8d9-465d-94cc-1253a5c42062"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("3a2a1f6e-f8d9-465d-94cc-1253a5c42062"), new Guid("be9994ab-79ef-4ec0-9761-492059b0083a") },
                    { new Guid("3a2a1f6e-f8d9-465d-94cc-1253a5c42062"), new Guid("1ee8c64b-ad34-4b3b-a01c-a1057eea01f6") },
                    { new Guid("3a2a1f6e-f8d9-465d-94cc-1253a5c42062"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("2d0fa5a4-eab0-4eca-85cb-23241e5ef814"), new Guid("6f187720-6664-44c6-8e09-2053ed1054d6") },
                    { new Guid("ea3e3b79-80ab-4ef4-9dc7-6fb38561a935"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("ea3e3b79-80ab-4ef4-9dc7-6fb38561a935"), new Guid("d1aabc8c-b3fe-40eb-bfc2-ea72d3b7e0c0") },
                    { new Guid("c5bd7524-e3f5-46b6-b1de-527896978d1c"), new Guid("ae21e02b-11a1-4c53-96ec-5961beb2761d") },
                    { new Guid("c5bd7524-e3f5-46b6-b1de-527896978d1c"), new Guid("6f187720-6664-44c6-8e09-2053ed1054d6") },
                    { new Guid("27b176c3-a4ac-425b-b7f1-9e6b7c25063f"), new Guid("06f2cf99-b089-4e34-b443-53028fdc2ae0") },
                    { new Guid("311b0146-7b80-4594-800f-b0046237d47f"), new Guid("6f187720-6664-44c6-8e09-2053ed1054d6") },
                    { new Guid("27b176c3-a4ac-425b-b7f1-9e6b7c25063f"), new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b") },
                    { new Guid("27b176c3-a4ac-425b-b7f1-9e6b7c25063f"), new Guid("ece55c2d-2715-4e67-aa1e-736c019e89a6") },
                    { new Guid("068fc3bd-e1ac-4069-8a29-13bd1a0b92f2"), new Guid("1ee8c64b-ad34-4b3b-a01c-a1057eea01f6") },
                    { new Guid("b7157338-c1de-4e79-a90c-e0f62abd709c"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("068fc3bd-e1ac-4069-8a29-13bd1a0b92f2"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647"), new Guid("1ee8c64b-ad34-4b3b-a01c-a1057eea01f6") },
                    { new Guid("af9903ec-8e9e-4752-bae4-042aca73f91a"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("af9903ec-8e9e-4752-bae4-042aca73f91a"), new Guid("f91abbe0-0bec-4278-99d0-b12f044f8061") },
                    { new Guid("2c2d2218-3a46-4075-899c-c4e9353aaec3"), new Guid("7f9fe1cb-c607-44c3-8f1a-b26d508cfce6") },
                    { new Guid("2c2d2218-3a46-4075-899c-c4e9353aaec3"), new Guid("e2bb08cb-cf59-4e29-8738-52c751405fb0") },
                    { new Guid("35ac23b0-0e3d-4aab-8217-116f931edcb7"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("35ac23b0-0e3d-4aab-8217-116f931edcb7"), new Guid("0c06a5b8-24e7-486b-bb98-91caef377013") },
                    { new Guid("1030f973-aee2-4c2f-8cc5-a98aa4594de4"), new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b") },
                    { new Guid("1030f973-aee2-4c2f-8cc5-a98aa4594de4"), new Guid("39e2298b-bab0-49b7-8a0a-4ac1145611b0") },
                    { new Guid("1030f973-aee2-4c2f-8cc5-a98aa4594de4"), new Guid("f1f5c47a-fec2-4983-8229-3c4e8b43f0b5") },
                    { new Guid("f3fa6c93-ee1d-4da1-982d-55c015c0eeaa"), new Guid("6f187720-6664-44c6-8e09-2053ed1054d6") },
                    { new Guid("f3fa6c93-ee1d-4da1-982d-55c015c0eeaa"), new Guid("340e83a5-5a6e-4a5f-8658-7aede58da5a9") },
                    { new Guid("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("060ba321-f5b9-4ac8-907c-fec7bb740713"), new Guid("7f9fe1cb-c607-44c3-8f1a-b26d508cfce6") },
                    { new Guid("060ba321-f5b9-4ac8-907c-fec7bb740713"), new Guid("e2bb08cb-cf59-4e29-8738-52c751405fb0") },
                    { new Guid("060ba321-f5b9-4ac8-907c-fec7bb740713"), new Guid("be9994ab-79ef-4ec0-9761-492059b0083a") },
                    { new Guid("fc8ec088-6c8d-4d90-9293-9fc0720a3855"), new Guid("fc3cb057-dcb6-4508-915a-0abd25679211") },
                    { new Guid("4d709d69-ddde-487c-94a3-c876b4e79969"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("4d709d69-ddde-487c-94a3-c876b4e79969"), new Guid("44a18bec-0799-41a7-9b07-16113bb0623f") },
                    { new Guid("4d709d69-ddde-487c-94a3-c876b4e79969"), new Guid("315bf80d-594e-46ca-944e-cb8287df46fa") },
                    { new Guid("4d709d69-ddde-487c-94a3-c876b4e79969"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("fc8ec088-6c8d-4d90-9293-9fc0720a3855"), new Guid("856db08f-edad-472b-b870-65a8f16252a5") },
                    { new Guid("fc8ec088-6c8d-4d90-9293-9fc0720a3855"), new Guid("aa2b017d-2e8c-460a-9069-6bf61b69dd72") },
                    { new Guid("fc8ec088-6c8d-4d90-9293-9fc0720a3855"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("fc8ec088-6c8d-4d90-9293-9fc0720a3855"), new Guid("36d65d85-b689-46da-86b6-4f0838f296e6") },
                    { new Guid("6505b7e2-7c35-45ed-8fda-ff4bf3dd2822"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("2a4b767b-27d0-4519-b1f7-c554837d0c73"), new Guid("36d65d85-b689-46da-86b6-4f0838f296e6") },
                    { new Guid("2a4b767b-27d0-4519-b1f7-c554837d0c73"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647"), new Guid("be9994ab-79ef-4ec0-9761-492059b0083a") },
                    { new Guid("41b3515e-c59f-4ac6-92a2-ef16195cd647"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("d8cf6802-13fb-4518-a463-538b28bed2da"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("b7157338-c1de-4e79-a90c-e0f62abd709c"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("4f77cd26-f3f0-4e6a-8424-b01480daadc4"), new Guid("d748ac0d-6af3-4475-af4e-a72455960fe0") },
                    { new Guid("8e4669af-e67c-42a4-bd0f-9e117496cb6c"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("8e4669af-e67c-42a4-bd0f-9e117496cb6c"), new Guid("a23df7f5-acc6-4f87-9244-0fbbc77c70d2") },
                    { new Guid("41fcd185-b9ba-41aa-96cf-1a8bcb65a64d"), new Guid("2bc07fcc-2113-4b39-a257-17851f1f216d") },
                    { new Guid("41fcd185-b9ba-41aa-96cf-1a8bcb65a64d"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("2ef1bfc9-3ca3-45b8-804a-ba9d948224de"), new Guid("0c06a5b8-24e7-486b-bb98-91caef377013") },
                    { new Guid("2ef1bfc9-3ca3-45b8-804a-ba9d948224de"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("2ef1bfc9-3ca3-45b8-804a-ba9d948224de"), new Guid("a23df7f5-acc6-4f87-9244-0fbbc77c70d2") },
                    { new Guid("c1546cbd-ec60-459f-b7f5-e29d51beb5f2"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("3a8c5edf-e86c-431a-a25a-bb90d590eb35"), new Guid("be9994ab-79ef-4ec0-9761-492059b0083a") },
                    { new Guid("3a8c5edf-e86c-431a-a25a-bb90d590eb35"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("1e745c5e-5d8f-4abd-b66c-e0e582833257"), new Guid("0c06a5b8-24e7-486b-bb98-91caef377013") },
                    { new Guid("1e745c5e-5d8f-4abd-b66c-e0e582833257"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("9d06d9f1-deaf-4fd0-8963-9ca6f5a645fa"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("73180f19-0c26-4f90-b377-8ae1d3df6525"), new Guid("6f187720-6664-44c6-8e09-2053ed1054d6") },
                    { new Guid("73180f19-0c26-4f90-b377-8ae1d3df6525"), new Guid("340e83a5-5a6e-4a5f-8658-7aede58da5a9") },
                    { new Guid("9d06d9f1-deaf-4fd0-8963-9ca6f5a645fa"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("79fbdd8a-c496-4974-af00-14c3640841ab"), new Guid("1a83b706-d9c1-4b46-bcf3-3c9bb82219ee") },
                    { new Guid("79fbdd8a-c496-4974-af00-14c3640841ab"), new Guid("be9994ab-79ef-4ec0-9761-492059b0083a") },
                    { new Guid("79fbdd8a-c496-4974-af00-14c3640841ab"), new Guid("d751d93f-cff9-448f-8ab0-9a3c07eacbef") },
                    { new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), new Guid("1a83b706-d9c1-4b46-bcf3-3c9bb82219ee") },
                    { new Guid("f708a194-3783-46f4-8cb0-bb512ed08727"), new Guid("d751d93f-cff9-448f-8ab0-9a3c07eacbef") },
                    { new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d"), new Guid("7684fa81-e3a5-4224-8d57-bc61df53d54a") },
                    { new Guid("cfb3f479-70d2-4275-890f-27920ec70d3d"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("55780227-9986-4a2e-aa35-93a105314818"), new Guid("d751d93f-cff9-448f-8ab0-9a3c07eacbef") },
                    { new Guid("55780227-9986-4a2e-aa35-93a105314818"), new Guid("1a83b706-d9c1-4b46-bcf3-3c9bb82219ee") },
                    { new Guid("3e91401a-203c-4d1e-9a76-0012e2617cd8"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("614267ca-482a-4435-bcea-127594ea342f"), new Guid("7f9fe1cb-c607-44c3-8f1a-b26d508cfce6") },
                    { new Guid("3e91401a-203c-4d1e-9a76-0012e2617cd8"), new Guid("f2810f2b-6f8a-4fb1-b00f-a9d307f97eff") },
                    { new Guid("d8cf6802-13fb-4518-a463-538b28bed2da"), new Guid("0c06a5b8-24e7-486b-bb98-91caef377013") },
                    { new Guid("8e4669af-e67c-42a4-bd0f-9e117496cb6c"), new Guid("0c06a5b8-24e7-486b-bb98-91caef377013") },
                    { new Guid("484d98ad-91d1-4b2d-86d0-ec997a6f772b"), new Guid("f91abbe0-0bec-4278-99d0-b12f044f8061") },
                    { new Guid("a0dc825d-78c6-4464-a62e-17d7001c258e"), new Guid("0c06a5b8-24e7-486b-bb98-91caef377013") },
                    { new Guid("eb816f67-17d1-439b-badb-2657b57f64e2"), new Guid("9da1e40e-f9b8-4381-9167-229fee66f4f7") },
                    { new Guid("e4568cde-13d1-4684-81b2-180bc291198f"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("e4568cde-13d1-4684-81b2-180bc291198f"), new Guid("315bf80d-594e-46ca-944e-cb8287df46fa") },
                    { new Guid("e4568cde-13d1-4684-81b2-180bc291198f"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("e130e307-ede2-4a68-9667-cfc482855d95"), new Guid("6f187720-6664-44c6-8e09-2053ed1054d6") },
                    { new Guid("2665ca32-131c-43cd-b30b-c763eb024a08"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("2665ca32-131c-43cd-b30b-c763eb024a08"), new Guid("1ee8c64b-ad34-4b3b-a01c-a1057eea01f6") },
                    { new Guid("2665ca32-131c-43cd-b30b-c763eb024a08"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("3a320d74-73e9-40ab-a972-eb6b571f21fd"), new Guid("be9994ab-79ef-4ec0-9761-492059b0083a") },
                    { new Guid("4f77cd26-f3f0-4e6a-8424-b01480daadc4"), new Guid("7f9fe1cb-c607-44c3-8f1a-b26d508cfce6") },
                    { new Guid("3a320d74-73e9-40ab-a972-eb6b571f21fd"), new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b") },
                    { new Guid("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e"), new Guid("aa2b017d-2e8c-460a-9069-6bf61b69dd72") },
                    { new Guid("54d80001-c58b-4524-b23d-3962bb5f7ed4"), new Guid("a23df7f5-acc6-4f87-9244-0fbbc77c70d2") },
                    { new Guid("e4568cde-13d1-4684-81b2-180bc291198f"), new Guid("0c06a5b8-24e7-486b-bb98-91caef377013") },
                    { new Guid("51df17bf-ef57-4eed-973c-55cf33285b61"), new Guid("2cbfa741-d7b5-465c-98b4-7a6bceae533e") },
                    { new Guid("54176cd6-c3a3-43fd-8d47-9283811b03bb"), new Guid("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49") },
                    { new Guid("54176cd6-c3a3-43fd-8d47-9283811b03bb"), new Guid("e55f102e-414e-4210-b1b3-97d8c26bab6a") },
                    { new Guid("66172098-6cdb-4587-89bb-24fe1a8faf7c"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("509c9a55-433c-4f99-8a7a-609d38f23ed1"), new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b") },
                    { new Guid("436d4b2a-846a-4ff1-ae57-63ecfe80f337"), new Guid("6f187720-6664-44c6-8e09-2053ed1054d6") },
                    { new Guid("236cd0a3-a07b-4c9f-ba11-e3c113d91634"), new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b") },
                    { new Guid("236cd0a3-a07b-4c9f-ba11-e3c113d91634"), new Guid("f1f5c47a-fec2-4983-8229-3c4e8b43f0b5") },
                    { new Guid("b59d7490-542e-4d17-9463-2e384faf2c0f"), new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b") },
                    { new Guid("3c902d87-38ff-4aad-acb3-266811986252"), new Guid("c499214b-94fc-4103-8c7c-6f7a56b5c980") },
                    { new Guid("a0dc825d-78c6-4464-a62e-17d7001c258e"), new Guid("fc3cb057-dcb6-4508-915a-0abd25679211") },
                    { new Guid("a0dc825d-78c6-4464-a62e-17d7001c258e"), new Guid("2d643d25-b9aa-4544-b482-04b3475eb82b") },
                    { new Guid("54d80001-c58b-4524-b23d-3962bb5f7ed4"), new Guid("0c06a5b8-24e7-486b-bb98-91caef377013") },
                    { new Guid("54d80001-c58b-4524-b23d-3962bb5f7ed4"), new Guid("5bce1594-6c07-460f-b306-0db1fa30833b") },
                    { new Guid("51df17bf-ef57-4eed-973c-55cf33285b61"), new Guid("e7fd1927-8c01-4945-899e-a99d2e44662a") },
                    { new Guid("e130e307-ede2-4a68-9667-cfc482855d95"), new Guid("340e83a5-5a6e-4a5f-8658-7aede58da5a9") }
                });

            migrationBuilder.InsertData(
                table: "SpellTrigger",
                columns: new[] { "Id", "SpellId", "Text" },
                values: new object[,]
                {
                    { new Guid("04745169-cdce-4409-8caf-10a348a60d93"), new Guid("fbb8d7cc-6793-484c-80a8-4fafb137e01e"), "A creature within range enters an environment where it can't breathe." },
                    { new Guid("8d805c41-9deb-4eee-b888-21aefafeba78"), new Guid("dcadfb92-e8c7-47a4-a6cc-4de6eefb7c3c"), "A creature performs an act anathema to your deity." },
                    { new Guid("3992996d-8346-4d1b-9e96-13a13a9139bd"), new Guid("27b176c3-a4ac-425b-b7f1-9e6b7c25063f"), "A living creature within range would die." }
                });

            migrationBuilder.InsertData(
                table: "FeatEffect",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrFeatEffectId", "ProficiencyId", "TriggeredAtLevel" },
                values: new object[,]
                {
                    { new Guid("43501d01-6d1e-497d-9cf8-81c0a0266232"), new Guid("43501d01-6d1e-497d-9cf8-81c0a0266232"), "GainLoreEffect", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null },
                    { new Guid("aab01fbb-7034-4f04-b135-dcaecd6e765a"), new Guid("aab01fbb-7034-4f04-b135-dcaecd6e765a"), "GainLoreEffect", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), 3 },
                    { new Guid("6634aaf1-a340-4b96-a815-8227dcffa9e5"), new Guid("6634aaf1-a340-4b96-a815-8227dcffa9e5"), "GainLoreEffect", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), 7 },
                    { new Guid("a7158664-5a5e-4ca9-af4d-fd6d5e183da5"), new Guid("a7158664-5a5e-4ca9-af4d-fd6d5e183da5"), "GainLoreEffect", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), 15 }
                });

            migrationBuilder.InsertData(
                table: "FeatEffect",
                columns: new[] { "Id", "BindingId", "Discriminator", "HeritageRarityId", "OrFeatEffectId", "TriggeredAtLevel" },
                values: new object[] { new Guid("967c98bc-088c-4fb7-9d44-ff7a6f90f506"), new Guid("967c98bc-088c-4fb7-9d44-ff7a6f90f506"), "GainHeritageEffect", new Guid("dff7388d-fd99-4a7d-8d0b-3d9b18dcb807"), null, null });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[] { new Guid("f89492d8-f55d-445c-85a8-cd34e13549ee"), new Guid("f89492d8-f55d-445c-85a8-cd34e13549ee"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("2f33e759-98f4-4a19-a955-e2133197de04") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId" },
                values: new object[] { new Guid("e8a334d7-c372-4879-a05b-bb51803deb56"), new Guid("e8a334d7-c372-4879-a05b-bb51803deb56"), "OrPrerequisite", null });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[] { new Guid("3d77f183-bb10-436d-b664-bf54056b35fd"), new Guid("3d77f183-bb10-436d-b664-bf54056b35fd"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId" },
                values: new object[] { new Guid("769a8ff4-92c8-4d6c-952c-1ec417c687a0"), new Guid("769a8ff4-92c8-4d6c-952c-1ec417c687a0"), "OrPrerequisite", null });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("850cf013-7103-4c37-8bb9-b1a66c3fb583"), new Guid("850cf013-7103-4c37-8bb9-b1a66c3fb583"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("bef3fdab-348a-4024-9095-1ab69ded3fed") },
                    { new Guid("8c0101c8-da77-49a0-b727-b56b58eafbcc"), new Guid("8c0101c8-da77-49a0-b727-b56b58eafbcc"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708") },
                    { new Guid("801e0541-1712-48b6-9d6a-a91a32a677e6"), new Guid("801e0541-1712-48b6-9d6a-a91a32a677e6"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("a14f7dbb-8a76-4b6e-8e67-6adb4f1b39b2") },
                    { new Guid("7026b01b-cf60-4cf1-a4c7-e10bed0e58f1"), new Guid("7026b01b-cf60-4cf1-a4c7-e10bed0e58f1"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("ca854fef-a519-472f-badd-f677cd8871fc") },
                    { new Guid("b3ffd080-e43c-477d-8906-54ac33624cff"), new Guid("b3ffd080-e43c-477d-8906-54ac33624cff"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("252ee579-951c-414e-bb69-7d2dfc324280") },
                    { new Guid("55c2a3ac-ec97-4882-b7a1-af9650b2b4d8"), new Guid("55c2a3ac-ec97-4882-b7a1-af9650b2b4d8"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708") },
                    { new Guid("ba0d0a02-d876-441f-9226-f270c0ed0fab"), new Guid("ba0d0a02-d876-441f-9226-f270c0ed0fab"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("13d2e35c-3829-4bab-85c1-de00ff96248a") },
                    { new Guid("ab631681-034a-4ea2-a0fd-b847e16c7f1d"), new Guid("ab631681-034a-4ea2-a0fd-b847e16c7f1d"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708") },
                    { new Guid("05e666ea-feb4-4bf6-8d68-098d8435c5ae"), new Guid("05e666ea-feb4-4bf6-8d68-098d8435c5ae"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("ca854fef-a519-472f-badd-f677cd8871fc") },
                    { new Guid("a153e8ba-11f0-417b-ae6d-52be52035560"), new Guid("a153e8ba-11f0-417b-ae6d-52be52035560"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("d8fd543c-7284-451d-8882-583970e9d917") },
                    { new Guid("f43e37fd-33cb-451e-89c2-a9e45e351308"), new Guid("f43e37fd-33cb-451e-89c2-a9e45e351308"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("641be10d-b069-45e9-b890-7f1254cd042c") },
                    { new Guid("61cadcf1-7ecf-43fc-b421-523f0afa57f8"), new Guid("61cadcf1-7ecf-43fc-b421-523f0afa57f8"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("feb60159-48a5-4164-b2e2-54b1f0a52a26") },
                    { new Guid("8f8b340d-5aad-41ac-a4f7-160fa57e0dff"), new Guid("8f8b340d-5aad-41ac-a4f7-160fa57e0dff"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("13d2e35c-3829-4bab-85c1-de00ff96248a") },
                    { new Guid("56bb7cdd-e5b9-4468-b29c-62dc359e7ee3"), new Guid("56bb7cdd-e5b9-4468-b29c-62dc359e7ee3"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("3707c645-9e77-4eb7-bf63-f4d65f471f25") },
                    { new Guid("620a99f0-9377-498b-a4cb-590441e62b51"), new Guid("620a99f0-9377-498b-a4cb-590441e62b51"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("641be10d-b069-45e9-b890-7f1254cd042c") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId" },
                values: new object[] { new Guid("7478eed3-36c1-4a1d-a247-21badb079eec"), new Guid("7478eed3-36c1-4a1d-a247-21badb079eec"), "OrPrerequisite", null });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("388aa336-39bb-4172-afcf-ace1e855ee81"), new Guid("388aa336-39bb-4172-afcf-ace1e855ee81"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("bef3fdab-348a-4024-9095-1ab69ded3fed") },
                    { new Guid("bf1b0a30-16b8-401c-bc11-83ddb3de79a8"), new Guid("bf1b0a30-16b8-401c-bc11-83ddb3de79a8"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("2f33e759-98f4-4a19-a955-e2133197de04") },
                    { new Guid("f2d84378-ac58-4aa1-a32c-5dd948594b61"), new Guid("f2d84378-ac58-4aa1-a32c-5dd948594b61"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("2f33e759-98f4-4a19-a955-e2133197de04") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredFeatId" },
                values: new object[] { new Guid("493d56f0-7760-44fd-948c-20bad99cdf33"), new Guid("493d56f0-7760-44fd-948c-20bad99cdf33"), "FeatPrerequisite", null, new Guid("d1f81e6f-f97f-4bf3-8ddb-7db5ff7c351c") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("fbc70e79-8d3d-4b12-9fe2-f60f7a3fe5f3"), new Guid("fbc70e79-8d3d-4b12-9fe2-f60f7a3fe5f3"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("ca854fef-a519-472f-badd-f677cd8871fc") },
                    { new Guid("080c34b7-ec47-4f28-a240-e4beb705265f"), new Guid("080c34b7-ec47-4f28-a240-e4beb705265f"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708") },
                    { new Guid("63790dc9-79b8-48b9-91c3-351c3498de27"), new Guid("63790dc9-79b8-48b9-91c3-351c3498de27"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("b64e4795-0efe-4cf5-82e3-f4219c041137") },
                    { new Guid("83519dcb-ddc3-4a7f-b404-b6822034a00e"), new Guid("83519dcb-ddc3-4a7f-b404-b6822034a00e"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("641be10d-b069-45e9-b890-7f1254cd042c") },
                    { new Guid("8d68493f-4f66-4ebb-aa54-c5fed2ae86b6"), new Guid("8d68493f-4f66-4ebb-aa54-c5fed2ae86b6"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("d8fd543c-7284-451d-8882-583970e9d917") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId" },
                values: new object[] { new Guid("8cbd0753-5757-4b8b-b134-4a9aa2196e79"), new Guid("8cbd0753-5757-4b8b-b134-4a9aa2196e79"), "OrPrerequisite", null });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("8954ba73-8dcd-4563-8ee4-ce46f9f24726"), new Guid("8954ba73-8dcd-4563-8ee4-ce46f9f24726"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("3707c645-9e77-4eb7-bf63-f4d65f471f25") },
                    { new Guid("53cb716d-9671-4fe1-9c80-96d7dad779ca"), new Guid("53cb716d-9671-4fe1-9c80-96d7dad779ca"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("a14f7dbb-8a76-4b6e-8e67-6adb4f1b39b2") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId" },
                values: new object[] { new Guid("60e48bf0-f1a9-4020-be4d-3bff9e62499b"), new Guid("60e48bf0-f1a9-4020-be4d-3bff9e62499b"), "OrPrerequisite", null });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("80ac8e37-d1bd-4a89-857a-fdc581aa0547"), new Guid("80ac8e37-d1bd-4a89-857a-fdc581aa0547"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("ca854fef-a519-472f-badd-f677cd8871fc") },
                    { new Guid("c999f2ff-0c41-4fa7-99fb-29c166253148"), new Guid("c999f2ff-0c41-4fa7-99fb-29c166253148"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("b64e4795-0efe-4cf5-82e3-f4219c041137") },
                    { new Guid("d0dafb67-0f82-4c67-866f-75ab3b88580f"), new Guid("d0dafb67-0f82-4c67-866f-75ab3b88580f"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708") },
                    { new Guid("747c834b-3909-4dd3-8396-8e1c6353f873"), new Guid("747c834b-3909-4dd3-8396-8e1c6353f873"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b41f214e-5d45-46fe-8495-263c3d117a86") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredProficiencyId" },
                values: new object[] { new Guid("121e5838-bd62-46a7-a282-3e096dd7d271"), new Guid("121e5838-bd62-46a7-a282-3e096dd7d271"), "LorePrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("3bf369c3-0238-4948-9eee-6c951a87ae80"), new Guid("3bf369c3-0238-4948-9eee-6c951a87ae80"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("6f23369f-e91f-4472-a254-648ba3ed1850") },
                    { new Guid("52574087-b011-4c5b-9fcb-6e22f11c6091"), new Guid("52574087-b011-4c5b-9fcb-6e22f11c6091"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708") },
                    { new Guid("063735a0-a7f9-4165-aa97-74c04557ae1f"), new Guid("063735a0-a7f9-4165-aa97-74c04557ae1f"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708") },
                    { new Guid("878125cb-4413-4304-826e-2a6f9f1e1351"), new Guid("878125cb-4413-4304-826e-2a6f9f1e1351"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("a14f7dbb-8a76-4b6e-8e67-6adb4f1b39b2") },
                    { new Guid("5931bcf3-afbb-4d12-80ad-f47dc14ac075"), new Guid("5931bcf3-afbb-4d12-80ad-f47dc14ac075"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("252ee579-951c-414e-bb69-7d2dfc324280") },
                    { new Guid("38a9dc61-555e-48fb-a398-f72fcb139a55"), new Guid("38a9dc61-555e-48fb-a398-f72fcb139a55"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("d8fd543c-7284-451d-8882-583970e9d917") },
                    { new Guid("48f78d64-fa2b-465d-83bb-b7b3d82d7709"), new Guid("48f78d64-fa2b-465d-83bb-b7b3d82d7709"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("252ee579-951c-414e-bb69-7d2dfc324280") },
                    { new Guid("4d47f7e7-0e9c-41d8-8922-c2cb2cdc19cf"), new Guid("4d47f7e7-0e9c-41d8-8922-c2cb2cdc19cf"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("d8fd543c-7284-451d-8882-583970e9d917") },
                    { new Guid("58a9af14-93bc-4de1-b290-645b961952a1"), new Guid("58a9af14-93bc-4de1-b290-645b961952a1"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("ca854fef-a519-472f-badd-f677cd8871fc") },
                    { new Guid("c5fb8477-fe1c-40d6-b030-38bd9e545309"), new Guid("c5fb8477-fe1c-40d6-b030-38bd9e545309"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("6a672190-7918-4fbd-a2d7-2d69f9d2a794") },
                    { new Guid("7417ee71-aa5a-4d7e-89f4-a7c2f1fbb3f0"), new Guid("7417ee71-aa5a-4d7e-89f4-a7c2f1fbb3f0"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("641be10d-b069-45e9-b890-7f1254cd042c") },
                    { new Guid("bcd03bec-9864-4a38-a752-4e59acd26dc2"), new Guid("bcd03bec-9864-4a38-a752-4e59acd26dc2"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("13d2e35c-3829-4bab-85c1-de00ff96248a") },
                    { new Guid("68ff9988-9cbf-493c-ac08-d3ede1bef387"), new Guid("68ff9988-9cbf-493c-ac08-d3ede1bef387"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("bef3fdab-348a-4024-9095-1ab69ded3fed") },
                    { new Guid("331e4a38-698f-4066-bd28-e42f80b1368d"), new Guid("331e4a38-698f-4066-bd28-e42f80b1368d"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("bef3fdab-348a-4024-9095-1ab69ded3fed") },
                    { new Guid("e63447fc-7fdf-4723-be38-734253bb6e15"), new Guid("e63447fc-7fdf-4723-be38-734253bb6e15"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("2f33e759-98f4-4a19-a955-e2133197de04") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredStatId", "RequiredStatValue" },
                values: new object[] { new Guid("ab0d488c-fa87-4289-93f6-91df2166f822"), new Guid("ab0d488c-fa87-4289-93f6-91df2166f822"), "StatPrerequisite", null, new Guid("37406a59-0dd9-4766-8713-33b13b7740fd"), 12 });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[] { new Guid("ca583e97-25e0-48a9-a63e-c2409c37f4f7"), new Guid("ca583e97-25e0-48a9-a63e-c2409c37f4f7"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("ab6c56d1-8f95-45db-b4a1-6bae20e30c47") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredFeatId" },
                values: new object[] { new Guid("fe2db99c-0cb7-491a-bf8c-edcf43c84c46"), new Guid("fe2db99c-0cb7-491a-bf8c-edcf43c84c46"), "FeatPrerequisite", null, new Guid("3539bdbe-8e7f-45c0-a094-649d85d3adca") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[] { new Guid("9e063be7-70e3-495c-a14b-42ccfeb7ba35"), new Guid("9e063be7-70e3-495c-a14b-42ccfeb7ba35"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("252ee579-951c-414e-bb69-7d2dfc324280") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredProficiencyId" },
                values: new object[,]
                {
                    { new Guid("526aa978-d5c8-4482-a522-73605e128b2c"), new Guid("526aa978-d5c8-4482-a522-73605e128b2c"), "LorePrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb") },
                    { new Guid("e412585e-1ba6-4f86-9c06-7f7ce9ae82f9"), new Guid("e412585e-1ba6-4f86-9c06-7f7ce9ae82f9"), "LorePrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[] { new Guid("3e5994d8-c6c5-43fb-acb3-1654a1850197"), new Guid("3e5994d8-c6c5-43fb-acb3-1654a1850197"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("eeb5a099-361f-41ab-aafd-7672f47bf9c3") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RecallKnowledgePrerequisite_RequiredProficiencyId", "RequiresAssurance" },
                values: new object[] { new Guid("a85e2c74-32bb-42f4-b3bd-dd42dd68fdc0"), new Guid("a85e2c74-32bb-42f4-b3bd-dd42dd68fdc0"), "RecallKnowledgePrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), false });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("bfeb1d14-08a6-4121-b836-2f4f76339d3e"), new Guid("bfeb1d14-08a6-4121-b836-2f4f76339d3e"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("6a672190-7918-4fbd-a2d7-2d69f9d2a794") },
                    { new Guid("701fc8e3-f113-4fcb-b2bb-1e98a70060bc"), new Guid("701fc8e3-f113-4fcb-b2bb-1e98a70060bc"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("bef3fdab-348a-4024-9095-1ab69ded3fed") },
                    { new Guid("948b49bd-4759-47e9-924c-f0655daf58bd"), new Guid("948b49bd-4759-47e9-924c-f0655daf58bd"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("641be10d-b069-45e9-b890-7f1254cd042c") },
                    { new Guid("a1321519-14ba-4357-bae3-9bdb828a3e63"), new Guid("a1321519-14ba-4357-bae3-9bdb828a3e63"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("b64e4795-0efe-4cf5-82e3-f4219c041137") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredFeatId" },
                values: new object[] { new Guid("ee3c490c-28f3-410a-bce3-c7de7c756ff8"), new Guid("ee3c490c-28f3-410a-bce3-c7de7c756ff8"), "FeatPrerequisite", null, new Guid("5c26de36-847d-4a16-8871-0a2016fdfacc") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("c7af13d6-533f-4d31-b058-a16371e5f7fc"), new Guid("c7af13d6-533f-4d31-b058-a16371e5f7fc"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("641be10d-b069-45e9-b890-7f1254cd042c") },
                    { new Guid("89f13323-62f1-4f79-ae26-dfb3dd7edeec"), new Guid("89f13323-62f1-4f79-ae26-dfb3dd7edeec"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("2f33e759-98f4-4a19-a955-e2133197de04") },
                    { new Guid("b25cd8ca-09c2-421c-9fba-b012a04e9085"), new Guid("b25cd8ca-09c2-421c-9fba-b012a04e9085"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708") },
                    { new Guid("56e776af-2740-4dc6-b0ce-d1d31abcea9f"), new Guid("56e776af-2740-4dc6-b0ce-d1d31abcea9f"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("252ee579-951c-414e-bb69-7d2dfc324280") },
                    { new Guid("638cc413-e502-4f9c-9183-da9958c38df9"), new Guid("638cc413-e502-4f9c-9183-da9958c38df9"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708") },
                    { new Guid("9e791723-1f8e-480d-844f-0e0fe4aae005"), new Guid("9e791723-1f8e-480d-844f-0e0fe4aae005"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("13d2e35c-3829-4bab-85c1-de00ff96248a") },
                    { new Guid("add7f52e-652d-4950-83bf-fc78dcec4a4b"), new Guid("add7f52e-652d-4950-83bf-fc78dcec4a4b"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("3707c645-9e77-4eb7-bf63-f4d65f471f25") },
                    { new Guid("eefa8738-3515-4eec-af4f-8ad520eff4a0"), new Guid("eefa8738-3515-4eec-af4f-8ad520eff4a0"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("feb60159-48a5-4164-b2e2-54b1f0a52a26") },
                    { new Guid("83a915d1-a69b-4a0e-b48f-ce0167b389f9"), new Guid("83a915d1-a69b-4a0e-b48f-ce0167b389f9"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b64e4795-0efe-4cf5-82e3-f4219c041137") },
                    { new Guid("d1f28e19-88e4-4a8e-969a-581b93527bc7"), new Guid("d1f28e19-88e4-4a8e-969a-581b93527bc7"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("a14f7dbb-8a76-4b6e-8e67-6adb4f1b39b2") },
                    { new Guid("076dadf7-1f3a-450a-9a4b-360c571f6070"), new Guid("076dadf7-1f3a-450a-9a4b-360c571f6070"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("ab6c56d1-8f95-45db-b4a1-6bae20e30c47") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RecallKnowledgePrerequisite_RequiredProficiencyId", "RequiresAssurance" },
                values: new object[] { new Guid("67a960ad-7744-4ad9-a3b2-1f9445e52e69"), new Guid("67a960ad-7744-4ad9-a3b2-1f9445e52e69"), "RecallKnowledgePrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), true });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("79c0f62e-189b-4c8f-b18c-349f2f4237eb"), new Guid("79c0f62e-189b-4c8f-b18c-349f2f4237eb"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), null },
                    { new Guid("d117552a-f149-48fd-8ff1-425893fb7b00"), new Guid("d117552a-f149-48fd-8ff1-425893fb7b00"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("6f23369f-e91f-4472-a254-648ba3ed1850") },
                    { new Guid("05b93357-0b9d-4e08-9a66-a2ede8b4181c"), new Guid("05b93357-0b9d-4e08-9a66-a2ede8b4181c"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("bef3fdab-348a-4024-9095-1ab69ded3fed") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredProficiencyId" },
                values: new object[] { new Guid("abe5405c-a349-4fb2-8a49-ac761cfe23da"), new Guid("abe5405c-a349-4fb2-8a49-ac761cfe23da"), "LorePrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("d248a540-3462-4092-810f-4bec985fc25d"), new Guid("d248a540-3462-4092-810f-4bec985fc25d"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("2f33e759-98f4-4a19-a955-e2133197de04") },
                    { new Guid("a9682158-d756-4503-a952-454d8396b2a2"), new Guid("a9682158-d756-4503-a952-454d8396b2a2"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b41f214e-5d45-46fe-8495-263c3d117a86") },
                    { new Guid("fc764cdf-3471-461a-b528-1fdacfc69ddd"), new Guid("fc764cdf-3471-461a-b528-1fdacfc69ddd"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("d8fd543c-7284-451d-8882-583970e9d917") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredStatId", "RequiredStatValue" },
                values: new object[] { new Guid("276c32c0-d4b4-468b-bd7d-3faa635a76b6"), new Guid("276c32c0-d4b4-468b-bd7d-3faa635a76b6"), "StatPrerequisite", null, new Guid("21b2cca1-66cd-48d1-a91b-085521659548"), 14 });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredFeatId" },
                values: new object[] { new Guid("ccfe054b-4194-4ba2-8bba-4f98b1ed0e4f"), new Guid("ccfe054b-4194-4ba2-8bba-4f98b1ed0e4f"), "FeatPrerequisite", null, new Guid("8ee11526-08b4-451e-8424-83704f0d1a70") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("4e7be145-127f-4a7c-a9a2-d178e1465cec"), new Guid("4e7be145-127f-4a7c-a9a2-d178e1465cec"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("b41f214e-5d45-46fe-8495-263c3d117a86") },
                    { new Guid("b2b79e69-4c97-4b1d-a48d-6fde4da02465"), new Guid("b2b79e69-4c97-4b1d-a48d-6fde4da02465"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("ab6c56d1-8f95-45db-b4a1-6bae20e30c47") },
                    { new Guid("bd212e0a-63fd-42fc-a012-3d56ceb4d822"), new Guid("bd212e0a-63fd-42fc-a012-3d56ceb4d822"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("b64e4795-0efe-4cf5-82e3-f4219c041137") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredFeatId" },
                values: new object[] { new Guid("1abf8f92-6500-471f-8a76-0890564bd71b"), new Guid("1abf8f92-6500-471f-8a76-0890564bd71b"), "FeatPrerequisite", null, new Guid("8dc95af1-d049-457f-91f8-311ead81336d") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("b7c2609b-e269-4df4-8aeb-2abf5fe06560"), new Guid("b7c2609b-e269-4df4-8aeb-2abf5fe06560"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("641be10d-b069-45e9-b890-7f1254cd042c") },
                    { new Guid("ad836b29-2ab7-4e76-8979-65e3f895a534"), new Guid("ad836b29-2ab7-4e76-8979-65e3f895a534"), "SkillPrerequisite", null, new Guid("5184371d-aad0-4d76-b43c-b03d5e930ddb"), new Guid("641be10d-b069-45e9-b890-7f1254cd042c") },
                    { new Guid("4e970e30-b49a-4f75-922f-fc222288a0e6"), new Guid("4e970e30-b49a-4f75-922f-fc222288a0e6"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("a14f7dbb-8a76-4b6e-8e67-6adb4f1b39b2") },
                    { new Guid("76fe7bde-7fb7-4ddf-86c5-02e226fe18fa"), new Guid("76fe7bde-7fb7-4ddf-86c5-02e226fe18fa"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("13d2e35c-3829-4bab-85c1-de00ff96248a") },
                    { new Guid("6c7f9f03-7c92-4501-8328-dd54627898f6"), new Guid("6c7f9f03-7c92-4501-8328-dd54627898f6"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("bef3fdab-348a-4024-9095-1ab69ded3fed") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredStatId", "RequiredStatValue" },
                values: new object[,]
                {
                    { new Guid("acd168ad-b9c9-406e-963d-ae3a449af924"), new Guid("acd168ad-b9c9-406e-963d-ae3a449af924"), "StatPrerequisite", null, new Guid("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137"), 16 },
                    { new Guid("09e0806b-4107-46a1-a5db-8a7afa301f4d"), new Guid("09e0806b-4107-46a1-a5db-8a7afa301f4d"), "StatPrerequisite", null, new Guid("10e9f065-a160-47e5-97df-72df4ec5ea15"), 14 }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("a4c66b29-0433-4ac7-901a-0eca0b5e793c"), new Guid("a4c66b29-0433-4ac7-901a-0eca0b5e793c"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("a14f7dbb-8a76-4b6e-8e67-6adb4f1b39b2") },
                    { new Guid("99aa8f00-de7a-4968-9d1b-702c30912758"), new Guid("99aa8f00-de7a-4968-9d1b-702c30912758"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("a14f7dbb-8a76-4b6e-8e67-6adb4f1b39b2") },
                    { new Guid("ca730a60-9507-4f6a-8279-33e15fe8d7eb"), new Guid("ca730a60-9507-4f6a-8279-33e15fe8d7eb"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b41f214e-5d45-46fe-8495-263c3d117a86") },
                    { new Guid("52cc51ea-a378-4653-90bd-6fde5569ae0b"), new Guid("52cc51ea-a378-4653-90bd-6fde5569ae0b"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("b41f214e-5d45-46fe-8495-263c3d117a86") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredFeatId" },
                values: new object[] { new Guid("60c37f30-39dd-4fb1-9ecc-3ad80b2ab3ef"), new Guid("60c37f30-39dd-4fb1-9ecc-3ad80b2ab3ef"), "FeatPrerequisite", null, new Guid("b1c71e21-bea7-453b-b23a-13ecc1b3675b") });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("04f0104f-5c14-447e-95b4-cfaaba3f4cbc"), new Guid("04f0104f-5c14-447e-95b4-cfaaba3f4cbc"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("bef3fdab-348a-4024-9095-1ab69ded3fed") },
                    { new Guid("af734054-75d9-4248-a87d-0b5952f90107"), new Guid("af734054-75d9-4248-a87d-0b5952f90107"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("ab6c56d1-8f95-45db-b4a1-6bae20e30c47") },
                    { new Guid("eae50f6e-3de5-4ff9-94e9-f0d0dfe8df88"), new Guid("eae50f6e-3de5-4ff9-94e9-f0d0dfe8df88"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("8b35c13a-46fd-4018-bb18-11c0f156f708") },
                    { new Guid("c591078d-1a92-40eb-a7b9-611748799608"), new Guid("c591078d-1a92-40eb-a7b9-611748799608"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("ab6c56d1-8f95-45db-b4a1-6bae20e30c47") },
                    { new Guid("1ebd72e0-3e61-42ad-b3b7-8f68c2094de2"), new Guid("1ebd72e0-3e61-42ad-b3b7-8f68c2094de2"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("a14f7dbb-8a76-4b6e-8e67-6adb4f1b39b2") },
                    { new Guid("0a89ce88-3517-439b-8149-414aa59fbd80"), new Guid("0a89ce88-3517-439b-8149-414aa59fbd80"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("ab6c56d1-8f95-45db-b4a1-6bae20e30c47") },
                    { new Guid("93adf76b-93db-4a21-96dd-18344ed3f4e6"), new Guid("93adf76b-93db-4a21-96dd-18344ed3f4e6"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("d8fd543c-7284-451d-8882-583970e9d917") },
                    { new Guid("c8867d56-91ed-416e-9bc3-d2ef213bb3aa"), new Guid("c8867d56-91ed-416e-9bc3-d2ef213bb3aa"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("252ee579-951c-414e-bb69-7d2dfc324280") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "RequiredStatId", "RequiredStatValue" },
                values: new object[] { new Guid("11098127-44c6-4d82-9977-981fc20e637b"), new Guid("11098127-44c6-4d82-9977-981fc20e637b"), "StatPrerequisite", null, new Guid("f4206177-80d3-4c9c-8f79-357a608897fa"), 16 });

            migrationBuilder.InsertData(
                table: "SpellHeighteningDetailBlock",
                columns: new[] { "Id", "SpellHeighteningId", "Text" },
                values: new object[,]
                {
                    { new Guid("720a973c-28a7-44c6-b327-7c6e165b306c"), new Guid("070c4a22-2028-4361-89b5-ef690dd3fa6b"), "- Violet: The wall prevents spells from targeting the other side (area effects still cross as normal). Creatures passing through must succeed at a Will save or they are slowed 1 for 1 minute; on a critical failure, the creature is instead sent to another plane, with the effect of plane shift. Dispel magic can counteract a violet chromatic wall." },
                    { new Guid("15cbcb57-8a87-4384-83cc-d6fd57200b69"), new Guid("070c4a22-2028-4361-89b5-ef690dd3fa6b"), "- Blue: The wall stops auditory, petrification, and visual effects from passing through, and creatures passing through are subject to the effects of flesh to stone. Magic missile can counteract a blue chromatic wall." },
                    { new Guid("64b88f10-e799-4c14-891c-22084ad8ac1c"), new Guid("070c4a22-2028-4361-89b5-ef690dd3fa6b"), "- Indigo: The wall stops divination and mental effects from passing through, and those passing through are subject to the effects of warp mind. Searing light can counteract an indigo chromatic wall." },
                    { new Guid("12927068-2bf4-49b8-bd09-b92c6a3f8169"), new Guid("070c4a22-2028-4361-89b5-ef690dd3fa6b"), "- Reroll, and creatures that pass through the wall take a –2 circumstance penalty to their saves." }
                });

            migrationBuilder.InsertData(
                table: "BasePrerequisiteBinding",
                columns: new[] { "Id", "Discriminator", "PrerequisiteId" },
                values: new object[,]
                {
                    { new Guid("cc86f706-7eea-4352-9723-9b001c44eecd"), "OrBinding", new Guid("7478eed3-36c1-4a1d-a247-21badb079eec") },
                    { new Guid("984e1632-60e9-4775-a654-b0f11d2657ab"), "OrBinding", new Guid("8cbd0753-5757-4b8b-b134-4a9aa2196e79") },
                    { new Guid("10ad44f9-e953-4e72-b4e0-72b6befed8d9"), "OrBinding", new Guid("8cbd0753-5757-4b8b-b134-4a9aa2196e79") },
                    { new Guid("525699e1-c5e4-4677-8c3a-24d6be5f880e"), "OrBinding", new Guid("60e48bf0-f1a9-4020-be4d-3bff9e62499b") },
                    { new Guid("534558b4-37f0-4b30-bf0e-525eb52ee973"), "OrBinding", new Guid("60e48bf0-f1a9-4020-be4d-3bff9e62499b") },
                    { new Guid("745a3458-4af6-40fd-8473-85b931080f08"), "OrBinding", new Guid("60e48bf0-f1a9-4020-be4d-3bff9e62499b") },
                    { new Guid("0d21ea88-7d57-4b4a-ae2f-137fc9a3cdb9"), "OrBinding", new Guid("60e48bf0-f1a9-4020-be4d-3bff9e62499b") },
                    { new Guid("e520e7b4-b817-4ad3-a3d5-d07b579688bc"), "OrBinding", new Guid("769a8ff4-92c8-4d6c-952c-1ec417c687a0") },
                    { new Guid("dfd40c16-203f-4f82-9c7c-f340ace54516"), "OrBinding", new Guid("769a8ff4-92c8-4d6c-952c-1ec417c687a0") },
                    { new Guid("519af840-b52b-41a8-927a-502d358e41ab"), "OrBinding", new Guid("769a8ff4-92c8-4d6c-952c-1ec417c687a0") },
                    { new Guid("a58174cf-b9e6-4bad-afcf-4aa4efe0530c"), "OrBinding", new Guid("769a8ff4-92c8-4d6c-952c-1ec417c687a0") },
                    { new Guid("365f1d1b-d230-4213-b25c-e38ef86fad04"), "OrBinding", new Guid("e8a334d7-c372-4879-a05b-bb51803deb56") },
                    { new Guid("8dc0e271-020f-410a-ad89-e21ede41afe5"), "OrBinding", new Guid("e8a334d7-c372-4879-a05b-bb51803deb56") },
                    { new Guid("6c8b2f5c-7fd9-4509-aa68-29f1afd16a21"), "OrBinding", new Guid("e8a334d7-c372-4879-a05b-bb51803deb56") },
                    { new Guid("95cb060c-298c-4ccb-976b-24235639f07d"), "OrBinding", new Guid("e8a334d7-c372-4879-a05b-bb51803deb56") },
                    { new Guid("d8f78cae-3e75-4217-a860-6ba2a3560403"), "OrBinding", new Guid("7478eed3-36c1-4a1d-a247-21badb079eec") },
                    { new Guid("623b68a6-9405-4fc1-90ed-12f9ece5c28a"), "OrBinding", new Guid("7478eed3-36c1-4a1d-a247-21badb079eec") },
                    { new Guid("06f72855-bcf2-4a8d-914b-19e9c62594b0"), "OrBinding", new Guid("7478eed3-36c1-4a1d-a247-21badb079eec") },
                    { new Guid("f818bf77-4277-406b-8dd7-175d11adbb58"), "OrBinding", new Guid("8cbd0753-5757-4b8b-b134-4a9aa2196e79") },
                    { new Guid("3f40cd84-3265-437e-98a8-7b55c6583f0e"), "OrBinding", new Guid("8cbd0753-5757-4b8b-b134-4a9aa2196e79") }
                });

            migrationBuilder.InsertData(
                table: "Prerequisites",
                columns: new[] { "Id", "BindingId", "Discriminator", "OrPrerequisiteId", "SkillPrerequisite_RequiredProficiencyId", "RequiredSkillId" },
                values: new object[,]
                {
                    { new Guid("cc86f706-7eea-4352-9723-9b001c44eecd"), new Guid("cc86f706-7eea-4352-9723-9b001c44eecd"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("6f23369f-e91f-4472-a254-648ba3ed1850") },
                    { new Guid("984e1632-60e9-4775-a654-b0f11d2657ab"), new Guid("984e1632-60e9-4775-a654-b0f11d2657ab"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("3707c645-9e77-4eb7-bf63-f4d65f471f25") },
                    { new Guid("10ad44f9-e953-4e72-b4e0-72b6befed8d9"), new Guid("10ad44f9-e953-4e72-b4e0-72b6befed8d9"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("6f23369f-e91f-4472-a254-648ba3ed1850") },
                    { new Guid("525699e1-c5e4-4677-8c3a-24d6be5f880e"), new Guid("525699e1-c5e4-4677-8c3a-24d6be5f880e"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("6a672190-7918-4fbd-a2d7-2d69f9d2a794") },
                    { new Guid("534558b4-37f0-4b30-bf0e-525eb52ee973"), new Guid("534558b4-37f0-4b30-bf0e-525eb52ee973"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("feb60159-48a5-4164-b2e2-54b1f0a52a26") },
                    { new Guid("745a3458-4af6-40fd-8473-85b931080f08"), new Guid("745a3458-4af6-40fd-8473-85b931080f08"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("3707c645-9e77-4eb7-bf63-f4d65f471f25") },
                    { new Guid("0d21ea88-7d57-4b4a-ae2f-137fc9a3cdb9"), new Guid("0d21ea88-7d57-4b4a-ae2f-137fc9a3cdb9"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("6f23369f-e91f-4472-a254-648ba3ed1850") },
                    { new Guid("e520e7b4-b817-4ad3-a3d5-d07b579688bc"), new Guid("e520e7b4-b817-4ad3-a3d5-d07b579688bc"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("6a672190-7918-4fbd-a2d7-2d69f9d2a794") },
                    { new Guid("dfd40c16-203f-4f82-9c7c-f340ace54516"), new Guid("dfd40c16-203f-4f82-9c7c-f340ace54516"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("feb60159-48a5-4164-b2e2-54b1f0a52a26") },
                    { new Guid("519af840-b52b-41a8-927a-502d358e41ab"), new Guid("519af840-b52b-41a8-927a-502d358e41ab"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("3707c645-9e77-4eb7-bf63-f4d65f471f25") },
                    { new Guid("a58174cf-b9e6-4bad-afcf-4aa4efe0530c"), new Guid("a58174cf-b9e6-4bad-afcf-4aa4efe0530c"), "SkillPrerequisite", null, new Guid("3c0b8610-4da2-4bb2-b7c9-1bd130ae8a56"), new Guid("6f23369f-e91f-4472-a254-648ba3ed1850") },
                    { new Guid("365f1d1b-d230-4213-b25c-e38ef86fad04"), new Guid("365f1d1b-d230-4213-b25c-e38ef86fad04"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("6a672190-7918-4fbd-a2d7-2d69f9d2a794") },
                    { new Guid("8dc0e271-020f-410a-ad89-e21ede41afe5"), new Guid("8dc0e271-020f-410a-ad89-e21ede41afe5"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("feb60159-48a5-4164-b2e2-54b1f0a52a26") },
                    { new Guid("6c8b2f5c-7fd9-4509-aa68-29f1afd16a21"), new Guid("6c8b2f5c-7fd9-4509-aa68-29f1afd16a21"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("3707c645-9e77-4eb7-bf63-f4d65f471f25") },
                    { new Guid("95cb060c-298c-4ccb-976b-24235639f07d"), new Guid("95cb060c-298c-4ccb-976b-24235639f07d"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("6f23369f-e91f-4472-a254-648ba3ed1850") },
                    { new Guid("d8f78cae-3e75-4217-a860-6ba2a3560403"), new Guid("d8f78cae-3e75-4217-a860-6ba2a3560403"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("6a672190-7918-4fbd-a2d7-2d69f9d2a794") },
                    { new Guid("623b68a6-9405-4fc1-90ed-12f9ece5c28a"), new Guid("623b68a6-9405-4fc1-90ed-12f9ece5c28a"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("feb60159-48a5-4164-b2e2-54b1f0a52a26") },
                    { new Guid("06f72855-bcf2-4a8d-914b-19e9c62594b0"), new Guid("06f72855-bcf2-4a8d-914b-19e9c62594b0"), "SkillPrerequisite", null, new Guid("e75eb2e8-f901-4d74-8497-05b7f2e689a9"), new Guid("3707c645-9e77-4eb7-bf63-f4d65f471f25") },
                    { new Guid("f818bf77-4277-406b-8dd7-175d11adbb58"), new Guid("f818bf77-4277-406b-8dd7-175d11adbb58"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("feb60159-48a5-4164-b2e2-54b1f0a52a26") },
                    { new Guid("3f40cd84-3265-437e-98a8-7b55c6583f0e"), new Guid("3f40cd84-3265-437e-98a8-7b55c6583f0e"), "SkillPrerequisite", null, new Guid("130841fd-de3b-45e7-bb97-c4ded6ec71e8"), new Guid("6a672190-7918-4fbd-a2d7-2d69f9d2a794") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionDetailsBlock_ActionId",
                table: "ActionDetailsBlock",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_ActionTypeId",
                table: "Actions",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_RollableEffectId",
                table: "Actions",
                column: "RollableEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_TraitsId",
                table: "Actions",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionTrait_TraitsId",
                table: "ActionTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseFeatEffectBinding_FeatId",
                table: "BaseFeatEffectBinding",
                column: "FeatId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisiteBinding_FeatId",
                table: "BasePrerequisiteBinding",
                column: "FeatId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePrerequisiteBinding_PrerequisiteId",
                table: "BasePrerequisiteBinding",
                column: "PrerequisiteId");

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
                name: "IX_Classes_KeyAbilitiesId",
                table: "Classes",
                column: "KeyAbilitiesId");

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
                name: "IX_ClassFeature_ClassId",
                table: "ClassFeature",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassMannerism_ClassId",
                table: "ClassMannerism",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStat_KeyAbilitiesId",
                table: "ClassStat",
                column: "KeyAbilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_AlignmentId",
                table: "Deities",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_CategoryId",
                table: "Deities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_DivineFontsId",
                table: "Deities",
                column: "DivineFontsId");

            migrationBuilder.CreateIndex(
                name: "IX_Deities_DomainsId",
                table: "Deities",
                column: "DomainsId");

            migrationBuilder.CreateIndex(
                name: "IX_DeityDivineFont_DivineFontsId",
                table: "DeityDivineFont",
                column: "DivineFontsId");

            migrationBuilder.CreateIndex(
                name: "IX_DeityDomain_DomainsId",
                table: "DeityDomain",
                column: "DomainsId");

            migrationBuilder.CreateIndex(
                name: "IX_DeityFollowerAlignments_AlignmentId",
                table: "DeityFollowerAlignments",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DeityFollowerAlignments_DeityId",
                table: "DeityFollowerAlignments",
                column: "DeityId");

            migrationBuilder.CreateIndex(
                name: "IX_DivineFonts_DeitiesId",
                table: "DivineFonts",
                column: "DeitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_DeitiesId",
                table: "Domains",
                column: "DeitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatDetailsBlock_FeatId",
                table: "FeatDetailsBlock",
                column: "FeatId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatEffect_BindingId",
                table: "FeatEffect",
                column: "BindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatEffect_HeritageRarityId",
                table: "FeatEffect",
                column: "HeritageRarityId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatEffect_OrFeatEffectId",
                table: "FeatEffect",
                column: "OrFeatEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatEffect_ProficiencyId",
                table: "FeatEffect",
                column: "ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatRequirement_FeatId",
                table: "FeatRequirement",
                column: "FeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_ActionTypeId",
                table: "Feats",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_FeatTypeId",
                table: "Feats",
                column: "FeatTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_FrequencyId",
                table: "Feats",
                column: "FrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_RollableEffectId",
                table: "Feats",
                column: "RollableEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_TraitsId",
                table: "Feats",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatTrait_TraitsId",
                table: "FeatTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_HeritageRace_RacesId",
                table: "HeritageRace",
                column: "RacesId");

            migrationBuilder.CreateIndex(
                name: "IX_Heritages_RacesId",
                table: "Heritages",
                column: "RacesId");

            migrationBuilder.CreateIndex(
                name: "IX_Heritages_RarityId",
                table: "Heritages",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageRace_LanguagesId",
                table: "LanguageRace",
                column: "LanguagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_RacesId",
                table: "Languages",
                column: "RacesId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_TypeId",
                table: "Languages",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lores_DeityId",
                table: "Lores",
                column: "DeityId");

            migrationBuilder.CreateIndex(
                name: "IX_Lores_PlaneId",
                table: "Lores",
                column: "PlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Lores_StatModifierId",
                table: "Lores",
                column: "StatModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicTraditions_SpellsId",
                table: "MagicTraditions",
                column: "SpellsId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicTraditionSpell_TraditionsId",
                table: "MagicTraditionSpell",
                column: "TraditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanePlaneTrait_TraitsId",
                table: "PlanePlaneTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_AlignmentId",
                table: "Planes",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_CategoryId",
                table: "Planes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_TraitsId",
                table: "Planes",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaneTraits_PlanesId",
                table: "PlaneTraits",
                column: "PlanesId");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisites_BindingId",
                table: "Prerequisites",
                column: "BindingId");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisites_OrPrerequisiteId",
                table: "Prerequisites",
                column: "OrPrerequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisites_RecallKnowledgePrerequisite_RequiredProficien~",
                table: "Prerequisites",
                column: "RecallKnowledgePrerequisite_RequiredProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisites_RequiredDeityId",
                table: "Prerequisites",
                column: "RequiredDeityId");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisites_RequiredFeatId",
                table: "Prerequisites",
                column: "RequiredFeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisites_RequiredProficiencyId",
                table: "Prerequisites",
                column: "RequiredProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisites_RequiredSkillId",
                table: "Prerequisites",
                column: "RequiredSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisites_RequiredStatId",
                table: "Prerequisites",
                column: "RequiredStatId");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisites_SkillPrerequisite_RequiredProficiencyId",
                table: "Prerequisites",
                column: "SkillPrerequisite_RequiredProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceRaceTrait_RaceTraitsId",
                table: "RaceRaceTrait",
                column: "RaceTraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_HeritagesId",
                table: "Races",
                column: "HeritagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_LanguagesId",
                table: "Races",
                column: "LanguagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_RaceTraitsId",
                table: "Races",
                column: "RaceTraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_RarityId",
                table: "Races",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SizeId",
                table: "Races",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceTraits_RacesId",
                table: "RaceTraits",
                column: "RacesId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_StatModifierId",
                table: "Skills",
                column: "StatModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellComponents_SpellsId",
                table: "SpellComponents",
                column: "SpellsId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellDetailBlock_SpellId",
                table: "SpellDetailBlock",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellHeightening_SpellId",
                table: "SpellHeightening",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellHeighteningDetailBlock_SpellHeighteningId",
                table: "SpellHeighteningDetailBlock",
                column: "SpellHeighteningId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellRequirement_SpellId",
                table: "SpellRequirement",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_ActionTypeId",
                table: "Spells",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_ComponentsId",
                table: "Spells",
                column: "ComponentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_MagicSchoolId",
                table: "Spells",
                column: "MagicSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_RollableEffectId",
                table: "Spells",
                column: "RollableEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SavingThrowStatId",
                table: "Spells",
                column: "SavingThrowStatId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SpellTypeId",
                table: "Spells",
                column: "SpellTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_TraditionsId",
                table: "Spells",
                column: "TraditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_TraitsId",
                table: "Spells",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellSpellComponent_ComponentsId",
                table: "SpellSpellComponent",
                column: "ComponentsId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellTrait_TraitsId",
                table: "SpellTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellTrigger_SpellId",
                table: "SpellTrigger",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_KeyAbilityClassesId",
                table: "Stats",
                column: "KeyAbilityClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_ActionsId",
                table: "Traits",
                column: "ActionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_FeatsId",
                table: "Traits",
                column: "FeatsId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_SpellsId",
                table: "Traits",
                column: "SpellsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActionDetailsBlock_Actions_ActionId",
                table: "ActionDetailsBlock",
                column: "ActionId",
                principalTable: "Actions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActionTrait_Actions_ActionsId",
                table: "ActionTrait",
                column: "ActionsId",
                principalTable: "Actions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActionTrait_Traits_TraitsId",
                table: "ActionTrait",
                column: "TraitsId",
                principalTable: "Traits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Traits_Actions_ActionsId",
                table: "Traits",
                column: "ActionsId",
                principalTable: "Actions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Traits_Feats_FeatsId",
                table: "Traits",
                column: "FeatsId",
                principalTable: "Feats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Traits_Spells_SpellsId",
                table: "Traits",
                column: "SpellsId",
                principalTable: "Spells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_MagicTraditions_TraditionsId",
                table: "Spells",
                column: "TraditionsId",
                principalTable: "MagicTraditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_SpellComponents_ComponentsId",
                table: "Spells",
                column: "ComponentsId",
                principalTable: "SpellComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deities_DivineFonts_DivineFontsId",
                table: "Deities",
                column: "DivineFontsId",
                principalTable: "DivineFonts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deities_Domains_DomainsId",
                table: "Deities",
                column: "DomainsId",
                principalTable: "Domains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_PlaneTraits_TraitsId",
                table: "Planes",
                column: "TraitsId",
                principalTable: "PlaneTraits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prerequisites_BasePrerequisiteBinding_BindingId",
                table: "Prerequisites",
                column: "BindingId",
                principalTable: "BasePrerequisiteBinding",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prerequisites_Skills_RequiredSkillId",
                table: "Prerequisites",
                column: "RequiredSkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prerequisites_Stats_RequiredStatId",
                table: "Prerequisites",
                column: "RequiredStatId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCharacteristic_Classes_ClassId",
                table: "ClassCharacteristic",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassFeature_Classes_ClassId",
                table: "ClassFeature",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassMannerism_Classes_ClassId",
                table: "ClassMannerism",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStat_Classes_KeyAbilityClassesId",
                table: "ClassStat",
                column: "KeyAbilityClassesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStat_Stats_KeyAbilitiesId",
                table: "ClassStat",
                column: "KeyAbilitiesId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stats_Classes_KeyAbilityClassesId",
                table: "Stats",
                column: "KeyAbilityClassesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Heritages_Races_RacesId",
                table: "Heritages",
                column: "RacesId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HeritageRace_Races_RacesId",
                table: "HeritageRace",
                column: "RacesId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Languages_LanguagesId",
                table: "Races",
                column: "LanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_RaceTraits_RaceTraitsId",
                table: "Races",
                column: "RaceTraitsId",
                principalTable: "RaceTraits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Traits_Actions_ActionsId",
                table: "Traits");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_ActionTypes_ActionTypeId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_ActionTypes_ActionTypeId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_RollableEffect_RollableEffectId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_RollableEffect_RollableEffectId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_Traits_TraitsId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Traits_TraitsId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisiteBinding_Feats_FeatId",
                table: "BasePrerequisiteBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_Prerequisites_Feats_RequiredFeatId",
                table: "Prerequisites");

            migrationBuilder.DropForeignKey(
                name: "FK_BasePrerequisiteBinding_Prerequisites_PrerequisiteId",
                table: "BasePrerequisiteBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_Stats_Classes_KeyAbilityClassesId",
                table: "Stats");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_MagicTraditions_TraditionsId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Deities_Alignments_AlignmentId",
                table: "Deities");

            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Alignments_AlignmentId",
                table: "Planes");

            migrationBuilder.DropForeignKey(
                name: "FK_Deities_DeityCategories_CategoryId",
                table: "Deities");

            migrationBuilder.DropForeignKey(
                name: "FK_Deities_DivineFonts_DivineFontsId",
                table: "Deities");

            migrationBuilder.DropForeignKey(
                name: "FK_Deities_Domains_DomainsId",
                table: "Deities");

            migrationBuilder.DropForeignKey(
                name: "FK_Heritages_HeritageRarities_RarityId",
                table: "Heritages");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Heritages_HeritagesId",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Races_RacesId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceTraits_Races_RacesId",
                table: "RaceTraits");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaneTraits_Planes_PlanesId",
                table: "PlaneTraits");

            migrationBuilder.DropForeignKey(
                name: "FK_SpellComponents_Spells_SpellsId",
                table: "SpellComponents");

            migrationBuilder.DropTable(
                name: "ActionDetailsBlock");

            migrationBuilder.DropTable(
                name: "ActionTrait");

            migrationBuilder.DropTable(
                name: "ArmorGroups");

            migrationBuilder.DropTable(
                name: "BenefitTypes");

            migrationBuilder.DropTable(
                name: "Bulks");

            migrationBuilder.DropTable(
                name: "ClassCharacteristic");

            migrationBuilder.DropTable(
                name: "ClassFeature");

            migrationBuilder.DropTable(
                name: "ClassMannerism");

            migrationBuilder.DropTable(
                name: "ClassStat");

            migrationBuilder.DropTable(
                name: "DeityDivineFont");

            migrationBuilder.DropTable(
                name: "DeityDomain");

            migrationBuilder.DropTable(
                name: "DeityFollowerAlignments");

            migrationBuilder.DropTable(
                name: "FeatDetailsBlock");

            migrationBuilder.DropTable(
                name: "FeatEffect");

            migrationBuilder.DropTable(
                name: "FeatRequirement");

            migrationBuilder.DropTable(
                name: "FeatTrait");

            migrationBuilder.DropTable(
                name: "HeritageRace");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "LanguageRace");

            migrationBuilder.DropTable(
                name: "Lores");

            migrationBuilder.DropTable(
                name: "MagicEssences");

            migrationBuilder.DropTable(
                name: "MagicTraditionSpell");

            migrationBuilder.DropTable(
                name: "PlanePlaneTrait");

            migrationBuilder.DropTable(
                name: "RaceRaceTrait");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "SpellDetailBlock");

            migrationBuilder.DropTable(
                name: "SpellHeighteningDetailBlock");

            migrationBuilder.DropTable(
                name: "SpellRequirement");

            migrationBuilder.DropTable(
                name: "SpellSpellComponent");

            migrationBuilder.DropTable(
                name: "SpellTrait");

            migrationBuilder.DropTable(
                name: "SpellTrigger");

            migrationBuilder.DropTable(
                name: "BaseFeatEffectBinding");

            migrationBuilder.DropTable(
                name: "SpellHeightening");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "ActionTypes");

            migrationBuilder.DropTable(
                name: "RollableEffect");

            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "Feats");

            migrationBuilder.DropTable(
                name: "FeatTypes");

            migrationBuilder.DropTable(
                name: "Frequencies");

            migrationBuilder.DropTable(
                name: "Prerequisites");

            migrationBuilder.DropTable(
                name: "BasePrerequisiteBinding");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Proficiencies");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "MagicTraditions");

            migrationBuilder.DropTable(
                name: "Alignments");

            migrationBuilder.DropTable(
                name: "DeityCategories");

            migrationBuilder.DropTable(
                name: "DivineFonts");

            migrationBuilder.DropTable(
                name: "Domains");

            migrationBuilder.DropTable(
                name: "Deities");

            migrationBuilder.DropTable(
                name: "HeritageRarities");

            migrationBuilder.DropTable(
                name: "Heritages");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "RaceRarities");

            migrationBuilder.DropTable(
                name: "RaceSizes");

            migrationBuilder.DropTable(
                name: "RaceTraits");

            migrationBuilder.DropTable(
                name: "LanguageTypes");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "PlaneCategories");

            migrationBuilder.DropTable(
                name: "PlaneTraits");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "MagicSchools");

            migrationBuilder.DropTable(
                name: "SavingThrowStats");

            migrationBuilder.DropTable(
                name: "SpellComponents");

            migrationBuilder.DropTable(
                name: "SpellTypes");
        }
    }
}
