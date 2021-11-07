using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MartialExercise : Template
    {
        public static readonly Guid ID = Guid.Parse("7af7cca9-02e6-4d2e-8aa5-11480777d067");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Martial Exercise",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79bd2b0c-f967-404a-816c-3baaf36852df"), Type = TextBlockType.Text, Text = "You&#39;ve become comfortable in using weapons that you might not have picked up before training with the Swords. Choose one weapon group, such as hammer or sword. Whenever your proficiency rank in any weapon increases to expert or beyond, you also gain that new proficiency rank with both simple and martial weapons of your chosen weapon group." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7a8190ab-cbb3-4f62-aacb-60b74f325c6f"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33ef2d50-8798-41f7-b45b-73964d275713"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
