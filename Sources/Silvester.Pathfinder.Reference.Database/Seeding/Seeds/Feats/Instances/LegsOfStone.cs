using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegsOfStone : Template
    {
        public static readonly Guid ID = Guid.Parse("3cc4b8d9-ae52-470c-a224-c0138605ffcb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legs of Stone",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("005323ff-deaf-4b59-b118-57fd653c6403"), Type = TextBlockType.Text, Text = "You gain a +2 status bonus to your Fortitude and Reflex DCs against attempts to (action: Shove) or (action: Trip) you. You can (action: Shove) creatures even if you don’t have a hand free. When you successfully (action: Shove) a foe, you can (action: Stride) away from your opponent (instead of toward it), but you must move the same distance in the opposite direction from where you (action: Shoved | Shove) it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2565ba9f-8703-452f-abe5-9e709a879986"), Feats.Instances.GolemGrafterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c95fd5a6-8681-4ed1-9a84-7b3528ddaf60"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
