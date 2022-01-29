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
    public class WorldsphereGravity : Template
    {
        public static readonly Guid ID = Guid.Parse("972014f2-1ade-4714-ad60-a0cf958df41b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Worldsphere Gravity",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b3351bcc-a2c4-45b6-abee-14128f3aa0a9"), Type = TextBlockType.Text, Text = $"Though creating demiplanes usually requires lengthy rituals, you know how to establish minor planar effects in imitation of Syndara's masterpieces. If your next action is to Cast a Spell of at least 5th level from your spell slots that affects an area, you can apply one of the following planar effects to a 20-foot burst centered within the spell's area. The effect persists for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("161f89e1-b16a-4670-88b0-a17fa2ca80e0"), Type = TextBlockType.Enumeration, Text = $" : **Gravitational Morass** The pull of gravity is amplified here, creating greater difficult terrain. Flying creatures that pass through the area must succeed at a Reflex save against your spell DC or fall to the ground, taking bludgeoning damage equal to half the distance fallen." };
            yield return new TextBlock { Id = Guid.Parse("51263da9-4098-46b1-aacf-4c9c0266d33e"), Type = TextBlockType.Enumeration, Text = $" : **Flowing Time** Erratic timestreams aid you within this space. A creature that starts its turn in the burst is affected by {ToMarkdownLink<Models.Entities.Spell>("haste", Spells.Instances.Haste.ID)} on that turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1a36bae-264e-487c-a6ab-522d2541dec3"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
