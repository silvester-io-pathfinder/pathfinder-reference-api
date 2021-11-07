using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiscipleOfShade : Template
    {
        public static readonly Guid ID = Guid.Parse("5692288e-a70b-421c-b0ea-548edcafebf5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disciple of Shade",
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
            yield return new TextBlock { Id = Guid.Parse("a54111ab-475e-43e6-8fbc-3c0efd2eacff"), Type = TextBlockType.Text, Text = "You’ve delved deeper into the mysteries of shadow and become blessed with magical power that increases your skills in the arts of deception and persuasion. You gain the (spell: inscrutable mask) domain spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0217ffcb-6782-4167-ad62-dd4a6f2b7101"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("460c41f4-a26f-4051-928c-c88b90fa5d8f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
