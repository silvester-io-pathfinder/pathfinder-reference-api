using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastGunnerAlreadyASpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("cbac2526-2d52-4d19-963f-9ea816abe6a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beast Gunner - Already a Spellcaster",
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
            yield return new TextBlock { Id = Guid.Parse("c933ada6-31ab-482a-b218-ce9ff13a304d"), Type = TextBlockType.Text, Text = "You learn one additional cantrip. If you’re a prepared caster, you can prepare this spell in addition to your usual cantrips per day; if you’re a spontaneous caster, you add this cantrip to your spell repertoire." };
            yield return new TextBlock { Id = Guid.Parse("f18b3d21-7b41-430b-aeba-f54b9dc5a682"), Type = TextBlockType.Text, Text = "__Add the extra spell slot manually.__" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e045b26c-2b19-4a9d-8168-e6896a7392d8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
