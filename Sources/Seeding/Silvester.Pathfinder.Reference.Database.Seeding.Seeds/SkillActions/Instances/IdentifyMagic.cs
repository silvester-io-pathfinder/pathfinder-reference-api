using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class IdentifyMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("d0dcfb6f-00ad-45ce-a436-c50496646ef4");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Identify Magic",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("698e7d1d-ccbb-40e2-909d-dbd74e867bfc"), Type = TextBlockType.Text, Text = "Using the skill related to the appropriate tradition, as explained in Magical Traditions and Skills on page 238, you can attempt to identify a magical item, location, or ongoing effect. In many cases, you can use a skill to attempt to Identify Magic of a tradition other than your own at a higher DC. The GM determines whether you can do this and what the DC is." };
            yield return new TextBlock { Id = Guid.Parse("87e7b74d-3bb0-403e-9af4-ce4c9fdac5eb"), Type = TextBlockType.Text, Text = "Once you discover that an item, location, or ongoing effect is magical, you can spend 10 minutes to try to identify the particulars of its magic. If your attempt is interrupted, you must start over. The GM sets the DC for your check. Cursed or esoteric subjects usually have higher DCs or might even be impossible to identify using this activity alone. Heightening a spell doesn't increase the DC to identify it." };
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
            yield return Traits.Instances.Secret.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("dee61b82-34f2-48d7-b58e-57c71494d03b"),
                CriticalSuccess = "You learn all the attributes of the magic, including its name (for an effect), what it does, any means of activating it (for an item or location), and whether it is cursed.",
                Success = "For an item or location, you get a sense of what it does and learn any means of activating it. For an ongoing effect (such as a spell with a duration), you learn the effect's name and what it does. You can't try again in hopes of getting a critical success.",
                Failure = "You fail to identify the magic and can't try again for 1 day.",
                CriticalFailure = "You misidentify the magic as something else of the GM's choice."
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Exploration.ID;
        }

        protected override Table? GetTable()
        {
            return new TableBuilder("f5122968-afdf-439f-8a35-95c6a7091eeb", "Each magical tradition has a corresponding skill, as shown on the table below. You must have the trained proficiency rank in a skill to use it to Identify Magic or Learn a Spell. Something without a specific tradition, such as an item with the magical trait, can be identified using any of these skills.")
                .AddColumn("cfea6c9a-234f-4668-b527-53909a114c26", "Magic Tradition")
                .AddColumn("66bdb818-7bfb-47b6-ae20-e4fc34d9758f", "Corresponding Skill")
                .AddRow("9beeb5f4-b844-40d8-94a7-576b07dc2431", row =>
                {
                    row
                        .AddCell("4872be4b-97fc-4445-a3a3-3e6c63833cd6", "Arcane")
                        .AddCell("b89b9945-adb7-46f4-bcbc-80d60e8350ad", "Arcana");
                })
                .AddRow("19e19d7e-8b8f-4b11-b71b-ed11b069d68e", row =>
                {
                    row
                        .AddCell("b57122ae-4445-4c63-a5b8-5e711976fb32", "Divine")
                        .AddCell("9456989d-8c6e-4835-8d71-614134116de4", "Religion");
                })
                .AddRow("705040eb-079c-45ca-9682-d04b3418bbae", row =>
                {
                    row
                        .AddCell("b7b2b383-5b2f-4198-a514-42aca77470ce", "Occult")
                        .AddCell("8e736862-6e24-4717-83f1-9d06ef0bd3d7", "Occultism");
                })
                .AddRow("390ed44f-b904-4ea1-9262-5ae664ee7174", row =>
                {
                    row
                        .AddCell("5e2ad400-7134-4a6d-b491-239e28f54b2b", "Primal")
                        .AddCell("03811b2e-aa91-4666-8ffd-c38248e10688", "Nature");
                })
                .Build();
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3cc8721-b637-4d68-9d8b-ce45831cb90a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 238
            };
        }
    }
}
