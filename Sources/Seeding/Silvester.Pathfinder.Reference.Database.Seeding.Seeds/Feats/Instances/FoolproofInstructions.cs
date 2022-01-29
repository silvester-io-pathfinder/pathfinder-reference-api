using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FoolproofInstructions : Template
    {
        public static readonly Guid ID = Guid.Parse("b86356bf-88b0-4f64-81c7-352532c980e8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Foolproof Instructions",
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
            yield return new TextBlock { Id = Guid.Parse("3c1ed044-c2a3-481e-9925-80b65ad40531"), Type = TextBlockType.Text, Text = $"You feel confident that you can explain your scrolls so well that even your allies can use them... hopefully. During your daily preparations, you can select a single scroll and instruct a single ally in its use. Until your next daily preparations, the ally can attempt to use the scroll with a single action that has the {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} trait. The ally rolls the skill corresponding to the spellcasting tradition. The GM determines the DC based on the scroll's level, possibly adjusted for the situation. If the spell has a spell attack bonus or a spell DC, use your level as the proficiency bonus and the highest of your ally's Intelligence, Wisdom, or Charisma modifiers." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("227eaf55-67e0-44b1-bc07-d1342270ee40"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("115ee834-63ab-467a-bee2-f04798cc49fa"),
                
                Success = "For the rest of the ally's turn, they can spend actions to (activity: Cast the Spell | Cast a Spell).",
                Failure = "The ally misremembers your instructions and can't use the scroll this turn.",
                CriticalFailure = "The ally misunderstood your instructions and can't use the scroll.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf87974f-bd2e-43ce-aa87-b764f43eb73c"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
