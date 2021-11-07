using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MinionGuise : Template
    {
        public static readonly Guid ID = Guid.Parse("1eb2d687-0c55-4ae1-81e5-d88e7e165642");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Minion Guise",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c361491d-63cd-4200-b9a9-ccf1a08727ed"), Type = TextBlockType.Text, Text = "When you are in your social identity, you can also grant a social identity to an animal companion, familiar, or other minion you gained from a class feature. When changing to your social identity, you also change your minion’s appearance to that of a socially acceptable creature of its type, such as grooming a wolf to appear as a large dog or disguising a familiar to appear as an exotic pet. Commanding your minion to use unusual magical or combat abilities it gained from your class features or feats while in this social identity risks exposing your vigilante identity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("7fc561bc-9edc-4a03-9398-50497f83427b"), or => 
            {
                or.HaveSpecificAnimalCompanionAmount(Guid.Parse("26309900-f29e-453b-8ced-840b2cce91c5"), Comparators.GreaterThanOrEqualTo, amount: 1);
                or.HaveAnyFamiliar(Guid.Parse("aeeb7c91-3d0f-44a8-ab37-1fff20ff72cd"));
            });
            builder.HaveSpecificSkillProficiency(Guid.Parse("ea675fda-40df-4e87-a1dd-d505afec0b6b"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83ca8ae1-5e83-4df4-a8da-eecdc590557c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
