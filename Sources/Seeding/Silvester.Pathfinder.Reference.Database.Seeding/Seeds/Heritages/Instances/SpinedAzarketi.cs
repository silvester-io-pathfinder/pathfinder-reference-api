using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SpinedAzarketi : Template
    {
        public static readonly Guid ID = Guid.Parse("78ddc2f0-e8d4-4fc3-9281-228e9c8d85a6");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Spined Azarketi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("35033ddc-d601-47df-bec0-c1de91895d9e"), Type = TextBlockType.Text, Text = "Your fins conceal launchable toxic spines. You have a spine ranged unarmed attack with the unarmed trait that deals 1d4 poison damage, has a range increment of 10 feet, and is in the dart weapon group." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add the fact that this is a ranged unarmed attack.
            builder.GainSpecificUnarmedAttack(Guid.Parse("0a05eec1-a43b-42b4-8da8-01519b6afa5f"), UnarmedWeapons.Instances.Spine.ID, WeaponGroups.Instances.Dart.ID, DamageTypes.Instances.Poison.ID, damage: "1d4");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c137f02-ffbb-48b9-b399-f8697dd4c1d8"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 13
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Azarketi.ID;
        }
    }
}
