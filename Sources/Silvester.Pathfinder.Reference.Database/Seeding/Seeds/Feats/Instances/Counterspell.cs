using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Counterspell : Template
    {
        public static readonly Guid ID = Guid.Parse("8f5122e1-ebc4-488b-9281-6867926d2e96");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Counterspell",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of spells you cast ((trait: arcane), (trait: divine), (trait: primal), or (trait: occult)).",
                Trigger = "A creature Casts a Spell that you have prepared.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("24066ad9-c24a-428e-ab67-b292e8e8dc48"), Type = TextBlockType.Text, Text = "When a foe (activity: Casts a Spell | Cast a Spell) and you can see its manifestations, you can use your own magic to disrupt it. You expend a prepared spell to counter the triggering creature’s casting of that same spell. You lose your spell slot as if you had cast the triggering spell. You then attempt to counteract the triggering spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bdfb81e2-1c8c-4e50-9b9f-2063c505c6d9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
