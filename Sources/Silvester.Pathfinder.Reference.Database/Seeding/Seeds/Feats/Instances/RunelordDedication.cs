using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RunelordDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("a3b9da31-4371-46c6-8e73-03854a0a6fe2");

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
            yield return new TextBlock { Id = Guid.Parse("cc72f0fb-a084-4ff5-b5de-9f519e8c57c2"), Type = TextBlockType.Text, Text = "Your rune magic increases, and you practice with your school’s associated weapon. You gain an additional cantrip of your chosen arcane school, and each time you gain a level (including this level), you add an additional spell from your chosen arcane school to your spellbook, with the same restrictions as the two spells you normally add." };
            yield return new TextBlock { Id = Guid.Parse("8afc7d9a-8cd3-4a10-9c9c-abcb6ad81553"), Type = TextBlockType.Text, Text = "__Add these additional spells to your spellbook manually.__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("eacaba0b-090c-4f49-a297-0c5fff024f5b"), ClassFeatures.Archetypes.RunelordSpecialization.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f8a372e-c1a1-47c9-ad7c-d53d106c0d4b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
