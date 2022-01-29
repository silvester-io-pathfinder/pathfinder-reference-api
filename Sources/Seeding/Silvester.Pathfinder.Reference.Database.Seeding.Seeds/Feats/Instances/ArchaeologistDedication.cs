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
    public class ArchaeologistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("46c9d405-7f3d-4eba-b8b6-3e5c31babdcb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Archaeologist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the archaeologist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ece5184-b5d1-4541-83ae-db8db3a4dfc4"), Type = TextBlockType.Text, Text = $"You are a student of peoples and their histories, and are in constant pursuit of knowledge and artifacts from the past. You become an expert in Society and Thievery, and you gain a +1 circumstance bonus to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} about ancient history, peoples, and cultures." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7cec1431-0254-4df2-b989-5512e1c583d5"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("a3145702-e0b1-4e4b-9c87-a9d9eff69f3b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("50051148-41b7-4117-a707-034b31a5eb69"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("29fd2349-6f84-4eb9-a97e-b5e4ba8ab2e0"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("97c7d2f9-879e-4612-a34d-4e9e9c9e22b9"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("736d219e-2ed2-43cc-acb8-05d702953d95"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
