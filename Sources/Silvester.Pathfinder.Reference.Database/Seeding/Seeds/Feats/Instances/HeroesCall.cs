using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeroesCall : Template
    {
        public static readonly Guid ID = Guid.Parse("db7aeac2-d8eb-4ffd-aa08-6e8e6e12ad1d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heroes' Call",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4b75ac59-f2e1-47ce-852e-c42e75fec0a6"), Type = TextBlockType.Text, Text = "The songs of ancient heroes echo through your mind and quicken your pulse, especially in dire straits. You gain (spell: heroism) as a 3rd-level innate occult spell that you can cast once per day. If you (activity: Cast the Spell | Cast a Spell) when you have half or fewer Hit Points, you also gain temporary Hit Points equal to twice your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eec0c32d-c29c-46f9-aa9c-e488d2b78f53"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
