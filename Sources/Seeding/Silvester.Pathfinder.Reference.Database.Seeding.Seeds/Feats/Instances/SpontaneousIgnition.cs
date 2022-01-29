using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpontaneousIgnition : Template
    {
        public static readonly Guid ID = Guid.Parse("eab76019-e215-4b5e-a165-cae3dccf3d25");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spontaneous Ignition",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1cfbe094-7cc3-40e7-aacd-be2a60e24874"), Type = TextBlockType.Text, Text = $"The sheer intensity of your mental focus causes spontaneous combustion. Use this amp in place of the psi cantrip's normal amp entry. The amped psi cantrip must be one that deals damage and doesn't have a duration." };
            yield return new TextBlock { Id = Guid.Parse("51ea03d0-1dfb-48ab-8688-b801baa2b6b6"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("1b2bcf26-44d6-417d-a104-aaa642bf74f1"), Type = TextBlockType.Text, Text = $"~ Amp: Half of any damage dealt by the amped psi cantrip is instead fire damage, and the spell also deals an additional 1 fire damage per spell level. The spell gains the {ToMarkdownLink<Models.Entities.Trait>("fire", Traits.Instances.Fire.ID)} trait. If the spell deals more than one type of damage, change half the damage of each type to fire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13d22878-d94e-4b05-92bc-c72452ae030b"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
