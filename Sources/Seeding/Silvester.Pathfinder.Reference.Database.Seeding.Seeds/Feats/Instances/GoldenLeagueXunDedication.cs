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
    public class GoldenLeagueXunDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("6e11a72a-ccb6-474b-89ba-dd8c34be9714");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Golden League Xun Dedication",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the Golden League Xun archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0cba1141-5441-4acd-9f98-821a67bc56ff"), Type = TextBlockType.Text, Text = $"You are a xun for the Golden League, aiding the organization. You gain expert proficiency in two of the following skills (or in two other skills of your choice in which you're trained, if you were already an expert in the listed skills): Athletics, Deception, Intimidation, or Stealth. In addition, if you use Underworld Lore to {ToMarkdownLink<Models.Entities.SkillAction>("Earn Income", SkillActions.Instances.EarnIncome.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}, when you get a success, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificLoreSpecificProficiency(Guid.Parse("0b64cc5a-7ec5-46a9-a896-bdc96496b03c"), Proficiencies.Instances.Master.ID, Lores.Instances.Underworld.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b5ceaa6-63bc-4ab8-857b-af24122b3c45"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
