using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JinxGlutton : Template
    {
        public static readonly Guid ID = Guid.Parse("84e56fe1-88ef-4be4-80bc-64f3a3a5c72d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Jinx Glutton",
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
            yield return new TextBlock { Id = Guid.Parse("24ef48ee-97d4-49ba-b539-4bd1b1716132"), Type = TextBlockType.Text, Text = "You can (feat: Eat Fortune) once per hour, rather than once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f10b7140-0ae6-429e-b265-25587b3c0abc"), Feats.Instances.EatFortune.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1b73cf9-7099-4c53-90df-51a3aefb8723"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
