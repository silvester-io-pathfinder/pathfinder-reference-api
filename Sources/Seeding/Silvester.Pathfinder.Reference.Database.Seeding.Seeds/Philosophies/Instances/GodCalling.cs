using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Philosophies.Instances
{
    public class GodCalling : Template
    {
        public static readonly Guid ID = Guid.Parse("f9eaea6d-0edf-473a-9b4f-b74417dddda6");
        
        protected override Philosophy GetPhilosophy()
        {
            return new Philosophy
            {
                Id = ID, 
                Name = "God Calling",
                Edicts = "The gods of Sarkoris have very few shared edicts, but several are often prominently shared amongst them: protect your clan and your people, educate the clan's children's in the traditions and histories of the clan's god, and carefully record the name and image of each new god when they first appear so that they are not forgotten and can continue to watch over the people.",
                Anathema = "There is only one anathema universally enforced by the gods of Sarkoris: make no deals or bargains with demons, as the advent of the Worldwound led to the destruction of many clans and the loss of many gods, some of whom may never be seen again.",
                AreasOfConcern = "Each god has their own particular inclinations and interests, typically informed by the predominant attitudes and beliefs of their clan."
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a94c6069-a4d9-4cd8-9395-b8f4e7c691df"), Type = TextBlockType.Text, Text = "The ancient art of god calling was once the predominant religious practice in Sarkoris, long before the Worldwound erupted and demons drove most of the native Sarkorians from their homelands. This art, one part magical theory and one part religion, allows certain Sarkorians to summon unusual and unique beings from the Great Beyond who protect their clans and guide their people. These creatures are typically referred to as gods by those who revere them, and they continue to return and guide their people generation after generation, so long as someone trained by a previous god caller or otherwise educated in the practice of communing with a particular god is alive to form a tether to the Material Plane so that the god can manifest. These god callers may have unique titles or names among the people of their clan, and such monikers differ from clan to clan, but most of the clans of Sarkoris are able to distinguish a god caller by their unique dress or glyph that ties the caller to their god." };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbe12fc4-55dd-424b-a304-b80181a19c7c"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 97
            };
        }
    }
}
