using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterCatharticSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("6085f75f-9c27-4267-b805-89b6b68bc8a4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Cathartic Spellcasting",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d796111f-1811-4fee-8749-141802422852"), Type = TextBlockType.Text, Text = "Your proficiency ranks for your cathartic mage spell attack rolls and spell DCs increase to master, you gain a 7th-level spell slot and you can select a third spell from your repertoire as a signature spell. At 20th level, you gain an 8th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("80a9d9a9-f3d2-49f1-b870-1276170d7ad7"), Feats.Instances.ExpertCatharticSpellcasting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8be3ea5f-240f-4dcb-94fc-b97e7c5ae68f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
