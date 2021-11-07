using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RicochetMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("9f196652-98b8-4eb3-86ce-717d0d866ef9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ricochet Master",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9ca020f9-debb-4d01-87dc-a17f6ba24436"), Type = TextBlockType.Text, Text = "You have an eye for angles and can find shots that others believe are impossible. When using (feat: Ricochet Shot), you can bounce your bullet off up to two solid surfaces within your weapon’s first range increment instead of just one." };
            yield return new TextBlock { Id = Guid.Parse("ce421db2-b6d6-4785-8a3c-150f76951e86"), Type = TextBlockType.Text, Text = "In addition, a creature is flat-footed the first time you attack it with a (feat: Ricochet Shot) during an encounter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b0b36b56-dc19-4c52-bb36-0081b0cfd0a0"), Feats.Instances.RicochetShot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a7f2072c-43fb-414a-8211-318b2ded6046"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
