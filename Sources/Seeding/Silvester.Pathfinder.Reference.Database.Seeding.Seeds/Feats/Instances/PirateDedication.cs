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
    public class PirateDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("1452d574-634d-46b0-a566-01037f07ba24");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pirate Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the pirate archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d958b97-abcd-428e-ba93-c21c59a9840b"), Type = TextBlockType.Text, Text = $"As a pirate, you sail the seas in search of enemy ships to plunder. You become trained in Sailing Lore, or become an expert in it if you were already trained. You ignore the effects of difficult terrain or uneven ground caused by a ship's movement. Additionally, you gain the {ToMarkdownLink<Models.Entities.Feat>("Boarding Assault", Feats.Instances.BoardingAssault.ID)} action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("49ad711b-8641-4196-bb8a-edfb6deabd7c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bd7ac683-7f33-46c7-acc5-6853843bc6c0"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("7b03a9c6-3759-4b40-ba11-fdf185835956"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c74cdc31-3a19-4d52-8fa0-268d81432527"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
