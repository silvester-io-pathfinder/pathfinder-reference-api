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
    public class SharpshooterAutomaton : Template
    {
        public static readonly Guid ID = Guid.Parse("8c2718d9-998f-410f-a2eb-307c82166c65");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Sharpshooter Automaton"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("402a2a1c-4b95-46f2-b940-7b57fb3d94a2"), Type = TextBlockType.Text, Text = "Your lithe, humanoid shape is designed for speed and accuracy suitable for ranged combat. You gain the Automaton Aim action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("b8a1e8de-dc15-4569-97e1-7d7aa697b47a"), Feats.Instances.AutomatonAim.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("851e008a-1b05-4a49-a26c-8c2717bf3686"),
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
