using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SignatureSpellExpansion : Template
    {
        public static readonly Guid ID = Guid.Parse("67164613-f53a-4979-b558-ede3586f8bf8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Signature Spell Expansion",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b57a237f-ae59-4645-bf50-e40196246ba3"), Type = TextBlockType.Text, Text = $"Your direct mental grasp of your power lets you cast more spells with greater freedom. You gain two additional signature spells, each of which must have a minimum level of 3rd or lower." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5481b3b5-0bc0-462c-af65-c730d3203149"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
