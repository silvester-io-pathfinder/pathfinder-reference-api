using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Coven : Template
    {
        public static readonly Guid ID = Guid.Parse("5139b0bd-7fa1-4880-92aa-c252336289ce");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Coven",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("493c2899-16c8-49bc-933c-e17221a661c8"), Text = "This monster can form a coven with two or more other creatures who also have the coven ability. This involves performing an 8-hour ceremony with all prospective coven members. After the coven is formed, each of its members gains elite adjustments, adjusting their levels accordingly. Coven members can sense other members� locations and conditions by spending a single action, which has the concentrate trait, and can sense what another coven member is sensing as a two-action activity, which has the concentrate trait as well." };
            yield return new TextBlock { Id = Guid.Parse("381fc721-0e8a-4617-b4fb-fbf3ddbab943"), Text = "Covens also grant spells and rituals to their members, but these can be cast only in cooperation between three coven members who are all within 30 feet of one another. A coven member can contribute to a coven spell with a single-action spellcasting activity that has a single verbal component. If two coven members have contributed these actions within the last round, a third member can cast a coven spell on her turn by spending the normal spellcasting actions. A coven can cast its coven spells an unlimited number of times but can cast only one coven spell each round. All covens grant the 8th-level baleful polymorph spell and all the following spells, which the coven can cast at any level up to 5th: augury, charm, clairaudience, clairvoyance, dream message, illusory disguise, illusory scene, prying eye, and talking corpse. Individual creatures with the coven ability also grant additional spells to any coven they join. A coven can also cast the control weather ritual, with a DC of 23 instead of the standard DC." };
            yield return new TextBlock { Id = Guid.Parse("63c2f683-ae6f-4749-9d2f-8b691f82d17e"), Text = "If a coven member leaving the coven or the death of a coven member brings the coven below three members, the remaining members keep their elite adjustments for 24 hours, but without enough members to contribute the necessary actions, they can�t cast coven spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Occult.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0b2d93f-9618-4b1c-a1a6-99698316564d"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
