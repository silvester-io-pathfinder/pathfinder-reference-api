using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class OffensiveBoost : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Offensive Boost", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’ve made additions to your innovation to upgrade your offensive capabilities. Your improvements make any Strikes that rely on your innovation deal an additional 1d6 damage, with a type determined by the boost you choose. If your innovation is armor, the boost applies to your melee unarmed Strikes and to your melee Strikes with one weapon you choose during daily preparations; if your innovation is a construct, the boost applies to your construct companion’s Strikes; and if your innovation is a weapon, the boost applies to your Strikes with your innovation. You can spend downtime to switch to a different boost in the same way as switching your modification. Choose one of the following boosts, with the damage type in parentheses." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Chill (Cold): Your innovation rapidly absorbs heat, creating an intense chill." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Ignition (Fire): Your innovation shoots out jets of searing flame." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Jolt (Electricity): Your innovation jolts foes with charges of electricity." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Momentum (Bludgeoning): Your innovation slams into foes with added momentum." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Saws (Slashing): Your innovation reveals spinning sawblades during your attacks." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Spike (Piercing): Your innovation reveals wicked spikes during your attacks." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Vitriol (Acid): Your innovation releases spurts of caustic acid." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 22
            };
        }
    }
}
