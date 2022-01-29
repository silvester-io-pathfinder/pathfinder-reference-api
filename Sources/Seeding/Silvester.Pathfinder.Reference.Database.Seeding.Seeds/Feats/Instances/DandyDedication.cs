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
    public class DandyDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("45a138d7-cfac-4a7e-97a2-6c23ded26356");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dandy Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the dandy archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa9e6aa3-fd76-46d5-bc9c-3837ea547775"), Type = TextBlockType.Text, Text = $"You are a consummate student of dignity, etiquette, and fashion. You can use the Diplomacy skill to perform the special downtime activity, {ToMarkdownLink<Models.Entities.Feat>("Influence Rumor", Feats.Instances.InfluenceRumor.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("ddd4b60e-82a5-48ea-946c-eadd7830d3c8"), Type = TextBlockType.Text, Text = $"You become trained in Deception and Society; if you were already trained, you become an expert instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c30018a9-7336-422a-bcbe-94fc9b61b24b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("0b41fddd-c0bb-4d2e-b694-60c2d8384fa8"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("be8afd76-2aeb-4fc4-9803-23d0fc5bfa95"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8fd5263-c248-40ab-bd61-6e3ae7ca737a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
