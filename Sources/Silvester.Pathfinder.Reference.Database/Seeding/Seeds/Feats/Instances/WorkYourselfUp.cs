using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WorkYourselfUp : Template
    {
        public static readonly Guid ID = Guid.Parse("bfb1584e-3eca-4786-8798-78293a715f11");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Work Yourself Up",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c4f777a-b36d-4492-b060-6c2c018149f1"), Type = TextBlockType.Text, Text = "You concentrate on your mental state, tapping into that raw emotional energy. Take your (feat: Catharsis) reaction, causing the catharsis activation and entering your emotional fervor as normal. The fervor lasts only until the end of your turn. At the end of your emotional fervor, you experience the effects of your emotional fallout, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c40fe5ee-f1a8-4194-b08d-18d41e5cb3b8"), Feats.Instances.CatharticMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e8ebd06-440d-4eb9-a376-442e996e9db4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
