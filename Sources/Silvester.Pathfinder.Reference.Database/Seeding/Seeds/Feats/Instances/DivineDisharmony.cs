using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineDisharmony : Template
    {
        public static readonly Guid ID = Guid.Parse("76b770e5-a011-4342-bdb8-26117a78a054");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Disharmony",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07ad711b-071a-4c93-b086-e4de63f093cc"), Type = TextBlockType.Text, Text = "You pull out multiple opposing divine objects—such as the religious symbols of two deities that are hated enemies—and combine them in a display that is not only galling, but also causes discordant clashes of divine energy that are especially distracting to the faithful. Roll your choice of a Deception or Intimidation check against the Will DC of a creature you can see within 60 feet, with the following results. If the creature is particularly devoted to a deity, such as a cleric, celestial, monitor, fiend, or other creature with divine spells, you gain a +2 circumstance bonus to your skill check. The GM might determine that a creature that despises all deities, such as an alghollthu, is unaffected." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("cb333fa0-585d-46d9-b23c-7ee77e41ae0a"),
                CriticalSuccess = "The creature is flat-footed to your attacks until the end of your next turn.",
                Success = "The creature is flat-footed against your attacks until the end of your current turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eff581ad-9f0c-4831-8c56-ef491b9112f0"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
