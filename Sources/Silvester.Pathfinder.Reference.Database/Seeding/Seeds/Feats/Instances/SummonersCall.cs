using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SummonersCall : Template
    {
        public static readonly Guid ID = Guid.Parse("7a855e7f-6bbf-4aec-870d-41e13843d5a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Summoner's Call",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait matching your eidolon's tradition ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = "You or your eidolon take damage from a foe or hazard.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3feeb58a-7ebf-4cc2-92a8-36ee664a7747"), Type = TextBlockType.Text, Text = "In a moment of danger, you call your eidolon to your side. Your eidolon teleports to an open space adjacent to you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2129b2af-b747-499e-b7d6-3970ffd970ee"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
