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
    public class RiteOfInvocation : Template
    {
        public static readonly Guid ID = Guid.Parse("30367bd3-e63e-409f-84a4-0dcd8197dbe2");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Rite of Invocation"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ed790450-642d-4cbd-b6c4-f2d2bc05ca8b"), Type = TextBlockType.Text, Text = "You augmented your exoskeleton with magic. You gain one cantrip from the arcane or occult spell list. You can cast this spell as an innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("c8ac1d7b-2b74-4f1d-86e1-8ce23249f962"), or => 
            {
                or.GainSpecificMagicTraditionAnyInnateSpell(Guid.Parse("5e3e6047-c157-489d-a5ea-5e8422f8f091"), MagicTraditions.Instances.Arcane.ID, spellLevel: 0);
                or.GainSpecificMagicTraditionAnyInnateSpell(Guid.Parse("53e13073-bb39-43dd-b7bd-2b68bb5403b1"), MagicTraditions.Instances.Occult.ID, spellLevel: 0);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2d78e5f-ac6c-41ad-999c-200975bbda8b"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 108
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Conrasu.ID;
        }
    }
}
