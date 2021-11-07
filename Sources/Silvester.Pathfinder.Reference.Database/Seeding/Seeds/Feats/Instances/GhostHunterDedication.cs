using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GhostHunterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("4d654b07-6ea3-4f11-983e-b6fca42e6012");

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
            yield return new TextBlock { Id = Guid.Parse("122a9d7b-ac83-44c2-b482-7fa7b99068ee"), Type = TextBlockType.Text, Text = "You have focused your training on hunting and defeating ghosts, spirits, and all manner of haunts. Pick Spirit Lore or Haunt Lore; you become trained in this skill. If you were already trained in both skills, you become trained in a new Lore skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("a4f94413-dc9a-4523-be06-04fbbdb5b613"), Type = TextBlockType.Text, Text = "Choose two cantrips from the occult spell list. Each cantrip must have the (trait: divination), (trait: enchantment), or (trait: necromancy) trait. You can cast these spells as innate occult spells. You gain access to the (activity: Cast a Spell) activity if you didn&#39;t have it already. You&#39;re trained in occult spell attack rolls and spell DCs. You can usually replace material components with somatic components, so you don&#39;t need a spell component pouch. Your key spellcasting ability for these spells is Charisma." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("7c09051d-1d24-4f30-a0c9-e23099cc604a"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("919b4c19-6f74-4a78-8e2d-4a55ba305402"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("fbafb9de-363d-4bc1-80f4-413be41b5c82"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7adcfb16-ea7e-434f-aa55-b3036741781c"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
