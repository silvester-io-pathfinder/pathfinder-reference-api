using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MartialArtistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("b843e076-29f6-4605-a905-5e7db0cffbda");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Martial Artist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the martial artist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aaf86ff0-48fa-4213-9622-db9a41aa0e47"), Type = TextBlockType.Text, Text = "You have trained to use your fists as deadly weapons. The damage die for your fist unarmed attacks becomes 1d6 instead of 1d4. You don’t take the -2 circumstance penalty for making a lethal attack with your nonlethal unarmed attacks. Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency rank in all unarmed attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8064f98-aa5f-480c-984b-0e955ad64790"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
