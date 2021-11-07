using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("50db6bba-9f42-40c0-9266-1f49124130bd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elementalist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the elementalist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3b13bbf8-deb9-439c-80a7-78a09cd94cc1"), Type = TextBlockType.Text, Text = "Each day when you make your daily preparations, you can attune yourself to one element of your choice: air, earth, fire, or water. You gain resistance equal to half your level (minimum 1 resistance) against damage dealt by effects with your attuned elemental trait. This attunement lasts until you next make your daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("a2d6db25-7657-47c1-b5e5-402812762726"), ClassFeatures.Archetypes.ElementalMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6a221b1-6792-4c98-b1c1-30a7732b3198"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
