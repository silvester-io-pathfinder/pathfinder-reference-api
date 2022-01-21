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
    public class HunterAutomaton : Template
    {
        public static readonly Guid ID = Guid.Parse("421471f7-f1cb-48bd-8805-d9d403fa0896");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Hunter Automaton"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7ea5022b-9c6d-43c5-8314-959e17f7ce37"), Type = TextBlockType.Text, Text = "You were designed to serve as a scout or assassin and have a body resembling a pack hunter like a large cat or wolf. Though you typically move like a quadruped, you can still stand and fight like a biped, allowing you to use all equipment normally. Your quadruped design allows you to move quickly; if you have both hands free, you can increase your Speed to 30 feet as you run on all fours." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpeed(Guid.Parse("66aa8236-aa40-4d41-9523-223fb63a19b4"), MovementMethod.Walking, speed: 30, addendum: "Only applies if you have both hands free and run on all fours.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5425859a-8d19-4348-9048-761b0f43eea9"),
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
