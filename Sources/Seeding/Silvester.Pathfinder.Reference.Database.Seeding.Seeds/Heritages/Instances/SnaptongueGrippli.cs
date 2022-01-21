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
    public class SnaptongueGrippli : Template
    {
        public static readonly Guid ID = Guid.Parse("c49bca23-aa06-4343-b9a5-2e8e02db5b17");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Snaptongue Grippli"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("31e2290e-f884-4f9a-8069-354c78b6c4bd"), Type = TextBlockType.Text, Text = "Your tongue is especially long, and you can launch it with extraordinary range and precision. You can use your tongue to deliver touch-range spells and perform extremely simple Interact actions, such as opening some types of unlocked doors. Your tongue can't perform actions that require fingers or significant manual dexterity, including any action that would require a check to accomplish, and you can't use it to hold items." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("37b09132-a85f-429c-9d33-84ed5cd97f99"), "You can use your tongue to deliver touch-range spells and perform extremely simple Interact actions, such as opening some types of unlocked doors. Your tongue can't perform actions that require fingers or significant manual dexterity, including any action that would require a check to accomplish, and you can't use it to hold items.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2990ac8d-7c7e-4a7f-b4f2-48bcf6ee4768"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 119
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Grippli.ID;
        }
    }
}
