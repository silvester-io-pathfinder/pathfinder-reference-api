using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class MageAutomaton : Template
    {
        public static readonly Guid ID = Guid.Parse("23c8c5f7-9eee-43d4-aebe-b213b5b313da");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Mage Automaton"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ad13e82b-9417-4cef-ba99-3fcaa15b240b"), Type = TextBlockType.Text, Text = "" };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificMagicTraditionAnyInnateSpell(Guid.Parse("379afc8e-0226-4fa7-ab48-bdf603de04a4"), MagicTraditions.Instances.Arcane.ID, spellLevel: 0);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24259695-6d0a-48c0-8dcb-e113f08d921d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 36
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Automaton.ID;
        }
    }
}
