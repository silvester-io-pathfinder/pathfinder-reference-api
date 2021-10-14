using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Climb : Template
    {
        public static readonly Guid ID = Guid.Parse("12e065d9-8840-41e0-8c90-4072e2e48896");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Climb",
                Requirements = "You have both hands free.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("22779bea-db4e-4e6e-b7d4-c82b449783f1"), Type = TextBlockType.Text, Text = "You move up, down, or across an incline. Unless it�s particularly easy, you must attempt an Athletics check. The GM determines the DC based on the nature of the incline and environmental circumstances. You�re flat-footed unless you have a climb Speed." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Move.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Encounter.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("99af0318-c0db-4181-99f8-bca24b6ab82b"),
                CriticalSuccess = "You move up, across, or safely down the incline for 5 feet plus 5 feet per 20 feet of your land Speed (a total of 10 feet for most PCs).",
                Success = "You move up, across, or safely down the incline for 5 feet per 20 feet of your land Speed (a total of 5 feet for most PCs, minimum 5 feet if your Speed is below 20 feet).",
                CriticalFailure = "You fall. If you began the climb on stable ground, you fall and land prone."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("7eba1e72-38ab-4ed8-bf7f-af5f5cd457a7"), ProficiencyId = Proficiencies.Instances.Untrained.ID, Description = "Ladder, steep slope, low-branched tree." };
            yield return new SkillActionExample { Id = Guid.Parse("91f0e9cc-773d-405d-b2a4-b94599854521"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Rope, typical tree." };
            yield return new SkillActionExample { Id = Guid.Parse("b10df9c4-4fb6-4309-8d9c-e8e2ab26df8d"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Wall with small handholds and footholds." };
            yield return new SkillActionExample { Id = Guid.Parse("2cb47b20-0e99-47a1-bd69-b9ae8fd2211b"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Ceiling with handholds and footholds, rock wall." };
            yield return new SkillActionExample { Id = Guid.Parse("7fe53b08-c7f4-47a8-abc1-349dfef9805e"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Smooth surface." };
        }

        protected override Table? GetTable()
        {
            return new TableBuilder()
                .AddColumn("69de3128-524b-4001-a17d-5839762bc1f3", "Speed")
                .AddColumn("007a0ca9-75f8-44b9-a58d-7b1d91388085", "Climb Distance Success")
                .AddColumn("773787d4-0106-4d3f-8f46-1c8b3b5c5b7e", "Climb Distance Critical")
                .AddColumn("79dee9d4-adb3-4933-b575-580468fa637f", "Swim Distance Success")
                .AddColumn("35940779-4733-484c-be3d-e139c7cc2ec7", "Swim Distance Critical")
                .AddRow("db19f85a-615c-4fad-aa9a-b22b1106ac39", row =>
                {
                    row
                        .AddCell("0180df17-99f6-4df3-93a0-be4affba3caa", "5-15 feet")
                        .AddCell("207a5477-de95-45ec-80d7-bdcfd47e3d97", "5")
                        .AddCell("1dc66002-d912-4b0a-b724-ca4f43271f69", "5")
                        .AddCell("700e823b-7962-4c6e-8d98-04293b51dfa1", "5")
                        .AddCell("f918973d-62e0-4e28-b812-abfb6f09cc27", "10");
                })
                .AddRow("04ee2618-e261-4d9f-9c3a-5329e12de3f6", row =>
                {
                    row
                        .AddCell("0a339c31-b395-4a96-b68a-2e16ef98d604", "20-35 feet")
                        .AddCell("11ab9776-5893-4e8a-90d4-900dc148ef01", "5")
                        .AddCell("e816dff8-5798-4f34-a2a2-656938e797f8", "10")
                        .AddCell("81a8cf30-d07f-4794-ac49-c99ee0281313", "10")
                        .AddCell("85482e69-6796-4fb5-b774-2c0cf4a50944", "15");
                })
                .AddRow("d889fb15-1ee9-4fd7-b2d5-f75d036d8b60", row =>
                {
                    row
                        .AddCell("50cd9347-c620-4531-8f57-941268014243", "40-55 feet")
                        .AddCell("ecbd95dc-d15a-4ee0-8782-fa4407ec5320", "10")
                        .AddCell("ff0d4d4e-1522-4e47-bb7a-778530f50956", "15")
                        .AddCell("7c8e9994-dc4a-4845-8858-79ed14015841", "15")
                        .AddCell("52339f99-f6e7-4a31-829f-0c1541098229", "20");
                })
                .AddRow("f6a7752d-e9e1-484c-9725-02c0280530fd", row =>
                {
                    row
                        .AddCell("e29fa3eb-7207-4546-ad65-36d83449e033", "60-65 feet")
                        .AddCell("ba9f80fc-3abf-43b7-9476-887d0e2b6746", "15")
                        .AddCell("f042df74-d49f-47dc-b2e3-f7d9e1efe9c4", "20")
                        .AddCell("ca0de073-e003-43ea-95cb-e1b2c7692ced", "20")
                        .AddCell("d108e100-45aa-4b3b-81da-098d8ca6411d", "25");
                })
                .Build("6c59d51c-36b5-41be-9099-ffcb854db50e", "This table provides a quick reference for how far you can move with a Climb or Swim action.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd04dc29-14bd-4c32-a993-b16aab8c336c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 241
            };
        }
    }
}
