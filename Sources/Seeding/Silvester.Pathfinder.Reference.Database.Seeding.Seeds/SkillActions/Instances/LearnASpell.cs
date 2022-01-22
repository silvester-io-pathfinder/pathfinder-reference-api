using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class LearnASpell : Template
    {
        public static readonly Guid ID = Guid.Parse("e89f42cf-f8a4-4dd3-86f8-f9f95e177238");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Learn a Spell",
                Requirements = "You have a spellcasting class feature, and the spell you want to learn is on your magical tradition's spell list.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c43f75c6-3129-489e-97a8-b8706a7742f8"), Type = TextBlockType.Text, Text = "If you�re a spellcaster, you can use the skill corresponding to your magical tradition to learn a new spell of that tradition. Table 4�3: Learning a Spell lists the Price of the materials needed to Learn a Spell of each level." };
            yield return new TextBlock { Id = Guid.Parse("86a50867-6989-4383-abee-afddeb918dde"), Type = TextBlockType.Text, Text = "You can gain access to a new spell of your tradition from someone who knows that spell or from magical writing like a spellbook or scroll. If you can cast spells of multiple traditions, you can Learn a Spell of any of those traditions, but you must use the corresponding skill to do so. For example, if you were a cleric with the bard multiclass archetype, you couldn�t use Religion to add an occult spell to your bardic spell repertoire." };
            yield return new TextBlock { Id = Guid.Parse("578f6281-0b80-4d08-8b3e-1085341f049f"), Type = TextBlockType.Text, Text = "To learn the spell, you must do the following:" };
            yield return new TextBlock { Id = Guid.Parse("b9ad18da-6bfb-40a6-bb4f-46a7822325f7"), Type = TextBlockType.Enumeration, Text = "Spend 1 hour per level of the spell, during which you must remain in conversation with a person who knows the spell or have the magical writing in your possession." };
            yield return new TextBlock { Id = Guid.Parse("aeac59f5-5ea3-4cce-a645-da56de1e326b"), Type = TextBlockType.Enumeration, Text = "Have materials with the Price indicated in Table 4�3." };
            yield return new TextBlock { Id = Guid.Parse("9b104f9b-5a64-4877-b747-28d8d6f7825b"), Type = TextBlockType.Enumeration, Text = "Attempt a skill check for the skill corresponding to your tradition (DC determined by the GM, often close to the DC on Table 4�3). Uncommon or rare spells have higher DCs; full guidelines for the GM appear on page 503." };
            yield return new TextBlock { Id = Guid.Parse("5f67c793-a4e9-464c-97a9-1c38d10d6fc6"), Type = TextBlockType.Text, Text = "If you have a spellbook, Learning a Spell lets you add the spell to your spellbook; if you prepare spells from a list, it�s added to your list; if you have a spell repertoire, you can select it when you add or swap spells." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Arcana.ID;
            yield return Skills.Instances.Religion.ID;
            yield return Skills.Instances.Occultism.ID;
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("39184188-8ee1-4bc6-89ba-7ed2852c474d"),
                CriticalSuccess = "You expend half the materials and learn the spell.",
                Success = "You expend the materials and learn the spell.",
                Failure = "You fail to learn the spell but can try again after you gain a level. The materials aren�t expended.",
                CriticalFailure = "As failure, plus you expend half the materials."
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Exploration.ID;
        }

        protected override Table? GetTable()
        {
            return new TableBuilder("cc94918b-3913-48a5-8e87-228e9b3e0e62")
                .AddColumn("e2e869c6-37a5-4fe4-82c8-cc71841e86ab", "Spell Level")
                .AddColumn("d2a21d5b-3f8c-4023-90af-4ab2d833d40f", "Price")
                .AddColumn("c17a54a4-348e-4327-99c4-7af35cf5bff6", "Typical DC")
                .AddRow("561d8f21-ad7a-49bd-bbe3-94ef5ff097fe", row =>
                {
                    row
                        .AddCell("628492ab-11b4-4d90-9e52-e4ea855c112e", "1st or cantrup")
                        .AddCell("66bbde76-9362-45c5-8e2f-04306cc06324", "2 gp")
                        .AddCell("e4824785-e5db-44c2-893d-9eaefa4d25d4", "15");
                })
                .AddRow("d3a057f3-871f-447d-ae39-a52720273352", row =>
                {
                    row
                        .AddCell("fbee98db-db50-47e6-8d76-8d28aefa5c54", "2nd")
                        .AddCell("4cf820a3-73f9-4550-9c56-932732471c2e", "6 gp")
                        .AddCell("b9787ddd-c9d1-46f6-9f0f-0902f4316c8d", "18");
                })
                .AddRow("921db25e-56a9-4906-9035-1081bcce9aca", row =>
                {
                    row
                        .AddCell("23739597-d182-4669-ab00-aa0b58a2808c", "3rd")
                        .AddCell("35102700-2386-49a0-8ca4-3465600109cd", "16 gp")
                        .AddCell("2c7b5070-9081-445c-b6c6-89d83f7ceaff", "20");
                })
                .AddRow("eb3d71c7-dd9a-42f3-983d-c95dfc081d30", row =>
                {
                    row
                        .AddCell("0add17b7-5a96-4fab-8513-9c314bb9fcf6", "4th")
                        .AddCell("45b80c98-d6fa-4aa3-ac1e-97bc80e26331", "36 gp")
                        .AddCell("2bbc7dee-326a-4a83-acdd-47d9835c9a5a", "23");
                })
                .AddRow("110111a8-adab-4cdb-871a-25f9e3e184bd", row =>
                {
                    row
                        .AddCell("372ab76e-5dca-440a-a31c-a4e890eb151c", "5th")
                        .AddCell("b76720f6-7f17-4f58-a1e4-0930c09f3637", "70 gp")
                        .AddCell("ba225013-743a-448e-950f-45650f7e9ee6", "26");
                })
                .AddRow("51f2831b-2a8c-4b6b-9680-92cf1592f249", row =>
                {
                    row
                        .AddCell("9f4bb64d-c328-49bf-91d5-92f7c447d2fc", "6th")
                        .AddCell("0d320392-952a-423b-bf0f-3c11460da23d", "140 gp")
                        .AddCell("64fdfbdc-680e-4a97-aa0d-919b95b9cbfb", "28");
                })
                .AddRow("479065c9-45cb-4d80-a910-f62cde93728a", row =>
                {
                    row
                        .AddCell("66ee2c02-1eb8-42e0-a44b-d1e0dc561112", "7th")
                        .AddCell("baca2da9-528c-4342-9e1e-23fa32d47272", "300 gp")
                        .AddCell("967a5f91-a10d-425d-972c-bcdb20c5f367", "31");
                })
                .AddRow("948cf4f1-b984-4ffa-bb93-eb86b70981bc", row =>
                {
                    row
                        .AddCell("e554a5a4-79d8-4440-8c05-ffe80dd9f221", "8th")
                        .AddCell("c086050b-9b8b-4bc5-9faa-ac94d35e20eb", "650 gp")
                        .AddCell("63577b32-393e-4e27-b713-367c23cd3ba8", "34");
                })
                .AddRow("c29d6cf2-aa45-4b88-9e72-b319b12e906e", row =>
                {
                    row
                        .AddCell("52e44af3-1106-40a4-8e08-8ecf79f8f849", "9th")
                        .AddCell("88a08e5a-8009-48da-a098-de06a3fc2a6e", "1500 gp")
                        .AddCell("08c1ddaa-c8a5-4714-b1fb-ca588cfb7f0d", "36");
                })
                .AddRow("f58daa20-9604-42ee-bcd4-fc95b6209ccb", row =>
                {
                    row
                        .AddCell("af86dac3-9dd7-477f-a916-d397e346232e", "10th")
                        .AddCell("89f1cb6c-a589-485a-aa8e-f81f9b4d0b6e", "7000 gp")
                        .AddCell("bbf21378-6f82-4b87-880d-cbccb781eaa9", "41");
                })
                .Build();
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8746d6b8-a076-4b2d-ae87-dd6f4a3ee7cb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 238
            };
        }
    }
}
