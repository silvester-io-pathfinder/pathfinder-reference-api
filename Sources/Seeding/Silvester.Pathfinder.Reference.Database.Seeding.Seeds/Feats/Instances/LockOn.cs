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
    public class LockOn : Template
    {
        public static readonly Guid ID = Guid.Parse("5715ac71-defa-4749-ace1-9bb4a43b4788");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lock On",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8142c7d3-7c88-4ad1-a2d9-8014a0e76f78"), Type = TextBlockType.Text, Text = $"Aha! You lock on to your enemy's weak point to assist your construct companion in destroying it. When you Lock On, designate an enemy you can see. If your next action is to Command your construct, the construct gains a +2 circumstance bonus to attack rolls against the designated enemy until the end of the turn. If you use 2 actions for the Command, the bonus is instead a +3 circumstance bonus, or a +4 circumstance bonus if you're legendary in Crafting." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("afe40540-f3e6-4c9f-85a8-54037e15cadb"), Innovations.Instances.Construct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Inventor.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba42c999-6801-42ec-aca4-cf2a19393905"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
