using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineDisharmony : Template
    {
        public static readonly Guid ID = Guid.Parse("00c90844-4c4c-43f0-a95b-76c781ea4f1f");

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
            yield return new TextBlock { Id = Guid.Parse("da0dedfc-697c-4e38-ba1f-b7153222e42f"), Type = TextBlockType.Text, Text = "You pull out multiple opposing divine objects—such as the religious symbols of two deities that are hated enemies—and combine them in a display that is not only galling, but also causes discordant clashes of divine energy that are especially distracting to the faithful. Roll your choice of a Deception or Intimidation check against the Will DC of a creature you can see within 60 feet, with the following results. If the creature is particularly devoted to a deity, such as a cleric, celestial, monitor, fiend, or other creature with divine spells, you gain a +2 circumstance bonus to your skill check. The GM might determine that a creature that despises all deities, such as an alghollthu, is unaffected." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e1fa8d9a-3676-4056-9f39-7c559a1366ab"),
                CriticalSuccess = "The creature is flat-footed to your attacks until the end of your next turn.",
                Success = "The creature is flat-footed against your attacks until the end of your current turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b42f7058-1c8e-401e-953e-befa840c77ca"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
