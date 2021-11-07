using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FinestTrick : Template
    {
        public static readonly Guid ID = Guid.Parse("31eae343-5051-4c2c-9c4e-6899afd7b914");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Finest Trick",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5997cd1-3b48-43ec-8de1-85595d40cdcd"), Type = TextBlockType.Text, Text = "Many fiends—rakshasa rajas and demonic succubi most famously—can take on the forms of others. With practice, you can do the same. When you use (feat: Devil in Plain Sight), you can alter your appearance to match a generic member of your base ancestry, rather than one that’s obviously you without your tieflings features. In addition, you can imitate a specific person’s appearance (of any ancestry of the same size and kind as your base ancestry, typically a humanoid for most ancestries) if you consume a bit of their blood, a lock of their hair, or appropriate equivalents as part of the action. You still must know what the creature looks like, and you must be aware that the consumed portion comes from their body." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eb288ca4-f7f8-4755-a439-49a0424090b4"), Feats.Instances.DevilInPlainSight.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("094eee8e-de40-4110-9376-793b0fea5f7f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
