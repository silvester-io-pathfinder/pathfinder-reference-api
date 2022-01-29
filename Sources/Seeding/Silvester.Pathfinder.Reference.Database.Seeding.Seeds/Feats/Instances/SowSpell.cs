using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SowSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("d4dba13f-ea5e-4d7b-ba6b-58bf08ed59ee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sow Spell",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5de6b20-c647-4e6b-9df8-470dfce12d5f"), Type = TextBlockType.Text, Text = $"You fold your spell into a seed. If your next action is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} using 1 action or 2 actions, the spell instead plants itself in an adjacent square. You must make all decisions regarding the spell at the time you cast it. Within the next 10 minutes, you can direct your sown spell to sprout and produce the spell's effects as a reaction, which is triggered when a creature enters the sown spell's space or a square adjacent to it. You can have only one sown spell at a time, and if you don't trigger the spell within 10 minutes, it dissipates and the spell is lost. A creature can notice the sown spell with a successful Perception check against your spell DC." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e282af25-3d83-4545-b75d-827e308bdf7d"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("df89cb7a-8a3a-4356-b851-5eaa15aa6a29"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("48781fff-cf23-49c0-8cc9-6d07c08f45f7"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5aebb54-08ec-4c87-8311-878150f42faa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
