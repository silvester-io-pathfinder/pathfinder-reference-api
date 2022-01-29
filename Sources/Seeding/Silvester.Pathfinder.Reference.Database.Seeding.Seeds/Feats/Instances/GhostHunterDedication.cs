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
    public class GhostHunterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("6a271ac6-0a13-4e48-8328-5637f3fef2b6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ghost Hunter Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the ghost hunter archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3126d179-7107-4361-b6ab-f6b5dfa9aeab"), Type = TextBlockType.Text, Text = $"You have focused your training on hunting and defeating ghosts, spirits, and all manner of haunts. Pick Spirit Lore or Haunt Lore; you become trained in this skill. If you were already trained in both skills, you become trained in a new Lore skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("ef5a5629-71af-4516-82d3-c8438a3b0d63"), Type = TextBlockType.Text, Text = $"Choose two cantrips from the occult spell list. Each cantrip must have the {ToMarkdownLink<Models.Entities.Trait>("divination", Traits.Instances.Divination.ID)}, {ToMarkdownLink<Models.Entities.Trait>("enchantment", Traits.Instances.Enchantment.ID)}, or {ToMarkdownLink<Models.Entities.Trait>("necromancy", Traits.Instances.Necromancy.ID)} trait. You can cast these spells as innate occult spells. You gain access to the {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} activity if you didn't have it already. You're trained in occult spell attack rolls and spell DCs. You can usually replace material components with somatic components, so you don't need a spell component pouch. Your key spellcasting ability for these spells is Charisma." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("33d10bba-2795-420c-bbdd-0e026f9ee43e"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("1758296d-023c-49e9-915d-0c15dff53b1d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("f873ec35-679d-4a34-af1a-0d7f4b1bab60"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7f14d13-a89b-4aa4-81e4-daee4fa74805"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
