using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RunelordDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("e230acbe-cd95-47ac-b4ad-350504e64264");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Runelord Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the runelord archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b549bebf-476b-49ea-a720-b1ae434bb66e"), Type = TextBlockType.Text, Text = $"Your rune magic increases, and you practice with your school's associated weapon. You gain an additional cantrip of your chosen arcane school, and each time you gain a level (including this level), you add an additional spell from your chosen arcane school to your spellbook, with the same restrictions as the two spells you normally add." };
            yield return new TextBlock { Id = Guid.Parse("bb3ac94f-ab63-4a5f-a9b3-5bf82da8aebf"), Type = TextBlockType.Text, Text = $"__Add these additional spells to your spellbook manually.__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("0b1ea00f-4f55-4781-8d6f-cb25896fa2cc"), ClassFeatures.Archetypes.RunelordSpecialization.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e5eec3e-3b10-48d9-87e2-0477609a0bba"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
