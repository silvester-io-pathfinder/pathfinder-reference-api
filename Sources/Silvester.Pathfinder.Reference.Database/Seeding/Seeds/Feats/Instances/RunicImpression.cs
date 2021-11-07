using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RunicImpression : Template
    {
        public static readonly Guid ID = Guid.Parse("56962ed2-0154-4f1a-89f2-8ecb068d4346");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Runic Impression",
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
            yield return new TextBlock { Id = Guid.Parse("0954e6d6-2047-4fe9-83d1-90efb932ef3e"), Type = TextBlockType.Text, Text = "You can temporarily replicate the effects of a property rune for your weapon or unarmed attacks. You learn the (spell: runic impression) conflux spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFocusPool(Guid.Parse("4e933419-d21b-4b0c-979a-60b3316d4c2b"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08abf1f4-1523-4d57-9857-82daf6477c9d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
