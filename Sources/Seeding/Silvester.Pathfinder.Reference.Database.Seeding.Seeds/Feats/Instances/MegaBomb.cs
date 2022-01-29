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
    public class MegaBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("3af8cd22-b44b-4c91-9cb5-e48a96a27f19");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mega Bomb",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are holding an infused alchemical bomb you crafted, with a level at least 3 lower than your Advanced Alchemy level.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19075766-64b4-441b-96ac-6b673a91be7f"), Type = TextBlockType.Text, Text = $"You add an incredibly powerful additive to a held bomb to create a mega bomb, greatly increasing its area and power. You use an {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action to throw the mega bomb, rather than {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, and you don't make an attack roll. The mega bomb affects creatures in a 30-foot-radius burst, centered within 60 feet of you. The bomb deals damage as if each creature were the primary target, with a basic Reflex save. On a failed save, a creature also takes any extra effects that affect a primary target (such as flat-footed from bottled lightning). While all targets in the area take splash damage as primary targets, there is no further splash beyond that area. If your next action after creating a mega bomb isn't an {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action to throw it, the mega bomb denatures and loses all effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d91ab0ba-a655-4665-8053-23374d489108"), Feats.Instances.ExpandedSplash.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5d6dc81d-31bc-4c96-b46e-586f1fa78e1e"), Traits.Instances.Additive.ID, "3");
            builder.Add(Guid.Parse("59dee13a-18f9-4753-b11a-44367b2893c1"), Traits.Instances.Alchemist.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4444570c-7a29-4393-be46-a800888afbd6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
