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
    public class ArmorAssist : Template
    {
        public static readonly Guid ID = Guid.Parse("d3148608-dd77-45a5-9a70-a5d2a70bce24");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armor Assist",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("63052f6e-ae42-46a6-b238-07e5939054c4"), Type = TextBlockType.Text, Text = $"After your service aiding armored combatants, you are practiced in helping yourself and others don heavy gear. You can attempt an Athletics or Warfare Lore check with a DC determined by the GM (but usually 15 for common armor, DC 20 for uncommon armor, and DC 25 for rare armor) to halve the time you take to don armor. You can halve an ally's time to don armor by working with them to don the armor and succeeding at an Athletics or Warfare Lore check against the same DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("d9fd81b4-49fe-4c53-9493-7678b208018b"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("cfe092d5-8d39-4285-86c9-70a39cbbe643"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
                or.HaveSpecificLoreSpecificProficiency(Guid.Parse("20a8d101-e1b4-49a1-990a-13cd48c3a94d"), Proficiencies.Instances.Trained.ID, Lores.Instances.Warfare.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82de8582-2955-4622-a203-fe7a7341057c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
