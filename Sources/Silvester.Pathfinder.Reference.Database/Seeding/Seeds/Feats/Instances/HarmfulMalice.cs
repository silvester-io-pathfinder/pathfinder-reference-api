using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HarmfulMalice : Template
    {
        public static readonly Guid ID = Guid.Parse("9e6f5de5-a3eb-487c-9981-2f19abd7f964");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Harmful Malice",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b7af5380-a23b-4963-89d4-3c799e98851e"), Type = TextBlockType.Text, Text = "Your (action: Strikes | Strike) deal an additional 1d4 negative damage. Once while the armament is manifested, you can cast harm as an innate spell, with a level equal to half your level rounded up." };
            yield return new TextBlock { Id = Guid.Parse("5cd0b95d-0d88-4237-91d4-ace1fd9b0d01"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ Reduce any damage you would deal by half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5cf2d70-1e6c-4877-bb13-bba6c0026381"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
