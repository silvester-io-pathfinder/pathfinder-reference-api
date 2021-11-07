using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Miniaturize : Template
    {
        public static readonly Guid ID = Guid.Parse("0ff82f37-162a-4f35-89b1-6ff3b8b5a138");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Miniaturize",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71c22367-1eb2-4e92-888c-0728e545b79f"), Type = TextBlockType.Text, Text = "Your eidolon can shrink even further. When using (feat: Shrink Down), your eidolon can reduce its size to Tiny." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c88a2ca1-b366-4bb4-a80f-7e416825d094"), Feats.Instances.ShrinkDown.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab47afd5-893f-491a-ad8c-f6b20990e20f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
