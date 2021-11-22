using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationEnergyBarrier : Template
    {
        public static readonly Guid ID = Guid.Parse("41ac513e-5ef9-4da1-ba49-e792622d7c8f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Energy Barrier",
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
            yield return new TextBlock { Id = Guid.Parse("9fd6b03b-e2d1-42bd-a16b-464a6024eed7"), Type = TextBlockType.Text, Text = "Your armor's defenses ablate any kind of energy coming your way. While wearing your armor, you gain resistance to all energy damage (acid, cold, electricity, fire, force, negative, positive, and sonic damage) equal to 2 + half your level. You must have the (feat: harmonic oscillator | Modification - Harmonic Oscillator), (feat: metallic reactance | Modification - Metallic Reactance), or (feat: phlogistonic regulator | Modification - Phlogistonic Regulator) modification to select this modification." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce78a6aa-6bb1-465f-b111-81586b14178b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
