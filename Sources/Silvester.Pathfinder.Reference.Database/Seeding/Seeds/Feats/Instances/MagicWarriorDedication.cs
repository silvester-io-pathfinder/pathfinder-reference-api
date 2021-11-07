using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicWarriorDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d55b6b6f-54d0-4aa3-ac93-aa3307b16394");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magic Warrior Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the magic warrior archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ec481dba-2a21-4f83-a180-fb800b0fe35f"), Type = TextBlockType.Text, Text = "~ Access: You are from the Mwangi Expanse." };
            yield return new TextBlock { Id = Guid.Parse("8610c498-c3e9-45af-bf7e-d14650d9808a"), Type = TextBlockType.Text, Text = "You have taken up a nameless mask and sworn the oath of the magic warriors. You become trained in your choice of Arcana or Nature and in Magic Warrior Lore; if you were already trained in the skill, you become an expert instead." };
            yield return new TextBlock { Id = Guid.Parse("98745cb3-c7f3-4c64-84cf-b4cdd6604314"), Type = TextBlockType.Text, Text = "You hide your identity behind a mask representing an animal of your choice, corresponding to one of the general animal types in the (spell: animal form) spell. You gain a +1 circumstance bonus to saves against (trait: divination) effects, though sometimes refusing to remove your mask can cause issues in areas that don’t respect or understand the magic warrior tradition." };
            yield return new TextBlock { Id = Guid.Parse("550ac017-afc0-460d-b6ad-0463759e8c8a"), Type = TextBlockType.Text, Text = "Once you take this feat, if another creature ever learns your true face or name, you lose your abilities from this archetype. Close allies who knew of your decision to take the mask before your dedication don’t break this taboo unless they tell someone else. To regain your abilities, you must discard your mask and obtain a new one of a different animal, then retrain Magic Warrior Dedication into a new Magic Warrior Dedication with your new mask. Your focus spells from the magic warrior archetype are the same tradition as your other spells (choose one if you have spells from multiple traditions)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFocusPool(Guid.Parse("58e4e647-afdf-40e6-84a2-e87df1eea215"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c1e40eb-5a19-45a2-a492-587793db5ace"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
