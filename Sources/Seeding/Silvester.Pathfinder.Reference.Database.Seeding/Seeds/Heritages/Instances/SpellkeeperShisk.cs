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
    public class SpellkeeperShisk : Template
    {
        public static readonly Guid ID = Guid.Parse("4df99081-a948-4a34-9b28-80274917e97e");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Spellkeeper Shisk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("460028e4-b436-4524-af2a-9198b8fd37c9"), Type = TextBlockType.Text, Text = "Your magical knowledge allows you to cast simple spells. Choose occult or primal. You gain one cantrip from that magical tradition's spell list. You can cast this spell as an innate spell at will, as a spell of your chosen tradition. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("262a5eb9-7076-4915-8e4a-7cb67a5ee441"), or => 
            {
                or.GainSpecificMagicTraditionAnyInnateSpell(Guid.Parse("fc40c2cf-27a6-48a9-b053-03036fed0655"), MagicTraditions.Instances.Occult.ID, spellLevel: 0);
                or.GainSpecificMagicTraditionAnyInnateSpell(Guid.Parse("31127a76-d550-4c5f-b721-4a165b8718c1"), MagicTraditions.Instances.Primal.ID, spellLevel: 0);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f81c4259-6b77-47d0-8f1b-f4fe38e89998"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 123
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Shisk.ID;
        }
    }
}
