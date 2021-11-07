using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RakshasaMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("846c18f0-27e5-41db-94b6-48d9ea3e1c7c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rakshasa Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c4b3137a-b85d-4a3e-9455-0dbe3ae60d2b"), Type = TextBlockType.Text, Text = "You remember the secrets of your rakshasa forebears and know how to apply those memories to get results. You can cast (spell: humanoid form) and (spell: illusory creature) once per day each as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d54a2631-620b-4f41-be0c-f456cb2f1e3f"), Feats.Instances.Beastbrood.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("97f17e1f-5260-4ae7-864f-71d3d22591e7"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
