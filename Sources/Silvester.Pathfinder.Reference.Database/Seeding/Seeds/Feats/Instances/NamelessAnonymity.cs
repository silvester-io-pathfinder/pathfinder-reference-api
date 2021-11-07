using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NamelessAnonymity : Template
    {
        public static readonly Guid ID = Guid.Parse("a08baa58-daf4-4b51-b2b7-83f2b7408bba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nameless Anonymity",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7b1087df-49f2-46d7-82da-960ffd8955eb"), Type = TextBlockType.Text, Text = "Your mask protects you further from divination. Once per day, you can cast (spell: nondetection) on yourself, heightened to the highest level of spell you can cast; the spell ends immediately if your mask is removed for even a moment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1a30344d-ac1b-4c28-9dcd-d052f4b88968"), Feats.Instances.MagicWarriorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a874ecd-9547-4457-bae3-4782160d95ad"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
