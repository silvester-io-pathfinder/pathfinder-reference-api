using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EternalBoost : Template
    {
        public static readonly Guid ID = Guid.Parse("9ed23669-af51-41cb-bac3-c2a29943f8fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eternal Boost",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c9cb30b6-137c-4932-9d45-af395b0e9fad"), Type = TextBlockType.Text, Text = "Your link with your eidolon is so intense that you continuously reinforce its abilities. You are permanently quickened; you can use your extra action only to cast (spell: boost eidolon) or (spell: reinforce eidolon). While in exploration mode, you can declare that you are also continually casting (spell: boost eidolon) or (spell: reinforce eidolon) even while using a different exploration activity. If you do, even before your first turn in a combat encounter, that cantrip is active as if you had cast it on your previous turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b83b68e-0dca-4017-afc9-1634a419ab2e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
