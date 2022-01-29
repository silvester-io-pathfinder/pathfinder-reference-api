using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationTangleLine : Template
    {
        public static readonly Guid ID = Guid.Parse("e598ea0a-6e42-4e00-b472-4877a0ecb636");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Tangle Line",
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
            yield return new TextBlock { Id = Guid.Parse("9d757a20-fed6-46d5-a821-f759980a6c88"), Type = TextBlockType.Enumeration, Text = $"*Thrown Only**" };
            yield return new TextBlock { Id = Guid.Parse("fce047e4-43ef-48aa-a926-b1132c7b5aeb"), Type = TextBlockType.Text, Text = $"Your weapon has an extensible line that you can use to knock your enemies over and quickly recall the weapon back to your hand. Your innovation gains the {ToMarkdownLink<Models.Entities.Trait>("ranged trip", Traits.Instances.RangedTrip.ID)} trait and the {ToMarkdownLink<Models.Entities.Trait>("tethered", Traits.Instances.Tethered.ID)} trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57a17552-db05-423b-b570-b8c92205a4e3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
